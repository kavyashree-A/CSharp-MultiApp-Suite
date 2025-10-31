namespace DigitalClockStopwatch
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblStopwatch;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Timer timerStopwatch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblStopwatch = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerStopwatch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblClock.Location = new System.Drawing.Point(30, 20);
            this.lblClock.Size = new System.Drawing.Size(350, 50);
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStopwatch
            // 
            this.lblStopwatch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblStopwatch.Location = new System.Drawing.Point(30, 90);
            this.lblStopwatch.Size = new System.Drawing.Size(350, 50);
            this.lblStopwatch.Text = "00:00:00";
            this.lblStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(70, 160);
            this.btnStart.Size = new System.Drawing.Size(100, 40);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStop.Location = new System.Drawing.Point(220, 160);
            this.btnStop.Size = new System.Drawing.Size(100, 40);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // timerStopwatch
            // 
            this.timerStopwatch.Interval = 1000;
            this.timerStopwatch.Tick += new System.EventHandler(this.timerStopwatch_Tick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lblStopwatch);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Text = "Digital Clock & Stopwatch";
            this.ResumeLayout(false);
        }
    }
}
