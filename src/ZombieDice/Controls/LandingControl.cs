using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZombieDice.App.Extensions;
using ZombieDice.App.Storage;
using ZombieDice.App.ViewModels;

namespace ZombieDice.App.Controls
{
    public partial class LandingControl : UserControl
    {
        private readonly LocalStore _localStore;
        public LandingControl(LocalStore localStore)
        {
            _localStore = localStore;

            InitializeComponent();
            InitializeComponentEvents();
        }

        public event EventHandler NewGameClicked = null!;
        public event EventHandler JoinGameClicked = null!;

        private void InitializeComponentEvents()
        {
            _localStore.PlayerNameChanged += delegate(object? sender, EventArgs args)
            {
                this.lbl_PlayerName.Text = $@"{((NameChangedEventArgs) args).PlayerName}";
            };

            _localStore.AvailableGamesChanged += delegate(object? sender, EventArgs args)
            {
                dgv_AvailableGames.ThreadSafeInvoke(() =>
                {
                    dgv_AvailableGames.DataSource =
                        ((AvailableGamesChangedEventArgs)args).AvailableGames.Select(o =>
                            new AvailableGamesViewModel
                            {
                                GameName = o.GameName,
                                TotalPlayers = o.Players.Length
                            }).ToList();
                });
                dgv_AvailableGames.ThreadSafeInvoke(() => dgv_AvailableGames.Update());
                dgv_AvailableGames.ThreadSafeInvoke(() => dgv_AvailableGames.Refresh());
            };
        }

        private void btn_NewtGame_Click(object sender, EventArgs e)
        {
            NewGameClicked?.Invoke(this, e);
        }

        private void btn_JoinGame_Click(object sender, EventArgs e)
        {
            JoinGameClicked?.Invoke(this, e);
        }
    }
}
