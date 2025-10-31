using System;
using System.Windows.Forms;

namespace Guessnumber
{
    public partial class Form1 : Form
    {
        private int secretNumber;
        private int attempts;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }
        private void StartNewGame()
        {
            secretNumber = random.Next(1, 101); // 1 to 100
            attempts = 0;
            lblResult.Text = "";
            lblAttempts.Text = "Attempts: 0";
            txtGuess.Text = "";
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGuess.Text, out int userGuess))
            {
                attempts++;
                lblAttempts.Text = $"Attempts: {attempts}";

                if (userGuess < 1 || userGuess > 100)
                {
                    lblResult.Text = "Please enter a number between 1 and 100!";
                }
                else if (userGuess < secretNumber)
                {
                    lblResult.Text = "Too Low! Try again.";
                }
                else if (userGuess > secretNumber)
                {
                    lblResult.Text = "Too High! Try again.";
                }
                else
                {
                    lblResult.Text = $"🎉 Correct! You guessed it in {attempts} tries.";
                }
            }
            else
            {
                lblResult.Text = "⚠️ Please enter a valid number.";
            }

            txtGuess.SelectAll();
            txtGuess.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
