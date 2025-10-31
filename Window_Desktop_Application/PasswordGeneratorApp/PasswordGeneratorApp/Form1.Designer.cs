namespace PasswordGeneratorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.ComboBox cmbStrength;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox chkShow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.lblStrength = new System.Windows.Forms.Label();
            this.cmbStrength = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.chkShow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(460, 220);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(14, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 21);
            this.lblTitle.Text = "🔐 Password Generator";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLength.Location = new System.Drawing.Point(16, 55);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(102, 15);
            this.lblLength.Text = "Password Length:";
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(140, 52);
            this.numLength.Minimum = 4;
            this.numLength.Maximum = 50;
            this.numLength.Value = 12;
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(70, 23);
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStrength.Location = new System.Drawing.Point(230, 55);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(89, 15);
            this.lblStrength.Text = "Select Strength:";
            // 
            // cmbStrength
            // 
            this.cmbStrength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStrength.FormattingEnabled = true;
            this.cmbStrength.Items.AddRange(new object[] {"Weak", "Medium", "Strong"});
            this.cmbStrength.Location = new System.Drawing.Point(325, 52);
            this.cmbStrength.Name = "cmbStrength";
            this.cmbStrength.Size = new System.Drawing.Size(120, 23);
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(19, 95);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(426, 36);
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnGenerate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(19, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(342, 23);
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.Location = new System.Drawing.Point(369, 142);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(76, 28);
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnCopy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkShow.Location = new System.Drawing.Point(19, 180);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(111, 19);
            this.chkShow.Text = "Show password";
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // Finalize
            // 
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.cmbStrength);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.chkShow);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
