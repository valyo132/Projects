using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Tik_Tak_Toe
{
    public partial class Form1 : Form
    {
        private int buttonOneClicks = 0;
        private int buttonTwoClicks = 0;
        private int buttonThreeClicks = 0;
        private int buttonFourClicks = 0;
        private int buttonFiveClicks = 0;
        private int buttonSixClicks = 0;
        private int buttonSevenClicks = 0;
        private int buttonEightClicks = 0;
        private int buttonNineClicks = 0;

        private int turn = 1;

        private int playe1Score = 0;
        private int player2Score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonOneClicks == 0)
            {
                if (turn % 2 != 0)
                    button1.Text = "X";
                else
                    button1.Text = "O";

                turn++;
                buttonOneClicks++;
            }

            DisplayPlayerOnTurn();
            CheckForAWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonTwoClicks == 0)
            {
                if (turn % 2 != 0)
                    button2.Text = "X";
                else
                    button2.Text = "O";

                turn++;
                buttonTwoClicks++;
            }

            DisplayPlayerOnTurn();
            CheckForAWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (buttonThreeClicks == 0)
            {
                if (turn % 2 != 0)
                    button3.Text = "X";
                else
                    button3.Text = "O";

                turn++;
                buttonThreeClicks++;
            }

            DisplayPlayerOnTurn();
            CheckForAWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (buttonFourClicks == 0)
            {
                if (turn % 2 != 0)
                    button4.Text = "X";
                else
                    button4.Text = "O";

                turn++;
                buttonFourClicks++;
            }

            DisplayPlayerOnTurn();
            CheckForAWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (buttonFiveClicks == 0)
            {
                if (turn % 2 != 0)
                    button5.Text = "X";
                else
                    button5.Text = "O";

                turn++;
                buttonFiveClicks++;
            }

            DisplayPlayerOnTurn();
            CheckForAWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (buttonSixClicks == 0)
            {
                if (turn % 2 != 0)
                    button6.Text = "X";
                else
                    button6.Text = "O";

                turn++;
                buttonSixClicks++;
            }

            DisplayPlayerOnTurn();
            CheckForAWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (buttonSevenClicks == 0)
            {
                if (turn % 2 != 0)
                    button7.Text = "X";
                else
                    button7.Text = "O";

                turn++;
                buttonSevenClicks++;
            }

            DisplayPlayerOnTurn();
            CheckForAWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (buttonEightClicks == 0)
            {
                if (turn % 2 != 0)
                    button8.Text = "X";
                else
                    button8.Text = "O";

                turn++;
                buttonEightClicks++;
            }

            DisplayPlayerOnTurn();
            CheckForAWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (buttonNineClicks == 0)
            {
                if (turn % 2 != 0)
                    button9.Text = "X";
                else
                    button9.Text = "O";

                turn++;
                buttonNineClicks++;
            }

            DisplayPlayerOnTurn();
            CheckForAWinner();
        }

        // Start New Game
        private void button10_Click(object sender, EventArgs e)
        {
            playerOneScore.Text = "";
            playerTwoScore.Text = "";

            playe1Score = 0;
            player2Score = 0;

            ClearGame();
        }

        // End Game
        private void button11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        // Engine
        private void DisplayPlayerOnTurn()
        {
            if (turn % 2 == 0)
                displayturn.Text = "Player 2";
            else
                displayturn.Text = "Player 1";
        }

        private void CheckForAWinner()
        {
            bool winner = false;
            string symbol = "";

            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text == "X")
                    symbol = "X";
                else if (button1.Text == "O")
                    symbol = "O";

                if (symbol != "")
                    winner = true;
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text == "X")
                    symbol = "X";
                else if (button4.Text == "O")
                    symbol = "O";

                if (symbol != "")
                    winner = true;
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == "X")
                    symbol = "X";
                else if (button7.Text == "O")
                    symbol = "O";

                if (symbol != "")
                    winner = true;
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == "X")
                    symbol = "X";
                else if (button1.Text == "O")
                    symbol = "O";

                if (symbol != "")
                    winner = true;
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == "X")
                    symbol = "X";
                else if (button2.Text == "O")
                    symbol = "O";

                if (symbol != "")
                    winner = true;
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == "X")
                    symbol = "X";
                else if (button3.Text == "O")
                    symbol = "O";

                if (symbol != "")
                    winner = true;
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == "X")
                    symbol = "X";
                else if (button1.Text == "O")
                    symbol = "O";

                if (symbol != "")
                    winner = true;
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == "X")
                    symbol = "X";
                else if (button3.Text == "O")
                    symbol = "O";

                if (symbol != "")
                    winner = true;
            }

            if (winner)
            {
                DisplayWinner(symbol);
            }
            else
            {
                CheckForDraw();
            }
        }

        private void CheckForDraw()
        {
            if (buttonOneClicks == 1 && buttonTwoClicks == 1 && buttonThreeClicks == 1 && buttonFourClicks == 1 && buttonFiveClicks == 1 && buttonSixClicks == 1 && buttonSevenClicks == 1 && buttonEightClicks == 1 && buttonNineClicks == 1)
            {
                DisplayDraw();
            }
        }

        private void DisplayDraw()
        {
            MessageBox.Show("It's a Draw!");

            ClearGame();
        }

        private void DisplayWinner(string symbol)
        {
            bool clear = false;

            if (symbol == "X")
            {
                playe1Score++;
                clear = true;

                playerOneScore.Text = playe1Score.ToString();
                MessageBox.Show("Player 1 Wins!");
            }
            else if (symbol == "O")
            {
                player2Score++;
                clear = true;

                playerTwoScore.Text = (player2Score++).ToString();
                MessageBox.Show("Player 2 Wins!");
            }

            if (clear)
                ClearGame();
        }

        private void ClearGame()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            buttonOneClicks = 0;
            buttonTwoClicks = 0;
            buttonThreeClicks = 0;
            buttonFourClicks = 0;
            buttonFiveClicks = 0;
            buttonSixClicks = 0;
            buttonSevenClicks = 0;
            buttonEightClicks = 0;
            buttonNineClicks = 0;

            turn = 1;

            displayturn.Text = "";
        }
    }
}
