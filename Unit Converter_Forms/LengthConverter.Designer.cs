namespace Unit_Converter_Forms
{
    partial class LengthConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LengthConverter));
            FromUnit_cmb = new ComboBox();
            ToUnit_cmb = new ComboBox();
            Input_tb = new TextBox();
            Output_tb = new TextBox();
            Convert_btn = new Button();
            FromUnit_lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            toolStrip1 = new ToolStrip();
            TemperatureTool_btn = new ToolStripButton();
            AreaTool_btn = new ToolStripButton();
            VolumeTool_btn = new ToolStripButton();
            WeightTool_btn = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // FromUnit_cmb
            // 
            FromUnit_cmb.FlatStyle = FlatStyle.Flat;
            FromUnit_cmb.FormattingEnabled = true;
            FromUnit_cmb.Items.AddRange(new object[] { "Meter", "Kilometer", "Centimeter", "Millimeter", "Micrometer", "Nanometer", "Mile", "Yard", "Foot", "Inch", "Light Year" });
            FromUnit_cmb.Location = new Point(12, 44);
            FromUnit_cmb.Name = "FromUnit_cmb";
            FromUnit_cmb.Size = new Size(134, 23);
            FromUnit_cmb.TabIndex = 0;
            // 
            // ToUnit_cmb
            // 
            ToUnit_cmb.FlatStyle = FlatStyle.Flat;
            ToUnit_cmb.FormattingEnabled = true;
            ToUnit_cmb.Items.AddRange(new object[] { "Meter", "Kilometer", "Centimeter", "Millimeter", "Micrometer", "Nanometer", "Mile", "Yard", "Foot", "Inch", "Light Year" });
            ToUnit_cmb.Location = new Point(151, 44);
            ToUnit_cmb.Name = "ToUnit_cmb";
            ToUnit_cmb.Size = new Size(134, 23);
            ToUnit_cmb.TabIndex = 1;
            // 
            // Input_tb
            // 
            Input_tb.Location = new Point(12, 99);
            Input_tb.Name = "Input_tb";
            Input_tb.Size = new Size(133, 21);
            Input_tb.TabIndex = 2;
            // 
            // Output_tb
            // 
            Output_tb.Location = new Point(151, 99);
            Output_tb.Name = "Output_tb";
            Output_tb.Size = new Size(134, 21);
            Output_tb.TabIndex = 3;
            // 
            // Convert_btn
            // 
            Convert_btn.FlatStyle = FlatStyle.Flat;
            Convert_btn.Location = new Point(110, 126);
            Convert_btn.Name = "Convert_btn";
            Convert_btn.Size = new Size(75, 23);
            Convert_btn.TabIndex = 4;
            Convert_btn.Text = "CONVERT";
            Convert_btn.UseVisualStyleBackColor = true;
            Convert_btn.Click += Convert_btn_Click;
            // 
            // FromUnit_lbl
            // 
            FromUnit_lbl.AutoSize = true;
            FromUnit_lbl.Location = new Point(12, 26);
            FromUnit_lbl.Name = "FromUnit_lbl";
            FromUnit_lbl.Size = new Size(133, 15);
            FromUnit_lbl.TabIndex = 5;
            FromUnit_lbl.Text = "CONVERT FROM UNIT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 26);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 6;
            label1.Text = "CONVERT TO UNIT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 7;
            label2.Text = "INPUT VALUE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 81);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 8;
            label3.Text = "OUTPUT VALUE";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TemperatureTool_btn, AreaTool_btn, VolumeTool_btn, WeightTool_btn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(297, 25);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // TemperatureTool_btn
            // 
            TemperatureTool_btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TemperatureTool_btn.Font = new Font("Arial", 9F);
            TemperatureTool_btn.Image = (Image)resources.GetObject("TemperatureTool_btn.Image");
            TemperatureTool_btn.ImageTransparentColor = Color.Magenta;
            TemperatureTool_btn.Name = "TemperatureTool_btn";
            TemperatureTool_btn.Size = new Size(81, 22);
            TemperatureTool_btn.Text = "Temperature";
            TemperatureTool_btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            TemperatureTool_btn.Click += TemperatureTool_btn_Click;
            // 
            // AreaTool_btn
            // 
            AreaTool_btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AreaTool_btn.Font = new Font("Arial", 9F);
            AreaTool_btn.Image = (Image)resources.GetObject("AreaTool_btn.Image");
            AreaTool_btn.ImageTransparentColor = Color.Magenta;
            AreaTool_btn.Name = "AreaTool_btn";
            AreaTool_btn.Size = new Size(36, 22);
            AreaTool_btn.Text = "Area";
            AreaTool_btn.Click += AreaTool_btn_Click;
            // 
            // VolumeTool_btn
            // 
            VolumeTool_btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            VolumeTool_btn.Font = new Font("Arial", 9F);
            VolumeTool_btn.Image = (Image)resources.GetObject("VolumeTool_btn.Image");
            VolumeTool_btn.ImageTransparentColor = Color.Magenta;
            VolumeTool_btn.Name = "VolumeTool_btn";
            VolumeTool_btn.Size = new Size(52, 22);
            VolumeTool_btn.Text = "Volume";
            VolumeTool_btn.Click += VolumeTool_btn_Click;
            // 
            // WeightTool_btn
            // 
            WeightTool_btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            WeightTool_btn.Font = new Font("Arial", 9F);
            WeightTool_btn.Image = (Image)resources.GetObject("WeightTool_btn.Image");
            WeightTool_btn.ImageTransparentColor = Color.Magenta;
            WeightTool_btn.Name = "WeightTool_btn";
            WeightTool_btn.Size = new Size(49, 22);
            WeightTool_btn.Text = "Weight";
            WeightTool_btn.Click += WeightTool_btn_Click;
            // 
            // LengthConverter
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
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "LengthConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Length Converter";
            Load += LengthConverter_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox FromUnit_cmb;
        private ComboBox ToUnit_cmb;
        private TextBox Input_tb;
        private TextBox Output_tb;
        private Button Convert_btn;
        private Label FromUnit_lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolStrip toolStrip1;
        private ToolStripButton TemperatureTool_btn;
        private ToolStripButton AreaTool_btn;
        private ToolStripButton VolumeTool_btn;
        private ToolStripButton WeightTool_btn;
    }
}
