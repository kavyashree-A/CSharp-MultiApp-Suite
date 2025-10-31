using System;
using System.Windows.Forms;

namespace DigitalClockStopwatch
{
    public partial class MainForm : Form
    {
        private TimeSpan stopwatchTime = TimeSpan.Zero;

        public MainForm()
        {
            InitializeComponent();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerStopwatch.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerStopwatch.Stop();
        }

        private void timerStopwatch_Tick(object sender, EventArgs e)
        {
            stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1));
            lblStopwatch.Text = stopwatchTime.ToString(@"hh\:mm\:ss");
        }
    }
}
