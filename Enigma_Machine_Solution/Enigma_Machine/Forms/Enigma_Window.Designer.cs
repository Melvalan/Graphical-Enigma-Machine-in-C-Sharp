namespace Enigma_Machine.Forms
{
    partial class Enigma_Window
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.slowRing_box = new System.Windows.Forms.NumericUpDown();
            this.mediumRing_box = new System.Windows.Forms.NumericUpDown();
            this.fastRing_box = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fastGround_box = new System.Windows.Forms.NumericUpDown();
            this.mediumGround_box = new System.Windows.Forms.NumericUpDown();
            this.slowGround_box = new System.Windows.Forms.NumericUpDown();
            this.slowRotor_box = new System.Windows.Forms.ComboBox();
            this.mediumRotor_box = new System.Windows.Forms.ComboBox();
            this.fastRotor_box = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stecker_box = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.reflector_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EDText_box = new System.Windows.Forms.TextBox();
            this.ED_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slowRing_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumRing_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastRing_box)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastGround_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumGround_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slowGround_box)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(12, 221);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(642, 339);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // slowRing_box
            // 
            this.slowRing_box.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowRing_box.Location = new System.Drawing.Point(33, 22);
            this.slowRing_box.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.slowRing_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slowRing_box.Name = "slowRing_box";
            this.slowRing_box.Size = new System.Drawing.Size(37, 23);
            this.slowRing_box.TabIndex = 1;
            this.slowRing_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mediumRing_box
            // 
            this.mediumRing_box.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumRing_box.Location = new System.Drawing.Point(76, 22);
            this.mediumRing_box.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.mediumRing_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mediumRing_box.Name = "mediumRing_box";
            this.mediumRing_box.Size = new System.Drawing.Size(37, 23);
            this.mediumRing_box.TabIndex = 2;
            this.mediumRing_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fastRing_box
            // 
            this.fastRing_box.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastRing_box.Location = new System.Drawing.Point(119, 22);
            this.fastRing_box.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.fastRing_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fastRing_box.Name = "fastRing_box";
            this.fastRing_box.Size = new System.Drawing.Size(37, 23);
            this.fastRing_box.TabIndex = 3;
            this.fastRing_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fastRing_box);
            this.groupBox1.Controls.Add(this.mediumRing_box);
            this.groupBox1.Controls.Add(this.slowRing_box);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(476, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(178, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ring Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fastGround_box);
            this.groupBox2.Controls.Add(this.mediumGround_box);
            this.groupBox2.Controls.Add(this.slowGround_box);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(476, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(178, 60);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ground Settings";
            // 
            // fastGround_box
            // 
            this.fastGround_box.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastGround_box.Location = new System.Drawing.Point(119, 22);
            this.fastGround_box.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.fastGround_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fastGround_box.Name = "fastGround_box";
            this.fastGround_box.Size = new System.Drawing.Size(37, 23);
            this.fastGround_box.TabIndex = 3;
            this.fastGround_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mediumGround_box
            // 
            this.mediumGround_box.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumGround_box.Location = new System.Drawing.Point(76, 22);
            this.mediumGround_box.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.mediumGround_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mediumGround_box.Name = "mediumGround_box";
            this.mediumGround_box.Size = new System.Drawing.Size(37, 23);
            this.mediumGround_box.TabIndex = 2;
            this.mediumGround_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // slowGround_box
            // 
            this.slowGround_box.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowGround_box.Location = new System.Drawing.Point(33, 22);
            this.slowGround_box.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.slowGround_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slowGround_box.Name = "slowGround_box";
            this.slowGround_box.Size = new System.Drawing.Size(37, 23);
            this.slowGround_box.TabIndex = 1;
            this.slowGround_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // slowRotor_box
            // 
            this.slowRotor_box.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowRotor_box.FormattingEnabled = true;
            this.slowRotor_box.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.slowRotor_box.Location = new System.Drawing.Point(18, 37);
            this.slowRotor_box.Name = "slowRotor_box";
            this.slowRotor_box.Size = new System.Drawing.Size(49, 23);
            this.slowRotor_box.TabIndex = 10;
            this.slowRotor_box.Text = "I";
            // 
            // mediumRotor_box
            // 
            this.mediumRotor_box.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumRotor_box.FormattingEnabled = true;
            this.mediumRotor_box.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.mediumRotor_box.Location = new System.Drawing.Point(73, 38);
            this.mediumRotor_box.Name = "mediumRotor_box";
            this.mediumRotor_box.Size = new System.Drawing.Size(49, 23);
            this.mediumRotor_box.TabIndex = 11;
            this.mediumRotor_box.Text = "II";
            // 
            // fastRotor_box
            // 
            this.fastRotor_box.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastRotor_box.FormattingEnabled = true;
            this.fastRotor_box.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.fastRotor_box.Location = new System.Drawing.Point(128, 38);
            this.fastRotor_box.Name = "fastRotor_box";
            this.fastRotor_box.Size = new System.Drawing.Size(49, 23);
            this.fastRotor_box.TabIndex = 12;
            this.fastRotor_box.Text = "III";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fastRotor_box);
            this.groupBox3.Controls.Add(this.mediumRotor_box);
            this.groupBox3.Controls.Add(this.slowRotor_box);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 76);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rotor order (Left to Right)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.stecker_box);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(234, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 138);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Steckers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Steckers separated by \r\ncomma. e.g. \"CA, JD, TR\"\r\n";
            // 
            // stecker_box
            // 
            this.stecker_box.Location = new System.Drawing.Point(10, 78);
            this.stecker_box.Multiline = true;
            this.stecker_box.Name = "stecker_box";
            this.stecker_box.Size = new System.Drawing.Size(202, 45);
            this.stecker_box.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.reflector_box);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(13, 90);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(195, 60);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reflector";
            // 
            // reflector_box
            // 
            this.reflector_box.FormattingEnabled = true;
            this.reflector_box.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.reflector_box.Location = new System.Drawing.Point(18, 24);
            this.reflector_box.Name = "reflector_box";
            this.reflector_box.Size = new System.Drawing.Size(159, 25);
            this.reflector_box.TabIndex = 0;
            this.reflector_box.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Text to Encrypt/Decrypt:";
            // 
            // EDText_box
            // 
            this.EDText_box.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDText_box.Location = new System.Drawing.Point(169, 153);
            this.EDText_box.Multiline = true;
            this.EDText_box.Name = "EDText_box";
            this.EDText_box.Size = new System.Drawing.Size(283, 62);
            this.EDText_box.TabIndex = 17;
            // 
            // ED_btn
            // 
            this.ED_btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ED_btn.Location = new System.Drawing.Point(476, 156);
            this.ED_btn.Name = "ED_btn";
            this.ED_btn.Size = new System.Drawing.Size(178, 59);
            this.ED_btn.TabIndex = 18;
            this.ED_btn.Text = "Encrypt/Decrypt";
            this.ED_btn.UseVisualStyleBackColor = true;
            this.ED_btn.Click += new System.EventHandler(this.ED_btn_Click);
            // 
            // Enigma_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(667, 572);
            this.Controls.Add(this.ED_btn);
            this.Controls.Add(this.EDText_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Enigma_Window";
            this.Text = "Enigma Machine";
            ((System.ComponentModel.ISupportInitialize)(this.slowRing_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumRing_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastRing_box)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastGround_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumGround_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slowGround_box)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown slowRing_box;
        private System.Windows.Forms.NumericUpDown mediumRing_box;
        private System.Windows.Forms.NumericUpDown fastRing_box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown fastGround_box;
        private System.Windows.Forms.NumericUpDown mediumGround_box;
        private System.Windows.Forms.NumericUpDown slowGround_box;
        private System.Windows.Forms.ComboBox slowRotor_box;
        private System.Windows.Forms.ComboBox mediumRotor_box;
        private System.Windows.Forms.ComboBox fastRotor_box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stecker_box;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox reflector_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EDText_box;
        private System.Windows.Forms.Button ED_btn;
    }
}

