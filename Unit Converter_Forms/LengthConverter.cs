namespace Unit_Converter_Forms
{
    public partial class LengthConverter : Form
    {
        public LengthConverter()
        {
            InitializeComponent();
            InitializeToolStripMenu();
        }

        private void LengthConverter_Load(object sender, EventArgs e)
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

        private double ConvertUnits(double value, string fromUnit, string toUnit)
        {
            // Conversion logic here
            double valueInMeters = value;

            // Convert input value to meters
            if (fromUnit == "Kilometer")
            {
                valueInMeters = value * 1000;
            }
            else if (fromUnit == "Mile")
            {
                valueInMeters = value * 1609.34;
            }
            else if (fromUnit == "Foot")
            {
                valueInMeters = value * 0.3048;
            }
            else if (fromUnit == "Inch")
            {
                valueInMeters = value * 0.0254;
            }
            else if (fromUnit == "Centimeter")
            {
                valueInMeters = value * 0.01;
            }
            else if (fromUnit == "Millimeter")
            {
                valueInMeters = value * 0.001;
            }
            else if (fromUnit == "Micrometer")
            {
                valueInMeters = value * 0.000001;
            }
            else if (fromUnit == "Nanometer")
            {
                valueInMeters = value * 0.000000001;
            }
            else if (fromUnit == "Yard")
            {
                valueInMeters = value * 0.9144;
            }
            else if (fromUnit == "Light Year")
            {
                valueInMeters = value * 9.461e+15;
            }
            else if (fromUnit == "Meter")
            {
                valueInMeters = value;
            }

            // Convert meters to the target unit
            if (toUnit == "Kilometer")
            {
                return valueInMeters / 1000;
            }
            else if (toUnit == "Mile")
            {
                return valueInMeters / 1609.34;
            }
            else if (toUnit == "Foot")
            {
                return valueInMeters / 0.3048;
            }
            else if (toUnit == "Inch")
            {
                return valueInMeters / 0.0254;
            }
            else if (toUnit == "Centimeter")
            {
                return valueInMeters / 0.01;
            }
            else if (toUnit == "Millimeter")
            {
                return valueInMeters / 0.001;
            }
            else if (toUnit == "Micrometer")
            {
                return valueInMeters / 0.000001;
            }
            else if (toUnit == "Nanometer")
            {
                return valueInMeters / 0.000000001;
            }
            else if (toUnit == "Yard")
            {
                return valueInMeters / 0.9144;
            }
            else if (toUnit == "Light Year")
            {
                return valueInMeters / 9.461e+15;
            }
            else if (toUnit == "Meter")
            {
                return valueInMeters;
            }

            return valueInMeters; // Default is meters
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
                    "Mass/Weight",
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
                case "Mass/Weight":
                    unitForm = new WeightConverter();
                    break;
                case "Volume":
                    unitForm = new VolumeConverter();
                    break;
                case "Temperature":
                    unitForm = new TemperatureConverter();
                    break;
                case "Speed":
                    unitForm = new SpeedConverter();
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
