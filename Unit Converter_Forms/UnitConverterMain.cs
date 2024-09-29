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
    public partial class UnitConverterMain : Form
    {
        public UnitConverterMain()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            Units_cmbbox.Items.AddRange(new string[]
            {
                "Area",
                "Length/Distance",
                "Mass/Weight",
                "Volume",
                //"Time",
                "Temperature",
                //"Speed/Velocity",
                //"Pressure"
            });

            Units_cmbbox.SelectedIndex = 0;
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            if (Imperial_rbtn.Checked && Metric_rbtn.Checked)
            {
                MessageBox.Show("Please select either Imperial or Metric.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedUnit = Units_cmbbox.SelectedItem.ToString();

            string system = Imperial_rbtn.Checked ? "Imperial" : "Metric";

            LaunchUnitForm(system, selectedUnit);

        }

        private void LaunchUnitForm(string system, string unit)
        {
            // Logic to launch the unit form (can be customized further for each unit)
            MessageBox.Show($"Launching {unit} form from the {system} system.", "Unit Launch", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form unitForm = null;

            switch (unit)
            {
                case "Area":
                    unitForm = new AreaConverter();
                    break;
                case "Length/Distance":
                    unitForm = new LengthConverter();
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
                default:
                    MessageBox.Show("Invalid selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (unitForm != null)
            {
                unitForm?.Show();
            }
        }
    }
}
