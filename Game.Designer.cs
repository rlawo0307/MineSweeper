
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
            this.PictureBox_Bomb = new System.Windows.Forms.PictureBox();
            this.Label_Bomb = new System.Windows.Forms.Label();
            this.PictureBox_Time = new System.Windows.Forms.PictureBox();
            this.Label_Time = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Time)).BeginInit();
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
            this.초급ToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.초급ToolStripMenuItem.Text = "초급";
            this.초급ToolStripMenuItem.Click += new System.EventHandler(this.초급ToolStripMenuItem_Click);
            // 
            // 중급ToolStripMenuItem
            // 
            this.중급ToolStripMenuItem.Name = "중급ToolStripMenuItem";
            this.중급ToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.중급ToolStripMenuItem.Text = "중급";
            // 
            // 고급ToolStripMenuItem
            // 
            this.고급ToolStripMenuItem.Name = "고급ToolStripMenuItem";
            this.고급ToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.고급ToolStripMenuItem.Text = "고급";
            // 
            // PictureBox_Bomb
            // 
            this.PictureBox_Bomb.Location = new System.Drawing.Point(182, 45);
            this.PictureBox_Bomb.Name = "PictureBox_Bomb";
            this.PictureBox_Bomb.Size = new System.Drawing.Size(100, 50);
            this.PictureBox_Bomb.TabIndex = 5;
            this.PictureBox_Bomb.TabStop = false;
            // 
            // Label_Bomb
            // 
            this.Label_Bomb.AutoSize = true;
            this.Label_Bomb.Location = new System.Drawing.Point(321, 76);
            this.Label_Bomb.Name = "Label_Bomb";
            this.Label_Bomb.Size = new System.Drawing.Size(54, 18);
            this.Label_Bomb.TabIndex = 6;
            this.Label_Bomb.Text = "label1";
            // 
            // PictureBox_Time
            // 
            this.PictureBox_Time.Location = new System.Drawing.Point(416, 45);
            this.PictureBox_Time.Name = "PictureBox_Time";
            this.PictureBox_Time.Size = new System.Drawing.Size(100, 50);
            this.PictureBox_Time.TabIndex = 7;
            this.PictureBox_Time.TabStop = false;
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Location = new System.Drawing.Point(555, 76);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(54, 18);
            this.Label_Time.TabIndex = 8;
            this.Label_Time.Text = "label2";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.PictureBox_Time);
            this.Controls.Add(this.Label_Bomb);
            this.Controls.Add(this.PictureBox_Bomb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Time)).EndInit();
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
        private System.Windows.Forms.PictureBox PictureBox_Bomb;
        private System.Windows.Forms.Label Label_Bomb;
        private System.Windows.Forms.PictureBox PictureBox_Time;
        private System.Windows.Forms.Label Label_Time;
    }
}