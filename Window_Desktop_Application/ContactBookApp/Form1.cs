using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ContactBookApp
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contacts.txt");

        public Form1()
        {
            InitializeComponent();
            LoadContacts();
            lblStatus.Text = "Ready";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Basic required fields
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                lblStatus.Text = "⚠️ Name and phone are required!";
                return;
            }

            // ✅ Phone validation: must be exactly 10 digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^[0-9]{10}$"))
            {
                lblStatus.Text = "📞 Please enter a valid 10-digit phone number.";
                return;
            }

            // ✅ Email validation: must contain @ and a valid domain, ends with .com, .in, etc.
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[a-z]{2,3}$", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                lblStatus.Text = "📧 Please enter a valid email address (e.g., name@example.com).";
                return;
            }

            contacts.Add(new Contact(name, phone, email));
            UpdateList();
            lblStatus.Text = "✅ Contact added!";
            ClearInputs();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex >= 0)
            {
                contacts.RemoveAt(lstContacts.SelectedIndex);
                UpdateList();
                lblStatus.Text = "🗑️ Contact deleted.";
            }
            else
            {
                lblStatus.Text = "⚠️ Please select a contact to delete.";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveContacts();
            lblStatus.Text = "💾 Contacts saved!";
        }

        private void lstContacts_DoubleClick(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex >= 0)
            {
                var c = contacts[lstContacts.SelectedIndex];
                txtName.Text = c.Name;
                txtPhone.Text = c.Phone;
                txtEmail.Text = c.Email;
                lblStatus.Text = "✏️ Editing contact — press Add to save as new entry or edit fields then Save to persist.";
            }
        }

        private void UpdateList()
        {
            lstContacts.Items.Clear();
            foreach (var c in contacts)
                lstContacts.Items.Add(c.ToString());
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void LoadContacts()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                contacts = lines.Select(line =>
                {
                    var parts = line.Split('|');
                    return new Contact(parts[0], parts.Length > 1 ? parts[1] : "", parts.Length > 2 ? parts[2] : "");
                }).ToList();
                UpdateList();
            }
        }

        private void SaveContacts()
        {
            File.WriteAllLines(filePath, contacts.Select(c => $"{c.Name}|{c.Phone}|{c.Email}"));
        }
    }
}
