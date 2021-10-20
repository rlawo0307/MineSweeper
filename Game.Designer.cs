
namespace MineSweeper
{
    partial class Game
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.난이도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.초급ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중급ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고급ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.끝내기ToolStripMenuItem,
            this.난이도ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 난이도ToolStripMenuItem
            // 
            this.난이도ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.초급ToolStripMenuItem,
            this.중급ToolStripMenuItem,
            this.고급ToolStripMenuItem});
            this.난이도ToolStripMenuItem.Name = "난이도ToolStripMenuItem";
            this.난이도ToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.난이도ToolStripMenuItem.Text = "난이도";
            // 
            // 초급ToolStripMenuItem
            // 
            this.초급ToolStripMenuItem.Name = "초급ToolStripMenuItem";
            this.초급ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.초급ToolStripMenuItem.Text = "초급";
            this.초급ToolStripMenuItem.Click += new System.EventHandler(this.초급ToolStripMenuItem_Click);
            // 
            // 중급ToolStripMenuItem
            // 
            this.중급ToolStripMenuItem.Name = "중급ToolStripMenuItem";
            this.중급ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.중급ToolStripMenuItem.Text = "중급";
            // 
            // 고급ToolStripMenuItem
            // 
            this.고급ToolStripMenuItem.Name = "고급ToolStripMenuItem";
            this.고급ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.고급ToolStripMenuItem.Text = "고급";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 난이도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 초급ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중급ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고급ToolStripMenuItem;
    }
}