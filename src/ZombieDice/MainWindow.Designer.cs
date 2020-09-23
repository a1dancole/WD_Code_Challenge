namespace ZombieDice.App
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbl_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tbl_Layout
            // 
            this.tbl_Layout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbl_Layout.ColumnCount = 2;
            this.tbl_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.764115F));
            this.tbl_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.23589F));
            this.tbl_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Layout.Location = new System.Drawing.Point(0, 0);
            this.tbl_Layout.Name = "tbl_Layout";
            this.tbl_Layout.RowCount = 1;
            this.tbl_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Layout.Size = new System.Drawing.Size(797, 452);
            this.tbl_Layout.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 452);
            this.Controls.Add(this.tbl_Layout);
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.Text = "Zombie Dice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_Layout;
    }
}