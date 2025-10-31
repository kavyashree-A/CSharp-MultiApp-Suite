namespace UnitConverter
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCategory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.Location = new System.Drawing.Point(30, 30);
            this.lblInput.Size = new System.Drawing.Size(100, 23);
            this.lblInput.Text = "Enter Value:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(150, 30);
            this.txtInput.Size = new System.Drawing.Size(180, 23);
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(30, 70);
            this.lblCategory.Size = new System.Drawing.Size(100, 23);
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Location = new System.Drawing.Point(150, 70);
            this.cmbCategory.Size = new System.Drawing.Size(180, 23);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbFrom
            // 
            this.cmbFrom.Location = new System.Drawing.Point(30, 110);
            this.cmbFrom.Size = new System.Drawing.Size(140, 23);
            this.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // cmbTo
            // 
            this.cmbTo.Location = new System.Drawing.Point(190, 110);
            this.cmbTo.Size = new System.Drawing.Size(140, 23);
            this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(120, 150);
            this.btnConvert.Size = new System.Drawing.Size(120, 35);
            this.btnConvert.Text = "Convert";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(30, 200);
            this.lblResult.Size = new System.Drawing.Size(300, 40);
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(370, 270);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblResult);
            this.Text = "Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
