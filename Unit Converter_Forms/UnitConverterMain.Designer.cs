namespace Unit_Converter_Forms
{
    partial class UnitConverterMain
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
            MeasSystem_lbl = new Label();
            Start_btn = new Button();
            Unit_lbl = new Label();
            Units_cmbbox = new ComboBox();
            Imperial_rbtn = new RadioButton();
            Metric_rbtn = new RadioButton();
            SuspendLayout();
            // 
            // MeasSystem_lbl
            // 
            MeasSystem_lbl.AutoSize = true;
            MeasSystem_lbl.Font = new Font("Arial", 12F, FontStyle.Underline);
            MeasSystem_lbl.Location = new Point(12, 9);
            MeasSystem_lbl.Name = "MeasSystem_lbl";
            MeasSystem_lbl.Size = new Size(246, 18);
            MeasSystem_lbl.TabIndex = 1;
            MeasSystem_lbl.Text = "SELECT PREFERRED SYSTEM:";
            // 
            // Start_btn
            // 
            Start_btn.AutoSize = true;
            Start_btn.Location = new Point(138, 250);
            Start_btn.Name = "Start_btn";
            Start_btn.Size = new Size(120, 25);
            Start_btn.TabIndex = 4;
            Start_btn.Text = "START";
            Start_btn.UseVisualStyleBackColor = true;
            Start_btn.Click += Start_btn_Click;
            // 
            // Unit_lbl
            // 
            Unit_lbl.AutoSize = true;
            Unit_lbl.Font = new Font("Arial", 12F, FontStyle.Underline);
            Unit_lbl.Location = new Point(12, 82);
            Unit_lbl.Name = "Unit_lbl";
            Unit_lbl.Size = new Size(111, 18);
            Unit_lbl.TabIndex = 5;
            Unit_lbl.Text = "SELECT UNIT:";
            // 
            // Units_cmbbox
            // 
            Units_cmbbox.BackColor = Color.White;
            Units_cmbbox.Font = new Font("Arial", 14F);
            Units_cmbbox.ForeColor = Color.Black;
            Units_cmbbox.FormattingEnabled = true;
            Units_cmbbox.Location = new Point(12, 103);
            Units_cmbbox.Name = "Units_cmbbox";
            Units_cmbbox.Size = new Size(203, 30);
            Units_cmbbox.TabIndex = 6;
            // 
            // Imperial_rbtn
            // 
            Imperial_rbtn.AutoSize = true;
            Imperial_rbtn.Font = new Font("Arial", 12F);
            Imperial_rbtn.Location = new Point(12, 30);
            Imperial_rbtn.Name = "Imperial_rbtn";
            Imperial_rbtn.Size = new Size(144, 22);
            Imperial_rbtn.TabIndex = 7;
            Imperial_rbtn.TabStop = true;
            Imperial_rbtn.Text = "IMPERIAL (USA)";
            Imperial_rbtn.UseVisualStyleBackColor = true;
            // 
            // Metric_rbtn
            // 
            Metric_rbtn.AutoSize = true;
            Metric_rbtn.Font = new Font("Arial", 12F);
            Metric_rbtn.Location = new Point(162, 30);
            Metric_rbtn.Name = "Metric_rbtn";
            Metric_rbtn.Size = new Size(85, 22);
            Metric_rbtn.TabIndex = 8;
            Metric_rbtn.TabStop = true;
            Metric_rbtn.Text = "METRIC";
            Metric_rbtn.UseVisualStyleBackColor = true;
            // 
            // UnitConverterMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(523, 376);
            Controls.Add(Metric_rbtn);
            Controls.Add(Imperial_rbtn);
            Controls.Add(Units_cmbbox);
            Controls.Add(Unit_lbl);
            Controls.Add(Start_btn);
            Controls.Add(MeasSystem_lbl);
            Font = new Font("Arial", 9F);
            ForeColor = Color.Black;
            Name = "UnitConverterMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UnitConverterMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label MeasSystem_lbl;
        private Button Start_btn;
        private Label Unit_lbl;
        private ComboBox Units_cmbbox;
        private RadioButton Imperial_rbtn;
        private RadioButton Metric_rbtn;
    }
}