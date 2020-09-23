using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MassTransit;
using ZombieDice.App.Controls;
using ZombieDice.App.Properties;
using ZombieDice.App.Storage;
using ZombieDice.Shared.Dtos;

namespace ZombieDice.App
{
    public partial class MainWindow : Form
    {
        private readonly EnterNameControl _enterNameControl;
        private readonly LandingControl _joinGameControl;
        private readonly CreateGameControl _createGameControl;
        private readonly ActiveTurnControl _activeTurnControl;
        private readonly LocalStore _localStore;
        private readonly IBus _bus;
        public MainWindow(EnterNameControl enterNameControl, LandingControl joinGameControl, CreateGameControl createGameControl, ActiveTurnControl activeTurnControl, IBus bus, LocalStore localStore)
        {
            _enterNameControl = enterNameControl;
            _joinGameControl = joinGameControl;
            _createGameControl = createGameControl;
            _activeTurnControl = activeTurnControl;
            _bus = bus;
            _localStore = localStore;

            InitializeComponent();
            InitializeComponentProperties();
            InitializeComponentEvents();
        }

        private void InitializeComponentProperties()
        {
            //this.pb_Zombie.Image = Resources.zombie;
            this.tbl_Layout.Controls.Add(_enterNameControl,1,0);
        }

        private void InitializeComponentEvents()
        {
            _enterNameControl.StartClicked += delegate
            {
                this.tbl_Layout.Controls.Remove(_enterNameControl);
                this.tbl_Layout.Controls.Add(_joinGameControl,1,0);
            };

            _joinGameControl.JoinGameClicked += async delegate
            {
                this.tbl_Layout.Controls.Remove(_joinGameControl);
                this.tbl_Layout.Controls.Add(_joinGameControl, 1, 0);
                await JoinGame();
            };

            _joinGameControl.NewGameClicked += delegate
            {
                this.tbl_Layout.Controls.Remove(_joinGameControl);
                this.tbl_Layout.Controls.Add(_createGameControl, 1, 0);
            };

            _createGameControl.CreateGameClicked += async delegate
            {
                this.tbl_Layout.Controls.Remove(_createGameControl);
                this.tbl_Layout.Controls.Add(_activeTurnControl, 1, 0);
                await CreateGame();
            };
        }

        private async Task CreateGame()
        {
            await _bus.Publish(new CreateGameDto
            {
                GameName = _localStore.GameName,
                PlayerName = _localStore.PlayerName
            });
        }

        private async Task JoinGame()
        {
            await _bus.Publish(new PlayerJoinedDto
            {
                PlayerName = _localStore.PlayerName,
                GameName = _localStore.GameName
            });
        }
    }
}
