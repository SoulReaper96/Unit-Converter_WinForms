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
            InitializeToolStripMenu();
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
                // Ensure SelectedItem is not null before calling ToString()
                string? fromUnit = FromUnit_cmb.SelectedItem?.ToString();
                string? toUnit = ToUnit_cmb.SelectedItem?.ToString();

                if (fromUnit != null && toUnit != null)
                {
                    double outputValue = ConvertUnits(inputValue, fromUnit, toUnit);
                    Output_tb.Text = outputValue.ToString();
                }
                else
                {
                    MessageBox.Show("Please select valid units.");
                }
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

        private void InitializeToolStripMenu()
        {
            // Assuming UnitsTool_cmbbox is already initialized in the designer
            UnitsTool_cmbbox.DropDownStyle = ComboBoxStyle.DropDownList; // Ensure it is non-editable

            // Add items to the ComboBox if not already added in the designer
            if (UnitsTool_cmbbox.Items.Count == 0)
            {
                UnitsTool_cmbbox.Items.AddRange(new string[]
                {
                    "Area",
                    "Length/Distance",
                    "Mass/Weight",
                    "Volume",
                    "Temperature",
                    "Speed",
                });
            }

            // Subscribe to SelectedIndexChanged event
            UnitsTool_cmbbox.SelectedIndexChanged += UnitSelected;
        }

        private void UnitSelected(object? sender, EventArgs e)
        {
            // Check if a valid item is selected
            if (UnitsTool_cmbbox.SelectedItem == null)
            {
                MessageBox.Show("No unit selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedUnit = UnitsTool_cmbbox.SelectedItem.ToString() ?? string.Empty;

            LaunchUnitForm(selectedUnit); // Launch the selected unit form
            this.Hide(); // Hide the current form
        }

        private void LaunchUnitForm(string selectedUnit)
        {
            Form? unitForm = null;

            switch (selectedUnit)
            {
                case "Area":
                    unitForm = new AreaConverter();
                    break;
                case "Mass/Weight":
                    unitForm = new WeightConverter();
                    break;
                case "Volume":
                    unitForm = new VolumeConverter();
                    break;
                case "Speed":
                    unitForm = new SpeedConverter();
                    break;
                case "Length/Distance":
                    unitForm = new LengthConverter();
                    break;
                case "Temperature":
                    unitForm = new TemperatureConverter();
                    break;
                default:
                    MessageBox.Show("Invalid selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            unitForm?.Show();
        }
    }
}
