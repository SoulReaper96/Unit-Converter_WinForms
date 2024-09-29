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
    public partial class TimeConverter : Form
    {
        public TimeConverter()
        {
            InitializeComponent();
        }

        private void TimeConverter_Load(object sender, EventArgs e)
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
            double valueInSeconds = value;

            // Convert input value to seconds
            if (fromUnit == "Minutes")
            {
                valueInSeconds = value * 60;
            }
            else if (fromUnit == "Hours")
            {
                valueInSeconds = value * 3600;
            }
            else if (fromUnit == "Days")
            {
                valueInSeconds = value * 86400;
            }
            else if (fromUnit == "Weeks")
            {
                valueInSeconds = value * 604800; // 7 days
            }
            else if (fromUnit == "Months")
            {
                valueInSeconds = value * 2629746; // Approx. 30.44 days
            }
            else if (fromUnit == "Years")
            {
                valueInSeconds = value * 31557600; // 365.25 days
            }
            else if (fromUnit == "Decades")
            {
                valueInSeconds = value * 315576000; // 10 years
            }
            else if (fromUnit == "Centuries")
            {
                valueInSeconds = value * 3155760000; // 100 years
            }
            else if (fromUnit == "Millennia")
            {
                valueInSeconds = value * 31557600000; // 1000 years
            }
            else if (fromUnit == "Seconds")
            {
                valueInSeconds = value;
            }

            // Convert seconds to the target unit
            if (toUnit == "Minutes")
            {
                return valueInSeconds / 60;
            }
            else if (toUnit == "Hours")
            {
                return valueInSeconds / 3600;
            }
            else if (toUnit == "Days")
            {
                return valueInSeconds / 86400;
            }
            else if (toUnit == "Weeks")
            {
                return valueInSeconds / 604800; // 7 days
            }
            else if (toUnit == "Months")
            {
                return valueInSeconds / 2629746; // Approx. 30.44 days
            }
            else if (toUnit == "Years")
            {
                return valueInSeconds / 31557600; // 365.25 days
            }
            else if (toUnit == "Decades")
            {
                return valueInSeconds / 315576000; // 10 years
            }
            else if (toUnit == "Centuries")
            {
                return valueInSeconds / 3155760000; // 100 years
            }
            else if (toUnit == "Millennia")
            {
                return valueInSeconds / 31557600000; // 1000 years
            }
            else if (toUnit == "Seconds")
            {
                return valueInSeconds;
            }

            return valueInSeconds; // Default is Seconds
        }


    }
}
