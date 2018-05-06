using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace game_test
{
    public partial class Form1 : Form
    {
        Game g = new Game();
        Random rand = new Random();

        public int[,] board = new int[4, 4];
        public int[,] oldboard = new int[4, 4];
        public int[] ind = new int [32];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var labels = new[,] { 
                    {label1, label2, label3, label4},
                    {label5, label6, label7, label8},
                    {label9, label10, label11, label12}, 
                    {label13, label14, label15, label16}
                };

            for (int q = 0; q < 4; q++) {
                for (int w = 0; w < 4; w++) {
                    labels[q, w].Text = Convert.ToString(0);
                    board[q, w] = 0;
                }
            }
              
                int i = 0;
                int j = 0;
                int n = 0;

            for (int p = 0; p < 2; p++) {
                i = rand.Next(0, 3);
                j = rand.Next(0, 3);
                n = rand.Next(0, 100);

                if (n <= 90)
                {
                    labels[i, j].Text = Convert.ToString(2);
                    board[i, j] = 2;
                }
                else
                {
                    labels[i, j].Text = Convert.ToString(4);
                    board[i, j] = 4;
                }    
            }

            g.getBoard(board);

        }

        private void ran()
        {
            int o = 0;
            int qq = 0;
            int ww = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] < 1) {
                        o = 1;
                    }
                }
            }

            if (o >= 1) {
                while (o < 2)
                {
                    qq = rand.Next(0, 3);
                    ww = rand.Next(0, 3);
                    if (board[qq, ww] < 1)
                    {
                        board[qq, ww] = 2;
                        o++;
                    }
                }
            }
            
        }


        private void checkWon() {
            var labels = new[,] { 
                    {label1, label2, label3, label4},
                    {label5, label6, label7, label8},
                    {label9, label10, label11, label12}, 
                    {label13, label14, label15, label16}
                };

            for (int q = 0; q < 4; q++)
            {
                for (int w = 0; w < 4; w++)
                {
                    if (Convert.ToInt32(labels[q, w].Text) == 64) {
                        label17.Text = "Победа!";
                    }
                    
                }
            }
        }

        private void checkLose() {

            int r = 0;
            int[] temp = { 0, 0, 0, 0 };

            var labels = new[,] { 
                    {label1, label2, label3, label4},
                    {label5, label6, label7, label8},
                    {label9, label10, label11, label12}, 
                    {label13, label14, label15, label16}
                };

            for (int q = 0; q < 4; q++)
            {
                for (int w = 0; w < 4; w++)
                {
                    if (Convert.ToInt32(labels[q, w].Text) < 1)
                    {
                        r=1;
                    }
                }
            }

            if ((oldboard == board) && (r==0)) {
                label17.Text = "Проигрыш";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var labels = new[,] { 
                    {label1, label2, label3, label4},
                    {label5, label6, label7, label8},
                    {label9, label10, label11, label12}, 
                    {label13, label14, label15, label16}
                };

            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    board[i, j] = Convert.ToInt32(labels[i,j].Text);
                }
            }
            oldboard = board;

            g.getBoard(board);

            g.left();

            g.setBoard(out board);

            ran();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    labels[i, j].Text = Convert.ToString(board[i, j]);
                }
            }
            checkLose();
            checkWon();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var labels = new[,] { 
                    {label1, label2, label3, label4},
                    {label5, label6, label7, label8},
                    {label9, label10, label11, label12}, 
                    {label13, label14, label15, label16}
                };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    board[i, j] = Convert.ToInt32(labels[i, j].Text);
                }
            }
            oldboard = board;
            g.getBoard(board);

            g.right();

            

            g.setBoard(out board);

            ran();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    labels[i, j].Text = Convert.ToString(board[i, j]);
                }
            }

            checkWon();
            checkLose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var labels = new[,] { 
                    {label1, label2, label3, label4},
                    {label5, label6, label7, label8},
                    {label9, label10, label11, label12}, 
                    {label13, label14, label15, label16}
                };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    board[i, j] = Convert.ToInt32(labels[i, j].Text);
                }
            }
            oldboard = board;
            g.getBoard(board);

            g.up();

            
            g.setBoard(out board);

            ran();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    labels[i, j].Text = Convert.ToString(board[i, j]);
                }
            }

            checkWon();
            checkLose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                var labels = new[,] { 
                    {label1, label2, label3, label4},
                    {label5, label6, label7, label8},
                    {label9, label10, label11, label12}, 
                    {label13, label14, label15, label16}
                };

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        board[i, j] = Convert.ToInt32(labels[i, j].Text);
                    }
                }
                oldboard = board;
                g.getBoard(board);

                g.down();

                

                g.setBoard(out board);

                ran();

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        labels[i, j].Text = Convert.ToString(board[i, j]);
                    }
                }

                checkWon();
                checkLose();
            }

        private void button5_Click(object sender, EventArgs e)
        {
            var labels = new[,] { 
                    {label1, label2, label3, label4},
                    {label5, label6, label7, label8},
                    {label9, label10, label11, label12}, 
                    {label13, label14, label15, label16}
                };

            for (int q = 0; q < 4; q++)
            {
                for (int w = 0; w < 4; w++)
                {
                    labels[q, w].Text = Convert.ToString(0);
                    board[q, w] = 0;
                }
            }

            int i = 0;
            int j = 0;
            int n = 0;

            for (int p = 0; p < 2; p++)
            {
                i = rand.Next(0, 3);
                j = rand.Next(0, 3);
                n = rand.Next(0, 100);

                if (n <= 90)
                {
                    labels[i, j].Text = Convert.ToString(2);
                    board[i, j] = 2;
                }
                else
                {
                    labels[i, j].Text = Convert.ToString(4);
                    board[i, j] = 4;
                }
            }

            g.getBoard(board);


        }

        

    }
}