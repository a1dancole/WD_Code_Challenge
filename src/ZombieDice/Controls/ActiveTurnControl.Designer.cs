namespace ZombieDice.App.Controls
{
    partial class ActiveTurnControl
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
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_Lives = new System.Windows.Forms.Label();
            this.btn_Dice1 = new System.Windows.Forms.Button();
            this.btn_Dice2 = new System.Windows.Forms.Button();
            this.btn_Dice3 = new System.Windows.Forms.Button();
            this.btn_Roll = new System.Windows.Forms.Button();
            this.btn_EndTurn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flp_CupOfDice = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Score, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Lives, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Dice1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Dice2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Dice3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Roll, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_EndTurn, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.94104F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.17688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.88208F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Score.Location = new System.Drawing.Point(159, 0);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(150, 15);
            this.lbl_Score.TabIndex = 0;
            this.lbl_Score.Text = "Score:";
            // 
            // lbl_Lives
            // 
            this.lbl_Lives.AutoSize = true;
            this.lbl_Lives.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Lives.Location = new System.Drawing.Point(315, 0);
            this.lbl_Lives.Name = "lbl_Lives";
            this.lbl_Lives.Size = new System.Drawing.Size(152, 15);
            this.lbl_Lives.TabIndex = 1;
            this.lbl_Lives.Text = "Lives:";
            // 
            // btn_Dice1
            // 
            this.btn_Dice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Dice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Dice1.Enabled = false;
            this.btn_Dice1.Location = new System.Drawing.Point(3, 85);
            this.btn_Dice1.Name = "btn_Dice1";
            this.btn_Dice1.Size = new System.Drawing.Size(150, 106);
            this.btn_Dice1.TabIndex = 2;
            this.btn_Dice1.UseVisualStyleBackColor = true;
            // 
            // btn_Dice2
            // 
            this.btn_Dice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Dice2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Dice2.Enabled = false;
            this.btn_Dice2.Location = new System.Drawing.Point(159, 85);
            this.btn_Dice2.Name = "btn_Dice2";
            this.btn_Dice2.Size = new System.Drawing.Size(150, 106);
            this.btn_Dice2.TabIndex = 3;
            this.btn_Dice2.UseVisualStyleBackColor = true;
            // 
            // btn_Dice3
            // 
            this.btn_Dice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Dice3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Dice3.Enabled = false;
            this.btn_Dice3.Location = new System.Drawing.Point(315, 85);
            this.btn_Dice3.Name = "btn_Dice3";
            this.btn_Dice3.Size = new System.Drawing.Size(152, 106);
            this.btn_Dice3.TabIndex = 4;
            this.btn_Dice3.UseVisualStyleBackColor = true;
            // 
            // btn_Roll
            // 
            this.btn_Roll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Roll.Location = new System.Drawing.Point(3, 293);
            this.btn_Roll.Name = "btn_Roll";
            this.btn_Roll.Size = new System.Drawing.Size(150, 64);
            this.btn_Roll.TabIndex = 5;
            this.btn_Roll.Text = "Roll";
            this.btn_Roll.UseVisualStyleBackColor = true;
            this.btn_Roll.Click += new System.EventHandler(this.btn_Roll_Click);
            // 
            // btn_EndTurn
            // 
            this.btn_EndTurn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_EndTurn.Location = new System.Drawing.Point(315, 293);
            this.btn_EndTurn.Name = "btn_EndTurn";
            this.btn_EndTurn.Size = new System.Drawing.Size(152, 64);
            this.btn_EndTurn.TabIndex = 6;
            this.btn_EndTurn.Text = "End Turn";
            this.btn_EndTurn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flp_CupOfDice, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 366);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flp_CupOfDice
            // 
            this.flp_CupOfDice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_CupOfDice.Location = new System.Drawing.Point(479, 3);
            this.flp_CupOfDice.Name = "flp_CupOfDice";
            this.flp_CupOfDice.Size = new System.Drawing.Size(328, 360);
            this.flp_CupOfDice.TabIndex = 1;
            // 
            // ActiveTurnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ActiveTurnControl";
            this.Size = new System.Drawing.Size(810, 596);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_Lives;
        private System.Windows.Forms.Button btn_Dice1;
        private System.Windows.Forms.Button btn_Dice2;
        private System.Windows.Forms.Button btn_Dice3;
        private System.Windows.Forms.Button btn_Roll;
        private System.Windows.Forms.Button btn_EndTurn;
        private System.Windows.Forms.FlowLayoutPanel flp_CupOfDice;
    }
}
