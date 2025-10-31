using System;
using System.Windows.Forms;

namespace CSharpReminderApp
{
    public partial class MainForm : Form
    {
        private Timer reminderTimer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            reminderTimer.Interval = 1000; // 1 second
            reminderTimer.Tick += ReminderTimer_Tick;
        }

        private void btnSetReminder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Please enter a reminder message.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpTime.Value <= DateTime.Now)
            {
                MessageBox.Show("Please select a future time.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblStatus.Text = $"⏰ Reminder set for {dtpTime.Value.ToLongTimeString()}";
            reminderTimer.Start();
        }

        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= dtpTime.Value)
            {
                reminderTimer.Stop();
                MessageBox.Show(txtMessage.Text, "Reminder Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text = "✅ Reminder completed.";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            dtpTime.Value = DateTime.Now.AddMinutes(1);
            lblStatus.Text = "No reminder set.";
            reminderTimer.Stop();
        }
    }
}
