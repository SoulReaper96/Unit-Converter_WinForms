using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Converter_Forms
{
    public partial class WeightConverter : Form
    {
        public WeightConverter()
        {
            InitializeComponent();
        }

        private void WeightConverter_Load(object sender, EventArgs e)
        {
            FromUnit_cmb.SelectedIndex = 0;
            ToUnit_cmb.SelectedIndex = 1;
        }

        private void TemperatureTool_btn_Click(object sender, EventArgs e)
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            temperatureConverter.Show();
            this.Hide();
        }

        private void AreaTool_btn_Click(object sender, EventArgs e)
        {
            AreaConverter areaConverter = new AreaConverter();
            areaConverter.Show();
            this.Hide();
        }

        private void VolumeTool_btn_Click(object sender, EventArgs e)
        {
            VolumeConverter volumeConverter = new VolumeConverter();
            volumeConverter.Show();
            this.Hide();
        }

        private void LengthTool_btn_Click(object sender, EventArgs e)
        {
            LengthConverter lengthConverter = new LengthConverter();
            lengthConverter.Show();
            this.Hide();
        }

        private void Convert_btn_Click(object sender, EventArgs e)
        {
            double inputValue;

            if (double.TryParse(Input_tb.Text, out inputValue))
            {
                double outputValue = ConvertUnits(inputValue, FromUnit_cmb.SelectedItem.ToString(), ToUnit_cmb.SelectedItem.ToString());
                Output_tb.Text = outputValue.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private double ConvertUnits(double value, string? fromUnit, string? toUnit)
        {
            double valueInKilograms = value;

            // Convert input value to kilograms
            if (fromUnit == "Gram")
            {
                valueInKilograms = value * 0.001;
            }
            else if (fromUnit == "Milligram")
            {
                valueInKilograms = value * 1e-6;
            }
            else if (fromUnit == "Metric Ton")
            {
                valueInKilograms = value * 1000;
            }
            else if (fromUnit == "Long Ton")
            {
                valueInKilograms = value * 1016.05;
            }
            else if (fromUnit == "Short Ton")
            {
                valueInKilograms = value * 907.185;
            }
            else if (fromUnit == "Pound")
            {
                valueInKilograms = value * 0.453592;
            }
            else if (fromUnit == "Ounce")
            {
                valueInKilograms = value * 0.0283495;
            }
            else if (fromUnit == "Carrat")
            {
                valueInKilograms = value * 0.0002;
            }
            else if (fromUnit == "Atomic Mass Unit")
            {
                valueInKilograms = value * 1.66054e-27;
            }
            else if (fromUnit == "Kilogram")
            {
                valueInKilograms = value;
            }

            // Convert kilograms to the target unit
            if (toUnit == "Gram")
            {
                return valueInKilograms * 1000;
            }
            else if (toUnit == "Milligram")
            {
                return valueInKilograms * 1e6;
            }
            else if (toUnit == "Metric Ton")
            {
                return valueInKilograms * 0.001;
            }
            else if (toUnit == "Long Ton")
            {
                return valueInKilograms * 0.000984207;
            }
            else if (toUnit == "Short Ton")
            {
                return valueInKilograms * 0.00110231;
            }
            else if (toUnit == "Pound")
            {
                return valueInKilograms * 2.20462;
            }
            else if (toUnit == "Ounce")
            {
                return valueInKilograms * 35.274;
            }
            else if (toUnit == "Carrat")
            {
                return valueInKilograms * 5000;
            }
            else if (toUnit == "Atomic Mass Unit")
            {
                return valueInKilograms * 6.022e26;
            }
            else if (toUnit == "Kilogram")
            {
                return valueInKilograms;
            }

            return valueInKilograms; // Default case if no match
        }
    }
}
