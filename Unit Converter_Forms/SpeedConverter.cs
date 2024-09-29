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
    public partial class SpeedConverter : Form
    {
        public SpeedConverter()
        {
            InitializeComponent();
        }

        private void SpeedConverter_Load(object sender, EventArgs e)
        {
            FromUnit_cmb.SelectedIndex = 0;
            ToUnit_cmb.SelectedIndex = 1;
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
            double valueInMetersPerSecond = value;

            // Convert input value to meters per second (m/s)
            if (fromUnit == "KilometersPerHour")
            {
                valueInMetersPerSecond = value * 1000 / 3600; // 1 km/h = 1000 meters / 3600 seconds
            }
            else if (fromUnit == "MilesPerHour")
            {
                valueInMetersPerSecond = value * 1609.344 / 3600; // 1 mph = 1609.344 meters / 3600 seconds
            }
            else if (fromUnit == "FeetPerSecond")
            {
                valueInMetersPerSecond = value * 0.3048; // 1 ft/s = 0.3048 meters per second
            }
            else if (fromUnit == "Knots")
            {
                valueInMetersPerSecond = value * 1852 / 3600; // 1 knot = 1852 meters / 3600 seconds
            }
            else if (fromUnit == "MetersPerSecond")
            {
                valueInMetersPerSecond = value;
            }

            // Convert meters per second (m/s) to the target unit
            if (toUnit == "KilometersPerHour")
            {
                return valueInMetersPerSecond * 3600 / 1000; // Convert m/s to km/h
            }
            else if (toUnit == "MilesPerHour")
            {
                return valueInMetersPerSecond * 3600 / 1609.344; // Convert m/s to mph
            }
            else if (toUnit == "FeetPerSecond")
            {
                return valueInMetersPerSecond / 0.3048; // Convert m/s to ft/s
            }
            else if (toUnit == "Knots")
            {
                return valueInMetersPerSecond * 3600 / 1852; // Convert m/s to knots
            }
            else if (toUnit == "MetersPerSecond")
            {
                return valueInMetersPerSecond;
            }

            return valueInMetersPerSecond; // Default is meters per second
        }

    }
}
