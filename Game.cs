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
    public partial class Game : Form
    {
        private int board_x = 10, board_y = 100;
        private int button_width = 30, button_height = 30;
        private int beginner = 5, intermediate = 10, advanced = 15;
        private Button[,] btn;
        DATA data;
        //private int[,] board;

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
            //MessageBox.Show(""+board.GetLength(0)+","+board.GetLength(1));
        }

        private void Play_Game()
        {
            Init_Data();
            Init_Board();
        }

        private void Init_Data()
        {
            if (data.op == 1) // beginner
                data.col = data.row = beginner;
            else if (data.op == 2) // intermidiage
                data.col = data.row = intermediate;
            else // advanced
                data.col = data.row = advanced;
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
            btn = new Button[data.col, data.row] ;
            for (int i = 0; i < data.col; i++)
                for (int j = 0; j < data.row; j++)
                {
                    //board[i, j] = i * 10 + j;
                    btn[i, j] = new Button();
                    btn[i, j].Location = new Point(board_x + j * button_width, board_y + i * button_height);
                    btn[i, j].Width = button_width;
                    btn[i, j].Height = button_height;
                    btn[i, j].BackColor = System.Drawing.Color.Green;
                    btn[i, j].FlatStyle = FlatStyle.Flat;
                    btn[i, j].FlatAppearance.BorderSize = 0;
                    btn[i, j].Text = data.board[i, j].ToString();
                    btn[i, j].MouseUp += btnClick;
                    this.Controls.Add(btn[i, j]);
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

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;  // 현재 버튼 객체

            //MessageBox.Show("" + btn.Text);
            if (e.Button == MouseButtons.Left)
            {

            }
            else if(e.Button == MouseButtons.Right)
            {

            }
        }
    }

}
