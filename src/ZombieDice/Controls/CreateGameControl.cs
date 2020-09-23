using System;
using System.Drawing;
using System.Windows.Forms;
using ZombieDice.App.Storage;

namespace ZombieDice.App.Controls
{
    public partial class CreateGameControl : UserControl
    {
        private readonly LocalStore _localStore;
        public CreateGameControl(LocalStore localStore)
        {
            _localStore = localStore;
            InitializeComponent();
        }

        public event EventHandler CreateGameClicked;
        private void tb_GameName_TextChanged(object sender, EventArgs e)
        {
            this.tb_GameName.BackColor = Color.White;
            _localStore.SetGameName(tb_GameName.Text);
        }

        private void btn_CreateGame_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tb_GameName.Text))
            {
                CreateGameClicked?.Invoke(this, e);
            }
            else
            {
                this.tb_GameName.Focus();
                this.tb_GameName.BackColor = Color.LightPink;
            }
        }

        private void tb_GameName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(this.tb_GameName.Text))
            {
                CreateGameClicked?.Invoke(this, e);
            }
        }
    }
}
