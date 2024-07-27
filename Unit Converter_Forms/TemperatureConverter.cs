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
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void TemperatureConverter_Load(object sender, EventArgs e)
        {
            FromUnit_cmb.SelectedIndex = 0;
            ToUnit_cmb.SelectedIndex = 1;
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

        private void WeightTool_btn_Click(object sender, EventArgs e)
        {
            WeightConverter weightConverter = new WeightConverter();
            weightConverter.Show();
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
            double valueInCelsius = value;

            // Convert input value to Celsius
            if (fromUnit == "Fahrenheit")
            {
                valueInCelsius = (value - 32) * 5 / 9;
            }
            else if (fromUnit == "Kelvin")
            {
                valueInCelsius = value - 273.15;
            }
            else if (fromUnit == "Celsius")
            {
                valueInCelsius = value;
            }

            // Convert Celsius to the target unit
            if (toUnit == "Fahrenheit")
            {
                return valueInCelsius * 9 / 5 + 32;
            }
            else if (toUnit == "Kelvin")
            {
                return valueInCelsius + 273.15;
            }
            else if (toUnit == "Celsius")
            {
                return valueInCelsius;
            }

            return valueInCelsius; // Default is Celsius
        }
    }
}
