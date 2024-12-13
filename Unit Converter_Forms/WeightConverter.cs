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
            InitializeToolStripMenu();
        }

        private void WeightConverter_Load(object sender, EventArgs e)
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
                    "Volume",
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
                case "Temperature":
                    unitForm = new TemperatureConverter();
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
