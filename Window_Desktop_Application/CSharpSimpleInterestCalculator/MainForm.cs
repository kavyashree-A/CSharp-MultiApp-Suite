using System;
using System.Windows.Forms;

namespace CSharpSimpleInterestCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!decimal.TryParse(txtPrincipal.Text.Trim(), out decimal principal) || principal < 0)
            {
                MessageBox.Show("Please enter a valid non-negative principal amount.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrincipal.Focus();
                return;
            }

            if (!decimal.TryParse(txtRate.Text.Trim(), out decimal rate) || rate < 0)
            {
                MessageBox.Show("Please enter a valid non-negative annual rate (percentage).", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRate.Focus();
                return;
            }

            if (!decimal.TryParse(txtTime.Text.Trim(), out decimal time) || time < 0)
            {
                MessageBox.Show("Please enter a valid non-negative time (years).", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTime.Focus();
                return;
            }

            // Simple Interest = (P * R * T) / 100
            decimal simpleInterest = (principal * rate * time) / 100m;
            decimal amount = principal + simpleInterest;

            lblResult.Text = $"Simple Interest: {simpleInterest:F2}   |   Amount: {amount:F2}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "";
            txtRate.Text = "";
            txtTime.Text = "";
            lblResult.Text = "Simple Interest: -   |   Amount: -";
        }
    }
}
