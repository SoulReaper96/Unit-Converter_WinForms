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
    public partial class AreaConverter : Form
    {
        public AreaConverter()
        {
            InitializeComponent();
        }

        private void AreaConverter_Load(object sender, EventArgs e)
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
            double valueInSquareMeters = value;
            // Convert input value to square meters
            if (fromUnit == "Square Kilometer")
            {
                valueInSquareMeters = value * 1_000_000_000;
            }
            else if (fromUnit == "Square Mile")
            {
                valueInSquareMeters = value * 2_589_988_110.336;
            }
            else if (fromUnit == "Square Yard")
            {
                valueInSquareMeters = value * 0.83612736;
            }
            else if (fromUnit == "Square Foot")
            {
                valueInSquareMeters = value * 0.09290304;
            }
            else if (fromUnit == "Square Inch")
            {
                valueInSquareMeters = value * 0.00064516;
            }
            else if (fromUnit == "Hectare")
            {
                valueInSquareMeters = value * 10_000;
            }
            else if (fromUnit == "Acre")
            {
                valueInSquareMeters = value * 4_046.8564224;
            }
            else if (fromUnit == "Square Centimeter")
            {
                valueInSquareMeters = value * 0.0001;
            }
            else if (fromUnit == "Square Millimeter")
            {
                valueInSquareMeters = value * 0.000001;
            }
            else if (fromUnit == "Square Micrometer")
            {
                valueInSquareMeters = value * 1e-12;
            }
            else if (fromUnit == "Square Meter")
            {
                valueInSquareMeters = value;
            }

            // Convert square meters to the target unit
            if (toUnit == "Square Kilometer")
            {
                return valueInSquareMeters / 1_000_000_000;
            }
            else if (toUnit == "Square Mile")
            {
                return valueInSquareMeters / 2_589_988_110.336;
            }
            else if (toUnit == "Square Yard")
            {
                return valueInSquareMeters / 0.83612736;
            }
            else if (toUnit == "Square Foot")
            {
                return valueInSquareMeters / 0.09290304;
            }
            else if (toUnit == "Square Inch")
            {
                return valueInSquareMeters / 0.00064516;
            }
            else if (toUnit == "Hectare")
            {
                return valueInSquareMeters / 10_000;
            }
            else if (toUnit == "Acre")
            {
                return valueInSquareMeters / 4_046.8564224;
            }
            else if (toUnit == "Square Centimeter")
            {
                return valueInSquareMeters / 0.0001;
            }
            else if (toUnit == "Square Millimeter")
            {
                return valueInSquareMeters / 0.000001;
            }
            else if (toUnit == "Square Micrometer")
            {
                return valueInSquareMeters / 1e-12;
            }
            else if (toUnit == "Square Meter")
            {
                return valueInSquareMeters;
            }

            return valueInSquareMeters; // Default is square meters
        }
    }
}
