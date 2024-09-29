namespace Unit_Converter_Forms
{
    partial class AreaConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaConverter));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            FromUnit_lbl = new Label();
            Convert_btn = new Button();
            Output_tb = new TextBox();
            Input_tb = new TextBox();
            ToUnit_cmb = new ComboBox();
            FromUnit_cmb = new ComboBox();
            toolStrip1 = new ToolStrip();
            UnitsTool_dropbtn = new ToolStripDropDownButton();
            areaToolStripMenuItem = new ToolStripMenuItem();
            temperatureToolStripMenuItem = new ToolStripMenuItem();
            massWeightToolStripMenuItem = new ToolStripMenuItem();
            lengthDistanceToolStripMenuItem = new ToolStripMenuItem();
            volumeToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 85);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 18;
            label3.Text = "OUTPUT VALUE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 17;
            label2.Text = "INPUT VALUE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 30);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 16;
            label1.Text = "CONVERT TO UNIT";
            // 
            // FromUnit_lbl
            // 
            FromUnit_lbl.AutoSize = true;
            FromUnit_lbl.Location = new Point(12, 30);
            FromUnit_lbl.Name = "FromUnit_lbl";
            FromUnit_lbl.Size = new Size(133, 15);
            FromUnit_lbl.TabIndex = 15;
            FromUnit_lbl.Text = "CONVERT FROM UNIT";
            // 
            // Convert_btn
            // 
            Convert_btn.FlatStyle = FlatStyle.Flat;
            Convert_btn.Location = new Point(110, 130);
            Convert_btn.Name = "Convert_btn";
            Convert_btn.Size = new Size(75, 23);
            Convert_btn.TabIndex = 14;
            Convert_btn.Text = "CONVERT";
            Convert_btn.UseVisualStyleBackColor = true;
            Convert_btn.Click += Convert_btn_Click;
            // 
            // Output_tb
            // 
            Output_tb.Font = new Font("Arial", 9F);
            Output_tb.Location = new Point(151, 103);
            Output_tb.Name = "Output_tb";
            Output_tb.Size = new Size(134, 21);
            Output_tb.TabIndex = 13;
            // 
            // Input_tb
            // 
            Input_tb.Location = new Point(12, 103);
            Input_tb.Name = "Input_tb";
            Input_tb.Size = new Size(133, 21);
            Input_tb.TabIndex = 12;
            // 
            // ToUnit_cmb
            // 
            ToUnit_cmb.FlatStyle = FlatStyle.Flat;
            ToUnit_cmb.FormattingEnabled = true;
            ToUnit_cmb.Items.AddRange(new object[] { "Square Meter", "Square Kilometer", "Square Centimeter", "Square Millimeter", "Square Micrometer", "Square Mile", "Square Yard", "Square Foot", "Square Inch", "Hectare", "Acre" });
            ToUnit_cmb.Location = new Point(151, 48);
            ToUnit_cmb.Name = "ToUnit_cmb";
            ToUnit_cmb.Size = new Size(134, 23);
            ToUnit_cmb.TabIndex = 11;
            // 
            // FromUnit_cmb
            // 
            FromUnit_cmb.FlatStyle = FlatStyle.Flat;
            FromUnit_cmb.FormattingEnabled = true;
            FromUnit_cmb.Items.AddRange(new object[] { "Square Meter", "Square Kilometer", "Square Centimeter", "Square Millimeter", "Square Micrometer", "Square Mile", "Square Yard", "Square Foot", "Square Inch", "Hectare", "Acre" });
            FromUnit_cmb.Location = new Point(12, 48);
            FromUnit_cmb.Name = "FromUnit_cmb";
            FromUnit_cmb.Size = new Size(134, 23);
            FromUnit_cmb.TabIndex = 10;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { UnitsTool_dropbtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(297, 25);
            toolStrip1.TabIndex = 20;
            toolStrip1.Text = "toolStrip1";
            // 
            // UnitsTool_dropbtn
            // 
            UnitsTool_dropbtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            UnitsTool_dropbtn.DropDownItems.AddRange(new ToolStripItem[] { areaToolStripMenuItem, temperatureToolStripMenuItem, massWeightToolStripMenuItem, lengthDistanceToolStripMenuItem, volumeToolStripMenuItem });
            UnitsTool_dropbtn.Image = (Image)resources.GetObject("UnitsTool_dropbtn.Image");
            UnitsTool_dropbtn.ImageTransparentColor = Color.Magenta;
            UnitsTool_dropbtn.Name = "UnitsTool_dropbtn";
            UnitsTool_dropbtn.Size = new Size(47, 22);
            UnitsTool_dropbtn.Text = "Units";
            // 
            // areaToolStripMenuItem
            // 
            areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            areaToolStripMenuItem.Size = new Size(180, 22);
            areaToolStripMenuItem.Text = "Area";
            // 
            // temperatureToolStripMenuItem
            // 
            temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            temperatureToolStripMenuItem.Size = new Size(180, 22);
            temperatureToolStripMenuItem.Text = "Temperature";
            // 
            // massWeightToolStripMenuItem
            // 
            massWeightToolStripMenuItem.Name = "massWeightToolStripMenuItem";
            massWeightToolStripMenuItem.Size = new Size(180, 22);
            massWeightToolStripMenuItem.Text = "Mass/Weight";
            // 
            // lengthDistanceToolStripMenuItem
            // 
            lengthDistanceToolStripMenuItem.Name = "lengthDistanceToolStripMenuItem";
            lengthDistanceToolStripMenuItem.Size = new Size(180, 22);
            lengthDistanceToolStripMenuItem.Text = "Length/Distance";
            // 
            // volumeToolStripMenuItem
            // 
            volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            volumeToolStripMenuItem.Size = new Size(180, 22);
            volumeToolStripMenuItem.Text = "Volume";
            // 
            // AreaConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 156);
            Controls.Add(toolStrip1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FromUnit_lbl);
            Controls.Add(Convert_btn);
            Controls.Add(Output_tb);
            Controls.Add(Input_tb);
            Controls.Add(ToUnit_cmb);
            Controls.Add(FromUnit_cmb);
            Font = new Font("Arial", 9F);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AreaConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Area Converter";
            Load += AreaConverter_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Label FromUnit_lbl;
        private Button Convert_btn;
        private TextBox Output_tb;
        private TextBox Input_tb;
        private ComboBox ToUnit_cmb;
        private ComboBox FromUnit_cmb;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton UnitsTool_dropbtn;
        private ToolStripMenuItem areaToolStripMenuItem;
        private ToolStripMenuItem temperatureToolStripMenuItem;
        private ToolStripMenuItem massWeightToolStripMenuItem;
        private ToolStripMenuItem lengthDistanceToolStripMenuItem;
        private ToolStripMenuItem volumeToolStripMenuItem;
    }
}