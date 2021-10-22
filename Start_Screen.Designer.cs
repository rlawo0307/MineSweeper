
namespace MineSweeper
{
    partial class Main_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Play = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Play
            // 
            this.Button_Play.Location = new System.Drawing.Point(216, 307);
            this.Button_Play.Name = "Button_Play";
            this.Button_Play.Size = new System.Drawing.Size(155, 67);
            this.Button_Play.TabIndex = 1;
            this.Button_Play.Text = "게임 시작";
            this.Button_Play.UseVisualStyleBackColor = true;
            this.Button_Play.Click += new System.EventHandler(this.Button_Play_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(416, 307);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(155, 67);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "종료";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(216, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 54);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "\r\n\r\nMine Sweeper\r\n\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.Button_Play);
            this.Name = "Main_Form";
            this.Text = "지뢰 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Play;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox1;
    }
}

