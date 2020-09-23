namespace ZombieDice.App.Controls
{
    partial class LandingControl
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
            this.lbl_PlayerName = new System.Windows.Forms.Label();
            this.btn_JoinGame = new System.Windows.Forms.Button();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.lbl_ListHeader = new System.Windows.Forms.Label();
            this.dgv_AvailableGames = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AvailableGames)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_PlayerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_JoinGame, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_NewGame, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ListHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_AvailableGames, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32674F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.8479F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.82537F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 437);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_PlayerName
            // 
            this.lbl_PlayerName.AutoSize = true;
            this.lbl_PlayerName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_PlayerName.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PlayerName.Location = new System.Drawing.Point(440, 0);
            this.lbl_PlayerName.Name = "lbl_PlayerName";
            this.lbl_PlayerName.Size = new System.Drawing.Size(119, 45);
            this.lbl_PlayerName.TabIndex = 0;
            this.lbl_PlayerName.Text = "Player Name";
            // 
            // btn_JoinGame
            // 
            this.btn_JoinGame.BackColor = System.Drawing.Color.IndianRed;
            this.btn_JoinGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_JoinGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_JoinGame.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_JoinGame.Location = new System.Drawing.Point(3, 318);
            this.btn_JoinGame.Name = "btn_JoinGame";
            this.btn_JoinGame.Size = new System.Drawing.Size(275, 116);
            this.btn_JoinGame.TabIndex = 1;
            this.btn_JoinGame.Text = "Join Game";
            this.btn_JoinGame.UseVisualStyleBackColor = false;
            this.btn_JoinGame.Click += new System.EventHandler(this.btn_JoinGame_Click);
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.BackColor = System.Drawing.Color.LightGreen;
            this.btn_NewGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewGame.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NewGame.Location = new System.Drawing.Point(284, 318);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(275, 116);
            this.btn_NewGame.TabIndex = 1;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = false;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewtGame_Click);
            // 
            // lbl_ListHeader
            // 
            this.lbl_ListHeader.AutoSize = true;
            this.lbl_ListHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ListHeader.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ListHeader.Location = new System.Drawing.Point(3, 0);
            this.lbl_ListHeader.Name = "lbl_ListHeader";
            this.lbl_ListHeader.Size = new System.Drawing.Size(159, 45);
            this.lbl_ListHeader.TabIndex = 3;
            this.lbl_ListHeader.Text = "Available Games";
            // 
            // dgv_AvailableGames
            // 
            this.dgv_AvailableGames.AllowUserToAddRows = false;
            this.dgv_AvailableGames.AllowUserToDeleteRows = false;
            this.dgv_AvailableGames.AllowUserToOrderColumns = true;
            this.dgv_AvailableGames.AllowUserToResizeColumns = false;
            this.dgv_AvailableGames.AllowUserToResizeRows = false;
            this.dgv_AvailableGames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_AvailableGames.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_AvailableGames.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_AvailableGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_AvailableGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AvailableGames.Location = new System.Drawing.Point(3, 48);
            this.dgv_AvailableGames.MultiSelect = false;
            this.dgv_AvailableGames.Name = "dgv_AvailableGames";
            this.dgv_AvailableGames.ReadOnly = true;
            this.dgv_AvailableGames.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_AvailableGames.Size = new System.Drawing.Size(275, 264);
            this.dgv_AvailableGames.TabIndex = 4;
            this.dgv_AvailableGames.Text = "dataGridView1";
            // 
            // LandingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LandingControl";
            this.Size = new System.Drawing.Size(562, 437);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AvailableGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_PlayerName;
        private System.Windows.Forms.Button btn_JoinGame;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Label lbl_ListHeader;
        private System.Windows.Forms.DataGridView dgv_AvailableGames;
    }
}
