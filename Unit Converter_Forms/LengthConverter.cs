namespace Unit_Converter_Forms
{
    public partial class LengthConverter : Form
    {
        public LengthConverter()
        {
            InitializeComponent();
        }

        private void LengthConverter_Load(object sender, EventArgs e)
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

        private void WeightTool_btn_Click(object sender, EventArgs e)
        {
            WeightConverter weightConverter = new WeightConverter();
            weightConverter.Show();
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

    }
}
