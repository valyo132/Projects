namespace Hangman
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using System.Collections.Generic;

    public partial class Form1 : Form
    {
        private string word;
        private int mistakes = 0;
        private string path;
        private List<string> mistakenGuesses = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        // useless property
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        private void GenerateWord_Click(object sender, EventArgs e)
        {
            if (wordType.Text == "All")
                path = "../../../GameType/Words.txt";
            else if (wordType.Text == "Animals")
                path = "../../../GameType/Animals.txt";
            else if (wordType.Text == "Sports")
                path = "../../../GameType/Sports.txt";

            int numberOfLines = File.ReadAllLines(path).Length;

            Random rnd = new Random();
            int wantedLine = rnd.Next(1, numberOfLines);

            word = GetWord(wantedLine, path);

            PrintWord(word);

            GenerateWord.Enabled = false;
            GuessButton.Enabled = true;
            guessLetter.Enabled = true;
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guessLetter.Text))
            {
                guessLetter.Text = null;
                return;
            }

            string guessString = guessLetter.Text;

            CheckGuess(guessString);
        }

        private void AddMistake(string guessString)
        {
            if (mistakenGuesses.Contains(guessString))
                return;

            mistakes++;

            if (mistakes == 1)
                mistakesText.Visible = true;

            mistakenLetters.Text += $"{guessString}" + " ";
            mistakenGuesses.Add(guessString);

            if (mistakes == 6)
            {
                MessageBox.Show($"You lost! The word was {word}");

                ResetGame();
            }
        }

        private void PrintWord(string word)
        {
            wordPlace1.Text = word[0].ToString();

            if (word.Length == 4)
            {
                wordPlace1.Visible = true;
                wordPlace2.Visible = true;
                wordPlace3.Visible = true;
                wordPlace4.Visible = true;

                wordPlace4.Text = word[word.Length - 1].ToString();
            }
            else if (word.Length == 5)
            {
                wordPlace1.Visible = true;
                wordPlace2.Visible = true;
                wordPlace3.Visible = true;
                wordPlace4.Visible = true;
                wordPlace5.Visible = true;

                wordPlace5.Text = word[word.Length - 1].ToString();
            }
            else if (word.Length == 6)
            {
                wordPlace1.Visible = true;
                wordPlace2.Visible = true;
                wordPlace3.Visible = true;
                wordPlace4.Visible = true;
                wordPlace5.Visible = true;
                wordPlace6.Visible = true;

                wordPlace6.Text = word[word.Length - 1].ToString();
            }
            else if (word.Length == 7)
            {
                wordPlace1.Visible = true;
                wordPlace2.Visible = true;
                wordPlace3.Visible = true;
                wordPlace4.Visible = true;
                wordPlace5.Visible = true;
                wordPlace6.Visible = true;
                wordPlace7.Visible = true;

                wordPlace7.Text = word[word.Length - 1].ToString();
            }
            else if (word.Length == 8)
            {
                wordPlace1.Visible = true;
                wordPlace2.Visible = true;
                wordPlace3.Visible = true;
                wordPlace4.Visible = true;
                wordPlace5.Visible = true;
                wordPlace6.Visible = true;
                wordPlace7.Visible = true;
                wordPlace8.Visible = true;

                wordPlace8.Text = word[word.Length - 1].ToString();
            }
            else if (word.Length == 9)
            {
                wordPlace1.Visible = true;
                wordPlace2.Visible = true;
                wordPlace3.Visible = true;
                wordPlace4.Visible = true;
                wordPlace5.Visible = true;
                wordPlace6.Visible = true;
                wordPlace7.Visible = true;
                wordPlace8.Visible = true;
                wordPlace9.Visible = true;

                wordPlace9.Text = word[word.Length - 1].ToString();
            }
            else if (word.Length == 10)
            {
                wordPlace1.Visible = true;
                wordPlace2.Visible = true;
                wordPlace3.Visible = true;
                wordPlace4.Visible = true;
                wordPlace5.Visible = true;
                wordPlace6.Visible = true;
                wordPlace7.Visible = true;
                wordPlace8.Visible = true;
                wordPlace9.Visible = true;
                wordPlace10.Visible = true;

                wordPlace10.Text = word[word.Length - 1].ToString();
            }
            else if (word.Length == 11)
            {
                wordPlace1.Visible = true;
                wordPlace2.Visible = true;
                wordPlace3.Visible = true;
                wordPlace4.Visible = true;
                wordPlace5.Visible = true;
                wordPlace6.Visible = true;
                wordPlace7.Visible = true;
                wordPlace8.Visible = true;
                wordPlace9.Visible = true;
                wordPlace10.Visible = true;
                wordPlace11.Visible = true;

                wordPlace11.Text = word[word.Length - 1].ToString();
            }

            CheckGuess(word[0].ToString());
            CheckGuess(word[word.Length - 1].ToString());
        }

        private void CheckGuess(string guessString)
        {
            if (guessString.Length > 1)
            {
                if (word == guessString)
                {
                    MessageBox.Show($"Congratulations you won!!!");

                    ResetGame();
                }
                else
                {
                    AddMistake(guessString);
                }
            }
            else if (word.Contains(guessString))
            {
                int wordPlaceCount = 0;
                string currentWordString = null;

                for (int i = 0; i < word.Length; i++)
                {
                    wordPlaceCount++;

                    if (word[i].ToString() == guessString)
                    {
                        if (wordPlaceCount == 2)
                            wordPlace2.Text = word[i].ToString();
                        else if (wordPlaceCount == 3)
                            wordPlace3.Text = word[i].ToString();
                        else if (wordPlaceCount == 4)
                            wordPlace4.Text = word[i].ToString();
                        else if (wordPlaceCount == 5)
                            wordPlace5.Text = word[i].ToString();
                        else if (wordPlaceCount == 6)
                            wordPlace6.Text = word[i].ToString();
                        else if (wordPlaceCount == 7)
                            wordPlace7.Text = word[i].ToString();
                        else if (wordPlaceCount == 8)
                            wordPlace8.Text = word[i].ToString();
                        else if (wordPlaceCount == 9)
                            wordPlace9.Text = word[i].ToString();
                        else if (wordPlaceCount == 10)
                            wordPlace10.Text = word[i].ToString();
                    }
                }

                currentWordString += wordPlace1.Text + wordPlace2.Text + wordPlace3.Text + wordPlace4.Text + wordPlace5.Text + wordPlace6.Text + wordPlace7.Text + wordPlace8.Text + wordPlace9.Text + wordPlace10.Text + wordPlace11.Text;

                if (currentWordString == word)
                {
                    MessageBox.Show($"Congratulations you won!!!");

                    ResetGame();
                }
            }
            else
            {
                AddMistake(guessString);
            }

            guessLetter.Text = null;
        }

        private static string GetWord(int wantedLine, string path)
        {
            string line = null;

            using (StreamReader reader = new StreamReader(path))
            {
                for (int i = 1; i <= wantedLine; i++)
                {
                    line = reader.ReadLine();
                }
            };

            return line;
        }

        private void ResetGame()
        {
            mistakes = 0;
            mistakenLetters.Text = null;
            mistakesText.Visible = false;

            wordPlace1.Text = null;
            wordPlace2.Text = null;
            wordPlace3.Text = null;
            wordPlace4.Text = null;
            wordPlace5.Text = null;
            wordPlace6.Text = null;
            wordPlace7.Text = null;
            wordPlace8.Text = null;
            wordPlace9.Text = null;
            wordPlace10.Text = null;
            wordPlace11.Text = null;

            wordPlace1.Visible = false;
            wordPlace2.Visible = false;
            wordPlace3.Visible = false;
            wordPlace4.Visible = false;
            wordPlace5.Visible = false;
            wordPlace6.Visible = false;
            wordPlace7.Visible = false;
            wordPlace8.Visible = false;
            wordPlace9.Visible = false;
            wordPlace10.Visible = false;
            wordPlace11.Visible = false;

            GenerateWord.Enabled = true;
            guessLetter.Enabled = false;
            GuessButton.Enabled = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
