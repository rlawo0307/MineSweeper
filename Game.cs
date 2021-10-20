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
        private int beginner = 5, intermediate = 10, advanced = 15;
        private Button[,] buttons;
        private int[,] board;

        public Game()
        {
            InitializeComponent();

            PictureBox_Bomb.Load(@"./res/bomb.png");
            PictureBox_Bomb.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_Time.Load(@"./res/time.png");
            PictureBox_Time.SizeMode = PictureBoxSizeMode.StretchImage;

            Play_Game(1);
        }

        private void Play_Game(int op)
        {
            int col, row;

            if (op == 1) // beginner
                col = row = beginner;
            else if (op == 2) // intermidiage
                col = row = intermediate;
            else
                col = row = advanced;

            Init_Board(col, row);
        }


        private void Init_Board(int col, int row)
        {
            //MessageBox.Show(""+board.GetLength(0)+","+board.GetLength(1));
            board = new int[col, row]; // 자동으로 0으로 초기화
            buttons = new Button[col, row];
            for (int i = 0; i < col; i++)
                for (int j = 0; j < row; j++)
                {
                    board[i, j] = i * 10 + j;
                    buttons[i, j] = new Button();
                    buttons[i, j].Location = new Point(board_x + j * button_width, board_y + i * button_height);
                    buttons[i, j].Width = button_width;
                    buttons[i, j].Height = button_height;
                    buttons[i, j].BackColor = System.Drawing.Color.Green;
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].FlatAppearance.BorderSize = 0;
                    buttons[i, j].Text = board[i, j].ToString();
                    buttons[i, j].Click += new EventHandler(btnClick);
                    this.Controls.Add(buttons[i, j]);
                }
        }

        private void 초급ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play_Game(1);
        }

        private void 중급ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play_Game(2);
        }

        private void 고급ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play_Game(3);
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClick(object sender, EventArgs e)
        {
            int n;
            Button btn = sender as Button;  // 현재 버튼 객체

            MessageBox.Show("" + btn.Text);
        }
    }
}
