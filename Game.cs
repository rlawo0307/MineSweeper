using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Game : Form
    {
        private int board_x = 10, board_y = 100;
        private int button_width = 30, button_height = 30;
        private Button[,] buttons;
        private int[,] board;

        public Game()
        {
            InitializeComponent();

            PictureBox_Bomb.Load(@"./res/bomb.png");
            PictureBox_Bomb.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_Time.Load(@"./res/time.png");
            PictureBox_Time.SizeMode = PictureBoxSizeMode.StretchImage;

            int op = 1;
            Init_Board(); // level-beginner
            Play_Game();
        }

        private void Init_Board()
        {
            //MessageBox.Show(""+board.GetLength(0)+","+board.GetLength(1));
            board = new int[5, 5]; // 자동으로 0으로 초기화
            buttons = new Button[5, 5];
            for (int i = 0; i < board.GetLength(0); i++)
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Left = board_x + j * button_width;
                    buttons[i, j].Top = board_y + i * button_height;
                    buttons[i, j].Width = button_width;
                    buttons[i, j].Height = button_height;
                    buttons[i,j].BackColor = System.Drawing.Color.Green;
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].FlatAppearance.BorderSize = 0;
                    buttons[i, j].Text = board[i, j].ToString();
                    this.Controls.Add(buttons[i, j]);
                }
        }

        private void Play_Game()
        {
            
        }

        private void 초급ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ;
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
