using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharpStudentGradeCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var marks = txtMarks.Text.Split(',').Select(m => double.Parse(m.Trim())).ToList();

                double total = marks.Sum();
                double average = marks.Average();
                string grade = GetGrade(average);

                lblTotal.Text = $"Total: {total}";
                lblAverage.Text = $"Average: {average:F2}";
                lblGrade.Text = $"Grade: {grade}";
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric marks separated by commas.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetGrade(double avg)
        {
            if (avg >= 90) return "A+";
            if (avg >= 80) return "A";
            if (avg >= 70) return "B";
            if (avg >= 60) return "C";
            if (avg >= 50) return "D";
            return "F";
        }
    }
}
