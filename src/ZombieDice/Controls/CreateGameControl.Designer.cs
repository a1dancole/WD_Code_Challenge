namespace ZombieDice.App.Controls
{
    partial class CreateGameControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_GameName = new System.Windows.Forms.TextBox();
            this.btn_CreateGame = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tb_GameName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_CreateGame, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 206);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_GameName
            // 
            this.tb_GameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_GameName.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_GameName.Location = new System.Drawing.Point(3, 3);
            this.tb_GameName.Name = "tb_GameName";
            this.tb_GameName.Size = new System.Drawing.Size(220, 26);
            this.tb_GameName.TabIndex = 0;
            this.tb_GameName.Text = "GameState Name";
            this.tb_GameName.TextChanged += new System.EventHandler(this.tb_GameName_TextChanged);
            this.tb_GameName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_GameName_KeyDown);
            // 
            // btn_CreateGame
            // 
            this.btn_CreateGame.BackColor = System.Drawing.Color.LightGreen;
            this.btn_CreateGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CreateGame.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateGame.Location = new System.Drawing.Point(3, 106);
            this.btn_CreateGame.Name = "btn_CreateGame";
            this.btn_CreateGame.Size = new System.Drawing.Size(220, 97);
            this.btn_CreateGame.TabIndex = 1;
            this.btn_CreateGame.Text = "Create";
            this.btn_CreateGame.UseVisualStyleBackColor = false;
            this.btn_CreateGame.Click += new System.EventHandler(this.btn_CreateGame_Click);
            // 
            // CreateGameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateGameControl";
            this.Size = new System.Drawing.Size(226, 206);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_GameName;
        private System.Windows.Forms.Button btn_CreateGame;
    }
}
