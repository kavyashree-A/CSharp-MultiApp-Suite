using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool operationPerformed = false;
        public Form1()
        {
            InitializeComponent();
            CustomizeUI();
        }
        private void CustomizeUI()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            txtDisplay.BackColor = Color.FromArgb(44, 44, 44);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Segoe UI", 22, FontStyle.Bold);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.FromArgb(58, 58, 58);
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                }
            }
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || operationPerformed)
                txtDisplay.Clear();

            operationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text += button.Text;
            }
            else
                txtDisplay.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                btnEqual.PerformClick();
                operation = button.Text;
                operationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(txtDisplay.Text);
                operationPerformed = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            operation = "";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            if (txtDisplay.Text == "")
                txtDisplay.Text = "0";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "+": txtDisplay.Text = (result + double.Parse(txtDisplay.Text)).ToString(); break;
                    case "-": txtDisplay.Text = (result - double.Parse(txtDisplay.Text)).ToString(); break;
                    case "*": txtDisplay.Text = (result * double.Parse(txtDisplay.Text)).ToString(); break;
                    case "/":
                        double divisor = double.Parse(txtDisplay.Text);
                        txtDisplay.Text = divisor == 0 ? "Error" : (result / divisor).ToString();
                        break;
                }
                result = double.Parse(txtDisplay.Text);
                operation = "";
            }
            catch
            {
                txtDisplay.Text = "Error";
            }
        }

    }
}
