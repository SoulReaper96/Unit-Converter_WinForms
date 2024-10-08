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
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void AreaTool_btn_Click(object sender, EventArgs e)
        {
            AreaConverter area = new AreaConverter();
            area.Show();
            this.Hide();
        }

        private void LengthTool_btn_Click(object sender, EventArgs e)
        {
            LengthConverter length = new LengthConverter();
            length.Show();
            this.Hide();
        }

        private void SpeedTool_btn_Click(object sender, EventArgs e)
        {
            SpeedConverter speed = new SpeedConverter();
            speed.Show();
            this.Hide();
        }

        private void TempTool_btn_Click(object sender, EventArgs e)
        {
            TemperatureConverter temperature = new TemperatureConverter();
            temperature.Show();
            this.Hide();
        }

        private void TimeTool_btn_Click(object sender, EventArgs e)
        {
            TimeConverter time = new TimeConverter();
            time.Show();
            this.Hide();
        }

        private void VolumeTool_btn_Click(object sender, EventArgs e)
        {
            VolumeConverter volume = new VolumeConverter();
            volume.Show();
            this.Hide();
        }

        private void WeightTool_btn_Click(object sender, EventArgs e)
        {
            WeightConverter weight = new WeightConverter();
            weight.Show();
            this.Hide();
        }

        private void About_lbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by: SoulReaper96\n" +
                            "Software Version: 1.0.0.0\n" +
                            "Thank you for using this software!");
        }
    }
}
