using System;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cmbCategory.Items.AddRange(new string[] { "Temperature", "Distance", "Weight" });
            cmbCategory.SelectedIndex = 0;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFrom.Items.Clear();
            cmbTo.Items.Clear();
            switch (cmbCategory.SelectedItem.ToString())
            {
                case "Temperature":
                    cmbFrom.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
                    cmbTo.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
                    break;
                case "Distance":
                    cmbFrom.Items.AddRange(new string[] { "Meter", "Kilometer", "Mile" });
                    cmbTo.Items.AddRange(new string[] { "Meter", "Kilometer", "Mile" });
                    break;
                case "Weight":
                    cmbFrom.Items.AddRange(new string[] { "Gram", "Kilogram", "Pound" });
                    cmbTo.Items.AddRange(new string[] { "Gram", "Kilogram", "Pound" });
                    break;
            }
            cmbFrom.SelectedIndex = 0;
            cmbTo.SelectedIndex = 1;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(txtInput.Text);
                string from = cmbFrom.SelectedItem.ToString();
                string to = cmbTo.SelectedItem.ToString();
                double result = 0;

                switch (cmbCategory.SelectedItem.ToString())
                {
                    case "Temperature":
                        result = ConvertTemperature(input, from, to);
                        break;
                    case "Distance":
                        result = ConvertDistance(input, from, to);
                        break;
                    case "Weight":
                        result = ConvertWeight(input, from, to);
                        break;
                }

                lblResult.Text = $"{input} {from} = {result:F2} {to}";
            }
            catch
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double ConvertTemperature(double value, string from, string to)
        {
            if (from == to) return value;
            if (from == "Celsius" && to == "Fahrenheit") return value * 9 / 5 + 32;
            if (from == "Fahrenheit" && to == "Celsius") return (value - 32) * 5 / 9;
            if (from == "Celsius" && to == "Kelvin") return value + 273.15;
            if (from == "Kelvin" && to == "Celsius") return value - 273.15;
            if (from == "Fahrenheit" && to == "Kelvin") return (value - 32) * 5 / 9 + 273.15;
            if (from == "Kelvin" && to == "Fahrenheit") return (value - 273.15) * 9 / 5 + 32;
            return value;
        }

        private double ConvertDistance(double value, string from, string to)
        {
            if (from == to) return value;
            double inMeters = from switch
            {
                "Meter" => value,
                "Kilometer" => value * 1000,
                "Mile" => value * 1609.34,
                _ => value
            };

            return to switch
            {
                "Meter" => inMeters,
                "Kilometer" => inMeters / 1000,
                "Mile" => inMeters / 1609.34,
                _ => inMeters
            };
        }

        private double ConvertWeight(double value, string from, string to)
        {
            if (from == to) return value;
            double inGrams = from switch
            {
                "Gram" => value,
                "Kilogram" => value * 1000,
                "Pound" => value * 453.592,
                _ => value
            };

            return to switch
            {
                "Gram" => inGrams,
                "Kilogram" => inGrams / 1000,
                "Pound" => inGrams / 453.592,
                _ => inGrams
            };
        }
    }
}
