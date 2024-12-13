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
    public partial class VolumeConverter : Form
    {
        public VolumeConverter()
        {
            InitializeComponent();
            InitializeToolStripMenu();
        }

        private void VolumeConverter_Load(object sender, EventArgs e)
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
            double valueInCubicMeters = value;

            // Convert input value to cubic meters
            if (fromUnit == "Cubic Kilometer")
            {
                valueInCubicMeters = value * 1e12;
            }
            else if (fromUnit == "Cubic Centimeter")
            {
                valueInCubicMeters = value * 1e-6;
            }
            else if (fromUnit == "Cubic Millimeter")
            {
                valueInCubicMeters = value * 1e-9;
            }
            else if (fromUnit == "Liter")
            {
                valueInCubicMeters = value * 0.001;
            }
            else if (fromUnit == "Milliliter")
            {
                valueInCubicMeters = value * 1e-6;
            }
            else if (fromUnit == "US Gallon")
            {
                valueInCubicMeters = value * 0.00378541;
            }
            else if (fromUnit == "US Quart")
            {
                valueInCubicMeters = value * 0.000946353;
            }
            else if (fromUnit == "US Pint")
            {
                valueInCubicMeters = value * 0.000473176;
            }
            else if (fromUnit == "US Cup")
            {
                valueInCubicMeters = value * 0.000236588;
            }
            else if (fromUnit == "US Fluid Ounce")
            {
                valueInCubicMeters = value * 0.0000295735;
            }
            else if (fromUnit == "US Table Spoon")
            {
                valueInCubicMeters = value * 0.0000147868;
            }
            else if (fromUnit == "US Tea Spoon")
            {
                valueInCubicMeters = value * 0.00000492892;
            }
            else if (fromUnit == "Imperial Gallon")
            {
                valueInCubicMeters = value * 0.00454609;
            }
            else if (fromUnit == "Imperial Quart")
            {
                valueInCubicMeters = value * 0.00113652;
            }
            else if (fromUnit == "Imperial Pint")
            {
                valueInCubicMeters = value * 0.000568261;
            }
            else if (fromUnit == "Imperial Fluid Ounce")
            {
                valueInCubicMeters = value * 0.0000284131;
            }
            else if (fromUnit == "Imperial Table Spoon")
            {
                valueInCubicMeters = value * 0.0000177582;
            }
            else if (fromUnit == "Imperial Tea Spoon")
            {
                valueInCubicMeters = value * 0.00000591941;
            }
            else if (fromUnit == "Cubic Mile")
            {
                valueInCubicMeters = value * 4.16818e9;
            }
            else if (fromUnit == "Cubic Yard")
            {
                valueInCubicMeters = value * 0.764555;
            }
            else if (fromUnit == "Cubic Foot")
            {
                valueInCubicMeters = value * 0.0283168;
            }
            else if (fromUnit == "Cubic Inch")
            {
                valueInCubicMeters = value * 1.63871e-5;
            }
            else if (fromUnit == "Cubic Meter")
            {
                valueInCubicMeters = value;
            }

            // Convert cubic meters to the target unit
            if (toUnit == "Cubic Kilometer")
            {
                return valueInCubicMeters * 1e-15;
            }
            else if (toUnit == "Cubic Centimeter")
            {
                return valueInCubicMeters * 1e6;
            }
            else if (toUnit == "Cubic Millimeter")
            {
                return valueInCubicMeters * 1e9;
            }
            else if (toUnit == "Liter")
            {
                return valueInCubicMeters * 1000;
            }
            else if (toUnit == "Milliliter")
            {
                return valueInCubicMeters * 1e6;
            }
            else if (toUnit == "US Gallon")
            {
                return valueInCubicMeters * 264.172052;
            }
            else if (toUnit == "US Quart")
            {
                return valueInCubicMeters * 1056.68821;
            }
            else if (toUnit == "US Pint")
            {
                return valueInCubicMeters * 2113.37642;
            }
            else if (toUnit == "US Cup")
            {
                return valueInCubicMeters * 4226.75284;
            }
            else if (toUnit == "US Fluid Ounce")
            {
                return valueInCubicMeters * 33814.0226;
            }
            else if (toUnit == "US Table Spoon")
            {
                return valueInCubicMeters * 67628.0452;
            }
            else if (toUnit == "US Tea Spoon")
            {
                return valueInCubicMeters * 202884.136;
            }
            else if (toUnit == "Imperial Gallon")
            {
                return valueInCubicMeters * 219.969;
            }
            else if (toUnit == "Imperial Quart")
            {
                return valueInCubicMeters * 879.876;
            }
            else if (toUnit == "Imperial Pint")
            {
                return valueInCubicMeters * 1759.752;
            }
            else if (toUnit == "Imperial Fluid Ounce")
            {
                return valueInCubicMeters * 35195.03;
            }
            else if (toUnit == "Imperial Table Spoon")
            {
                return valueInCubicMeters * 70390.06;
            }
            else if (toUnit == "Imperial Tea Spoon")
            {
                return valueInCubicMeters * 211170.18;
            }
            else if (toUnit == "Cubic Mile")
            {
                return valueInCubicMeters * 6.75941e-10;
            }
            else if (toUnit == "Cubic Yard")
            {
                return valueInCubicMeters * 1.30795;
            }
            else if (toUnit == "Cubic Foot")
            {
                return valueInCubicMeters * 35.3147;
            }
            else if (toUnit == "Cubic Inch")
            {
                return valueInCubicMeters * 61023.7;
            }
            else if (toUnit == "Cubic Meter")
            {
                return valueInCubicMeters;
            }

            return valueInCubicMeters; // Default case if no match
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
                    "Temperature",
                    "Speed",
                    "Time"
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
                case "Temperature":
                    unitForm = new TemperatureConverter();
                    break;
                case "Speed":
                    unitForm = new SpeedConverter();
                    break;
                case "Length/Distance":
                    unitForm = new LengthConverter();
                    break;
                case "Time":
                    unitForm = new TimeConverter();
                    break;
                default:
                    MessageBox.Show("Invalid selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            unitForm?.Show();
        }
    }
}
