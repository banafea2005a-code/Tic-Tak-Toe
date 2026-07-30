using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toe.Properties;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
       enum EnSymbols
        {
            Quistion ,
            X ,
            O ,
        }
      
        
        public Form1()
        {
            InitializeComponent();
            
        }

        void CheckEnter( PictureBox pb)
        {
            if(pb.Tag.ToString() == EnSymbols.Quistion.ToString())
            {

                if(lblTurn.Text == "Player1")
                {
                    pb.Image = Resources.X;
                    pb.Tag = EnSymbols.X;
                    lblTurn.Text = "Player2";
                    return;

                }
                if(lblTurn.Text == "Player2")
                {
                    pb.Image = Resources.O;
                    pb.Tag = EnSymbols.O;
                    lblTurn.Text = "Player1";

                    return;

                }

            }

        }
        void EndGame()
        {
            // disaple all X,O
            pb1.Enabled = false;
            pb2.Enabled = false;
            pb3.Enabled = false;
            pb4.Enabled = false;
            pb5.Enabled = false;
            pb6.Enabled = false;
            pb7.Enabled = false;
            pb8.Enabled = false;
            pb9.Enabled = false;



        }
        void HighlightWinningCells(PictureBox Cell1,PictureBox Cell2,PictureBox Cell3)
        {
            Cell1.BackColor = Color.Green;
            Cell2.BackColor = Color.Green;
            Cell3.BackColor = Color.Green;

        }
        void CheckWinner()
        {

            // player 1 odds winning
            if (pb1.Tag.ToString() == EnSymbols.X.ToString() &&
               pb2.Tag.ToString() == EnSymbols.X.ToString() && 
               pb3.Tag.ToString() == EnSymbols.X.ToString())
            {
                HighlightWinningCells(pb1, pb2, pb3);
                lblWinner.Text = "Player1";
                MessageBox.Show("Player1 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb4.Tag.ToString() == EnSymbols.X.ToString() && 
                pb5.Tag.ToString() == EnSymbols.X.ToString() &&
                pb6.Tag.ToString() == EnSymbols.X.ToString())
            {
                HighlightWinningCells(pb4, pb5, pb6);
                lblWinner.Text = "Player1";
                MessageBox.Show("Player1 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb7.Tag.ToString() == EnSymbols.X.ToString() && 
                pb8.Tag.ToString() == EnSymbols.X.ToString() &&
                pb9.Tag.ToString() == EnSymbols.X.ToString())
            {

                HighlightWinningCells(pb7, pb8, pb9);
                lblWinner.Text = "Player1";
                MessageBox.Show("Player1 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb1.Tag.ToString() == EnSymbols.X.ToString() && 
                pb4.Tag.ToString() == EnSymbols.X.ToString() &&
                pb7.Tag.ToString() == EnSymbols.X.ToString())
            {
                HighlightWinningCells(pb1, pb4, pb7);
                lblWinner.Text = "Player1";
                MessageBox.Show("Player1 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb2.Tag.ToString() == EnSymbols.X.ToString() &&
                 pb5.Tag.ToString() == EnSymbols.X.ToString() &&
                 pb8.Tag.ToString() == EnSymbols.X.ToString())
            {
                HighlightWinningCells(pb2, pb5, pb8);
                lblWinner.Text = "Player1";
                MessageBox.Show("Player1 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb3.Tag.ToString() == EnSymbols.X.ToString() && 
                pb6.Tag.ToString() == EnSymbols.X.ToString() &&
                pb9.Tag.ToString() == EnSymbols.X.ToString())
            {
                HighlightWinningCells(pb3, pb6, pb9);
                lblWinner.Text = "Player1";
                MessageBox.Show("Player1 Is Winner", "Game Over");
                return;

            }
            if (pb1.Tag.ToString() == EnSymbols.X.ToString() && 
                pb5.Tag.ToString() == EnSymbols.X.ToString() &&
                pb9.Tag.ToString() == EnSymbols.X.ToString())
            {
                HighlightWinningCells(pb1, pb5, pb9);
                lblWinner.Text = "Player1";
                MessageBox.Show("Player1 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb3.Tag.ToString() == EnSymbols.X.ToString() &&
                pb5.Tag.ToString() == EnSymbols.X.ToString() &&
                pb7.Tag.ToString() == EnSymbols.X.ToString())
            {
                HighlightWinningCells(pb3, pb5, pb7);
                lblWinner.Text = "Player1";
                MessageBox.Show("Player1 Is Winner", "Game Over");
                EndGame();
                return;
            }
            





            // player 2 odds winning
            if (pb1.Tag.ToString() == EnSymbols.O.ToString() && 
                 pb2.Tag.ToString() == EnSymbols.O.ToString() && 
                 pb3.Tag.ToString() == EnSymbols.O.ToString())
            {
                HighlightWinningCells(pb1, pb2, pb3);
                lblWinner.Text = "Player2";
                MessageBox.Show("Player2 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb4.Tag.ToString() == EnSymbols.O.ToString() &&
                pb5.Tag.ToString() == EnSymbols.O.ToString()&&
                pb6.Tag.ToString() == EnSymbols.O.ToString())
            {
                HighlightWinningCells(pb4, pb5, pb6);
                lblWinner.Text = "Player2";
                MessageBox.Show("Player2 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb7.Tag.ToString() == EnSymbols.O.ToString() && 
                pb8.Tag.ToString() == EnSymbols.O.ToString() &&
                pb9.Tag.ToString() == EnSymbols.O.ToString())
            {

                HighlightWinningCells(pb7, pb8, pb9);
                lblWinner.Text = "Player2";
                MessageBox.Show("Player2 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb1.Tag.ToString() == EnSymbols.O.ToString() && 
                pb4.Tag.ToString() == EnSymbols.O.ToString() &&
                 pb7.Tag.ToString() == EnSymbols.O.ToString())
            {
                HighlightWinningCells(pb1, pb4, pb7);
                lblWinner.Text = "Player2";
                MessageBox.Show("Player2 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb2.Tag.ToString() == EnSymbols.O.ToString() && 
                pb5.Tag.ToString() == EnSymbols.O.ToString() &&
                 pb8.Tag.ToString() == EnSymbols.O.ToString())
            {
                HighlightWinningCells(pb2, pb5, pb8);
                lblWinner.Text = "Player2";
                MessageBox.Show("Player2 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb3.Tag.ToString() == EnSymbols.O.ToString() && 
                pb6.Tag.ToString() == EnSymbols.O.ToString() &&
                 pb9.Tag.ToString() == EnSymbols.O.ToString())
            {
                HighlightWinningCells(pb3, pb6, pb9);
                lblWinner.Text = "Player2";
                MessageBox.Show("Player2 Is Winner", "Game Over");
                return;

            }
            if (pb1.Tag.ToString() == EnSymbols.O.ToString() && 
                pb5.Tag.ToString() == EnSymbols.O.ToString() &&
                pb9.Tag.ToString() == EnSymbols.O.ToString())
            {
                HighlightWinningCells(pb1, pb5, pb9);
                lblWinner.Text = "Player2";
                MessageBox.Show("Player2 Is Winner", "Game Over");
                EndGame();
                return;
            }
            if (pb3.Tag.ToString() == EnSymbols.O.ToString() && 
                pb5.Tag.ToString() == EnSymbols.O.ToString() &&
                pb7.Tag.ToString() == EnSymbols.O.ToString())
            {
                HighlightWinningCells(pb3, pb5, pb7);
                lblWinner.Text = "Player2";
                MessageBox.Show("Player2 Is Winner", "Game Over");
                EndGame();
                return;
            }



            // Odds Draw Game
            if (pb1.Tag.ToString() != EnSymbols.Quistion.ToString() &&
               pb2.Tag.ToString() != EnSymbols.Quistion.ToString() &&
               pb3.Tag.ToString() != EnSymbols.Quistion.ToString() &&
               pb4.Tag.ToString() != EnSymbols.Quistion.ToString() &&
               pb5.Tag.ToString() != EnSymbols.Quistion.ToString() &&
               pb6.Tag.ToString() != EnSymbols.Quistion.ToString() &&
               pb7.Tag.ToString() != EnSymbols.Quistion.ToString() &&
               pb8.Tag.ToString() != EnSymbols.Quistion.ToString() &&
               pb9.Tag.ToString() != EnSymbols.Quistion.ToString())
            {
                lblWinner.Text = "Draw";
                MessageBox.Show("Nothing Winner", "Game Over");
                EndGame();
                return;

            }

        }
               

        
        private void Form_paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);
            //// poredr of Game

            //pen.Width = 5;
            //e.Graphics.DrawLine(pen, 250, 50, 550, 50);
            //e.Graphics.DrawLine(pen, 250, 50, 250, 350);
            //e.Graphics.DrawLine(pen, 550, 50, 550, 350);
            //e.Graphics.DrawLine(pen, 250, 350, 550, 350);

            pen.Width = 3;
            e.Graphics.DrawLine(pen, 250, 150, 550, 150);
            e.Graphics.DrawLine(pen, 250, 250, 550, 250);
            e.Graphics.DrawLine(pen, 350, 50, 350, 350);
            e.Graphics.DrawLine(pen, 450, 50, 450, 350);

        }

        private void pb1_Click(object sender, EventArgs e)
        {
            CheckEnter( pb1);
            CheckWinner();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            CheckEnter( pb2);
            CheckWinner();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            CheckEnter( pb3);
            CheckWinner();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            CheckEnter( pb4);
            CheckWinner();
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            CheckEnter( pb5);
            CheckWinner();
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            CheckEnter( pb6);
            CheckWinner();
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            CheckEnter( pb7);
            CheckWinner();
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            CheckEnter( pb8);
            CheckWinner();
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            CheckEnter (pb9);
            CheckWinner();
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            // restart game

            lblTurn.Text = "Player1";
            lblWinner.Text = "";

            // reset pb1
            pb1.Image = Resources.question_mark_96;
            pb1.Tag = Convert.ToString(EnSymbols.Quistion);

            // reset pb2
            pb2.Image = Resources.question_mark_96;
            pb2.Tag = Convert.ToString(EnSymbols.Quistion);

            // reset pb3
            pb3.Image = Resources.question_mark_96;
            pb3.Tag = Convert.ToString(EnSymbols.Quistion);

            // reset pb4
            pb4.Image = Resources.question_mark_96;
            pb4.Tag = Convert.ToString(EnSymbols.Quistion);

            // reset pb5
            pb5.Image = Resources.question_mark_96;
            pb5.Tag = Convert.ToString(EnSymbols.Quistion);

            // reset pb6
            pb6.Image = Resources.question_mark_96;
            pb6.Tag = Convert.ToString(EnSymbols.Quistion);


            // reset pb7
            pb7.Image = Resources.question_mark_96;
            pb7.Tag = Convert.ToString(EnSymbols.Quistion);

            // reset pb8
            pb8.Image = Resources.question_mark_96;
            pb8.Tag = Convert.ToString(EnSymbols.Quistion);

            // reset pb9
            pb9.Image = Resources.question_mark_96;
            pb9.Tag = Convert.ToString(EnSymbols.Quistion);


            // enbled pb
            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
            pb5.Enabled = true;
            pb6.Enabled = true;
            pb7.Enabled = true;
            pb8.Enabled = true;
            pb9.Enabled = true;


            pb1.BackColor = Color.Black;
            pb2.BackColor = Color.Black;
            pb3.BackColor = Color.Black;
            pb4.BackColor = Color.Black;
            pb5.BackColor = Color.Black;
            pb6.BackColor = Color.Black;
            pb7.BackColor = Color.Black;
            pb8.BackColor = Color.Black;
            pb9.BackColor = Color.Black;

        }


    }
}
