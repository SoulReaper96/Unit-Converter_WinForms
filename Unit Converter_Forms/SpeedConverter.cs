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
            InitializeToolStripMenu();
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
                    "Time"
                });
            }

            // Subscribe to SelectedIndexChanged event
            UnitsTool_cmbbox.SelectedIndexChanged += UnitSelected;
        }

        private void UnitSelected(object sender, EventArgs e)
        {
            // Check if a valid item is selected
            if (UnitsTool_cmbbox.SelectedItem == null)
            {
                MessageBox.Show("No unit selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedUnit = UnitsTool_cmbbox.SelectedItem.ToString();

            LaunchUnitForm(selectedUnit); // Launch the selected unit form
            this.Hide(); // Hide the current form
        }

        private void LaunchUnitForm(string selectedUnit)
        {
            Form unitForm = null;

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
                case "Temperature":
                    unitForm = new TemperatureConverter();
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

            // Check if the form was successfully created before showing it
            if (unitForm != null)
            {
                unitForm.Show();
            }
        }

    }
}
