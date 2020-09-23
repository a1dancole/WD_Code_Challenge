using System;
using System.Drawing;
using System.Windows.Forms;
using ZombieDice.App.Storage;

namespace ZombieDice.App.Controls
{
    public partial class EnterNameControl : UserControl
    {
        private readonly LocalStore _localStore;
        public EnterNameControl(LocalStore localStore)
        {
            _localStore = localStore;

            InitializeComponent();
        }

        public event EventHandler StartClicked;

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            this.tb_Name.BackColor = Color.White;
            _localStore.SetPlayerName(this.tb_Name.Text);
        }
        private void tb_Name_Enter(object sender, EventArgs e)
        {
            this.tb_Name.Text = string.Empty;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tb_Name.Text))
            {
                StartClicked?.Invoke(this, e);
            }
            else
            {
                this.tb_Name.Focus();
                this.tb_Name.BackColor = Color.LightPink;
            }
        }

        private void tb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(this.tb_Name.Text))
            {
                StartClicked?.Invoke(this, e);
            }
        }
    }
}
