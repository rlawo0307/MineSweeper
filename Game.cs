using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

struct DATA
{
    public int op; // 1-beginner, 2-intermidiate, 3-advanced
    public int col;
    public int row;
    public int bomb;
    public int time;
    public int[,] board;
}

namespace MineSweeper
{
    static class Const
    {
        public const int board_x = 10, board_y = 100;
        public const int btn_width = 30, btn_height = 30;
        public const int beginner_col = 8, beginner_row = 10, beginner_bomb = 10;
        public const int intermediate_col = 14, intermediate_row = 18, intermediate_bomb = 40;
        public const int advanced_col = 20, advanced_row = 24, advanced_bomb = 99;

    }

    public partial class Game : Form
    {
        private Button[,] btn;
        DATA data;

        public Game()
        {
            InitializeComponent();

            PictureBox_Bomb.Load(@"./res/bomb.png");
            PictureBox_Bomb.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_Time.Load(@"./res/time.png");
            PictureBox_Time.SizeMode = PictureBoxSizeMode.StretchImage;

            data = new DATA();
            data.op = 1;
            Play_Game();
        }

        private void Play_Game()
        {
            Init_Data();
            Init_Board();
            Label_Bomb.Text = data.bomb.ToString();
        }

        private void Init_Data()
        {
            if (data.op == 1) // beginner
            {
                data.col = Const.beginner_col;
                data.row = Const.beginner_row;
                data.bomb = Const.beginner_bomb;
            }
            else if (data.op == 2) // intermediate
            {
                data.col = Const.intermediate_col;
                data.row = Const.intermediate_row;
                data.bomb = Const.intermediate_bomb;
            }
            else // advanced
            {
                data.col = Const.advanced_col;
                data.row = Const.advanced_row;
                data.bomb = Const.advanced_bomb;
            }
        }

        private void Init_Board()
        {
            if (data.board != null)
                for (int i = 0; i < data.board.GetLength(0); i++)
                    for (int j = 0; j < data.board.GetLength(1); j++)
                    {
                        this.Controls.Remove(btn[i, j]);
                    }

            data.board = new int[data.col, data.row]; // 자동으로 0으로 초기화
            Rand_Bomb();
            btn = new Button[data.col, data.row] ;
            for (int i = 0; i < data.col; i++)
                for (int j = 0; j < data.row; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Location = new Point(Const.board_x + j * Const.btn_width, Const.board_y + i * Const.btn_height);
                    btn[i, j].Width = Const.btn_width;
                    btn[i, j].Height = Const.btn_height;
                    btn[i, j].BackColor = System.Drawing.Color.Green;
                    btn[i, j].FlatStyle = FlatStyle.Flat;
                    btn[i, j].FlatAppearance.BorderSize = 0;
                    btn[i, j].MouseUp += btnClick;
                    this.Controls.Add(btn[i, j]);
                }
        }

        private void Rand_Bomb()
        {
            Random rand = new Random();
           
            int i, j;
            int cnt = 0;

            while(cnt < data.bomb)
            {
                i = rand.Next(data.col);
                j = rand.Next(data.row);
                if (data.board[i,j] != -1) // bomb
                {
                    data.board[i, j] = -1;
                    for (int k = i - 1; k <= i + 1; k++)
                        for (int l = j - 1; l <= j + 1; l++)
                            if(0 <= k && k < data.col && 0 <= l && l < data.row)
                                if (data.board[k, l] != -1)
                                    data.board[k, l]++;
                    cnt++;
                }
            }
        }

        private void 초급ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.op = 1;
            Play_Game();
        }

        private void 중급ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.op = 2;
            Play_Game();
        }

        private void 고급ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.op = 3;
            Play_Game();
        }

        private void 다시시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play_Game();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;  // 현재 버튼 객체
            MouseEventArgs E = (MouseEventArgs)e;

            if (E.Button == MouseButtons.Right)
            {
                if (data.bomb > 0)
                {
                    if (btn.BackgroundImage != null)
                    {
                        btn.BackgroundImage = null;
                        btn.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        if (btn.BackColor == System.Drawing.Color.Green)
                        {
                            btn.BackgroundImage = Image.FromFile(@"./res/flag.png");
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            data.bomb -= 1;
                            Label_Bomb.Text = data.bomb.ToString();
                        }
                    }

                    if (data.bomb == 0)
                        MessageBox.Show("Complete!");
                }
            }
            else if(E.Button == MouseButtons.Left)
            {
                int i = (btn.Location.Y - Const.board_y) / Const.btn_height;
                int j = (btn.Location.X - Const.board_x) / Const.btn_width;

                if (data.board[i,j] == -1)
                {
                    MessageBox.Show("Game Over!");
                }
                else if (data.board[i, j] == 0)
                {
                    Find_Zero(this.btn, i, j);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(255, 255, 255);
                    btn.Text = data.board[i, j].ToString();
                }
            }
        }

        private void Find_Zero(Button[,] btn, int i, int j)
        {
            if (i < 0 || i >= data.col || j < 0 || j >= data.row)
                return;
            if (btn[i, j].BackColor == Color.FromArgb(255, 255, 255))
                return;

            btn[i, j].BackColor = Color.FromArgb(255, 255, 255);
            if (data.board[i, j] != 0)
                btn[i, j].Text = data.board[i, j].ToString();

            if( data.board[i, j] != 0)
                return;
            else
            {
                for(int k=i-1; k<=i+1; k++)
                    for(int l=j-1; l<=j+1; l++)
                        Find_Zero(btn, k, l);
            }
        }
    }

}

