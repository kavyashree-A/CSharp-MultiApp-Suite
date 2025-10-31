using System;
using System.Text;
using System.Windows.Forms;

namespace PasswordGeneratorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbStrength.SelectedIndex = 2; // Strong by default
            numLength.Value = 12;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length = (int)numLength.Value;
            int strength = cmbStrength.SelectedIndex + 1;
            txtPassword.Text = GeneratePassword(length, strength);
        }

        private string GeneratePassword(int length, int strength)
        {
            const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string symbols = "!@#$%^&*()-_=+[{]};:<>|./?";

            string charsToUse = letters;
            if (strength >= 2) charsToUse += numbers;
            if (strength >= 3) charsToUse += symbols;

            StringBuilder password = new StringBuilder();
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];

            for (int i = 0; i < length; i++)
            {
                rng.GetBytes(buffer);
                uint num = BitConverter.ToUInt32(buffer, 0);
                password.Append(charsToUse[(int)(num % (uint)charsToUse.Length)]);
            }

            return password.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPassword.Text);
                MessageBox.Show("Password copied to clipboard ✅", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please generate a password first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }
    }
}
