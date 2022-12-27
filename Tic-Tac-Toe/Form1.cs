using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isPlayerOneTurn = true;
        bool isThereAWinner = false;
        int playerOneScore = 0;
        int playerTwoScore = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (isPlayerOneTurn)
            {
                button1.Text = "X";
                label2.Text = "Player 2:";
                isPlayerOneTurn = false;
            }
            else
            {
                button1.Text = "O";
                label2.Text = "Player 1:";
                isPlayerOneTurn = true;
            }
            
            button1.Enabled = false;
            CheckForGameOver();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isPlayerOneTurn)
            {
                button2.Text = "X";
                label2.Text = "Player 2:";
                isPlayerOneTurn = false;
            }
            else
            {
                button2.Text = "O";
                label2.Text = "Player 1:";
                isPlayerOneTurn = true;
            }

            button2.Enabled = false;
            CheckForGameOver();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isPlayerOneTurn)
            {
                button3.Text = "X";
                label2.Text = "Player 2:";
                isPlayerOneTurn = false;
            }
            else
            {
                button3.Text = "O";
                label2.Text = "Player 1:";
                isPlayerOneTurn = true;
            }

            button3.Enabled = false;
            CheckForGameOver();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isPlayerOneTurn)
            {
                button4.Text = "X";
                label2.Text = "Player 2:";
                isPlayerOneTurn = false;
            }
            else
            {
                button4.Text = "O";
                label2.Text = "Player 1:";
                isPlayerOneTurn = true;
            }

            button4.Enabled = false;
            CheckForGameOver();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isPlayerOneTurn)
            {
                button5.Text = "X";
                label2.Text = "Player 2:";
                isPlayerOneTurn = false;
            }
            else
            {
                button5.Text = "O";
                label2.Text = "Player 1:";
                isPlayerOneTurn = true;
            }

            button5.Enabled = false;
            CheckForGameOver();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isPlayerOneTurn)
            {
                button6.Text = "X";
                label2.Text = "Player 2:";
                isPlayerOneTurn = false;
            }
            else
            {
                button6.Text = "O";
                label2.Text = "Player 1:";
                isPlayerOneTurn = true;
            }

            button6.Enabled = false;
            CheckForGameOver();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isPlayerOneTurn)
            {
                button7.Text = "X";
                label2.Text = "Player 2:";
                isPlayerOneTurn = false;
            }
            else
            {
                button7.Text = "O";
                label2.Text = "Player 1:";
                isPlayerOneTurn = true;
            }

            button7.Enabled = false;
            CheckForGameOver();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isPlayerOneTurn)
            {
                button8.Text = "X";
                label2.Text = "Player 2:";
                isPlayerOneTurn = false;
            }
            else
            {
                button8.Text = "O";
                label2.Text = "Player 1:";
                isPlayerOneTurn = true;
            }

            button8.Enabled = false;
            CheckForGameOver();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isPlayerOneTurn)
            {
                button9.Text = "X";
                label2.Text = "Player 2:";
                isPlayerOneTurn = false;
            }
            else
            {
                button9.Text = "O";
                label2.Text = "Player 1:";
                isPlayerOneTurn = true;
            }

            button9.Enabled = false;
            CheckForGameOver();
        }

        private void CheckForGameOver()
        {

            //Check first row
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" && !isThereAWinner)
            {
                button1.BackColor = Color.DarkGreen;
                button2.BackColor = Color.DarkGreen;
                button3.BackColor = Color.DarkGreen;
                playerOneScore++;
                label7.Text = playerOneScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 1";
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" && !isThereAWinner)
            {
                button1.BackColor = Color.DarkGreen;
                button2.BackColor = Color.DarkGreen;
                button3.BackColor = Color.DarkGreen;
                playerTwoScore++;
                label8.Text = playerTwoScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 2";
            }

            //Check second row
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X" && !isThereAWinner)
            {
                button4.BackColor = Color.DarkGreen;
                button5.BackColor = Color.DarkGreen;
                button6.BackColor = Color.DarkGreen;
                playerOneScore++;
                label7.Text = playerOneScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 1";
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O" && !isThereAWinner)
            {
                button4.BackColor = Color.DarkGreen;
                button5.BackColor = Color.DarkGreen;
                button6.BackColor = Color.DarkGreen;
                playerTwoScore++;
                label8.Text = playerTwoScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 2";
            }

            //Check third row
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X" && !isThereAWinner)
            {
                button7.BackColor = Color.DarkGreen;
                button8.BackColor = Color.DarkGreen;
                button9.BackColor = Color.DarkGreen;
                playerTwoScore++;
                label8.Text = playerTwoScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 1";
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O" && !isThereAWinner)
            {
                button7.BackColor = Color.DarkGreen;
                button8.BackColor = Color.DarkGreen;
                button9.BackColor = Color.DarkGreen;
                playerTwoScore++;
                label8.Text = playerTwoScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 2";
            }

            //Check first column
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X" && !isThereAWinner)
            {
                button1.BackColor = Color.DarkGreen;
                button4.BackColor = Color.DarkGreen;
                button7.BackColor = Color.DarkGreen;
                playerOneScore++;
                label7.Text = playerOneScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 1";
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O" && !isThereAWinner)
            {
                button1.BackColor = Color.DarkGreen;
                button4.BackColor = Color.DarkGreen;
                button7.BackColor = Color.DarkGreen;
                playerTwoScore++;
                label8.Text = playerTwoScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 2";
            }

            //Check second column
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X" && !isThereAWinner)
            {
                button2.BackColor = Color.DarkGreen;
                button5.BackColor = Color.DarkGreen;
                button8.BackColor = Color.DarkGreen;
                playerOneScore++;
                label7.Text = playerOneScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 1";
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O" && !isThereAWinner)
            {
                button2.BackColor = Color.DarkGreen;
                button5.BackColor = Color.DarkGreen;
                button8.BackColor = Color.DarkGreen;
                playerTwoScore++;
                label8.Text = playerTwoScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 2";
            }

            //Check third column
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X" && !isThereAWinner)
            {
                button3.BackColor = Color.DarkGreen;
                button6.BackColor = Color.DarkGreen;
                button9.BackColor = Color.DarkGreen;
                playerOneScore++;
                label7.Text = playerOneScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 1";
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O" && !isThereAWinner)
            {
                button3.BackColor = Color.DarkGreen;
                button6.BackColor = Color.DarkGreen;
                button9.BackColor = Color.DarkGreen;
                playerTwoScore++;
                label8.Text = playerTwoScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 2";
            }

            //Check first diagonal
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X" && !isThereAWinner)
            {
                button1.BackColor = Color.DarkGreen;
                button5.BackColor = Color.DarkGreen;
                button9.BackColor = Color.DarkGreen;
                playerOneScore++;
                label7.Text = playerOneScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 1";
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O" && !isThereAWinner)
            {
                button1.BackColor = Color.DarkGreen;
                button5.BackColor = Color.DarkGreen;
                button9.BackColor = Color.DarkGreen;
                playerTwoScore++;
                label8.Text = playerTwoScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 2";
            }

            //Check second diagonal
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X" && !isThereAWinner)
            {
                button3.BackColor = Color.DarkGreen;
                button5.BackColor = Color.DarkGreen;
                button7.BackColor = Color.DarkGreen;
                playerOneScore++;
                label7.Text = playerOneScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 1";
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O" && !isThereAWinner)
            {
                button3.BackColor = Color.DarkGreen;
                button5.BackColor = Color.DarkGreen;
                button7.BackColor = Color.DarkGreen;
                playerTwoScore++;
                label8.Text = playerTwoScore.ToString();
                isThereAWinner = true;
                label9.Text = "Winner - Player 2";
            }

            //Check if there is no winner
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" && !isThereAWinner)
            {
                isThereAWinner = true;
                label10.Visible = true;
            }

            if (isThereAWinner)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            label10.Visible = false;
            isThereAWinner = false;
            isPlayerOneTurn = true;
            label2.Text = "Player 1:";

            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;

            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
            button8.BackColor = Color.Gray;
            button9.BackColor = Color.Gray;
        }
    }
}
