namespace Zählerstandsberechnung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEnde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.zS_1 = new System.Windows.Forms.TextBox();
            this.zS_2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.zS_D = new System.Windows.Forms.TextBox();
            this.zD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.jV = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tagesverbrauch = new System.Windows.Forms.TextBox();
            this.tbx_gewichteterJahresverbrauch = new System.Windows.Forms.TextBox();
            this.tbx_gewichteterTagesverbrauch = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(9, 32);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(308, 20);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum         Uhrzeit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePickerEnde
            // 
            this.dateTimePickerEnde.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerEnde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnde.Location = new System.Drawing.Point(9, 32);
            this.dateTimePickerEnde.Name = "dateTimePickerEnde";
            this.dateTimePickerEnde.Size = new System.Drawing.Size(308, 20);
            this.dateTimePickerEnde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum         Uhrzeit";
            // 
            // zS_1
            // 
            this.zS_1.Location = new System.Drawing.Point(9, 58);
            this.zS_1.Name = "zS_1";
            this.zS_1.Size = new System.Drawing.Size(308, 20);
            this.zS_1.TabIndex = 6;
            this.zS_1.Text = "Zählerstand";
            this.zS_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.zS_1.Enter += new System.EventHandler(this.zS_1_Enter);
            this.zS_1.Leave += new System.EventHandler(this.zS_1_Leave);
            // 
            // zS_2
            // 
            this.zS_2.Location = new System.Drawing.Point(9, 58);
            this.zS_2.Name = "zS_2";
            this.zS_2.Size = new System.Drawing.Size(308, 20);
            this.zS_2.TabIndex = 7;
            this.zS_2.Text = "Zählerstand";
            this.zS_2.TextChanged += new System.EventHandler(this.zS_2_TextChanged);
            this.zS_2.Enter += new System.EventHandler(this.zS_2_Enter);
            this.zS_2.Leave += new System.EventHandler(this.zS_2_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Differenz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zS_D
            // 
            this.zS_D.Location = new System.Drawing.Point(9, 19);
            this.zS_D.Name = "zS_D";
            this.zS_D.Size = new System.Drawing.Size(308, 20);
            this.zS_D.TabIndex = 9;
            // 
            // zD
            // 
            this.zD.Location = new System.Drawing.Point(9, 19);
            this.zD.Name = "zD";
            this.zD.Size = new System.Drawing.Size(308, 20);
            this.zD.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerEnde);
            this.groupBox1.Controls.Add(this.zS_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zählerstand 2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerStart);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.zS_2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 86);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zählerstand 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.zS_D);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 51);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Differenz";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.zD);
            this.groupBox4.Location = new System.Drawing.Point(12, 306);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 50);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zeit Differenz";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.jV);
            this.groupBox5.Location = new System.Drawing.Point(12, 424);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 53);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Jahresverbrauch";
            // 
            // jV
            // 
            this.jV.Location = new System.Drawing.Point(9, 20);
            this.jV.Name = "jV";
            this.jV.Size = new System.Drawing.Size(308, 20);
            this.jV.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tagesverbrauch);
            this.groupBox6.Location = new System.Drawing.Point(12, 362);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 56);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tagesverbrauch";
            // 
            // tagesverbrauch
            // 
            this.tagesverbrauch.Location = new System.Drawing.Point(9, 20);
            this.tagesverbrauch.Name = "tagesverbrauch";
            this.tagesverbrauch.Size = new System.Drawing.Size(308, 20);
            this.tagesverbrauch.TabIndex = 0;
            // 
            // tbx_gewichteterJahresverbrauch
            // 
            this.tbx_gewichteterJahresverbrauch.Location = new System.Drawing.Point(6, 19);
            this.tbx_gewichteterJahresverbrauch.Name = "tbx_gewichteterJahresverbrauch";
            this.tbx_gewichteterJahresverbrauch.Size = new System.Drawing.Size(308, 20);
            this.tbx_gewichteterJahresverbrauch.TabIndex = 17;
            this.tbx_gewichteterJahresverbrauch.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tbx_gewichteterTagesverbrauch
            // 
            this.tbx_gewichteterTagesverbrauch.Location = new System.Drawing.Point(6, 19);
            this.tbx_gewichteterTagesverbrauch.Name = "tbx_gewichteterTagesverbrauch";
            this.tbx_gewichteterTagesverbrauch.Size = new System.Drawing.Size(308, 20);
            this.tbx_gewichteterTagesverbrauch.TabIndex = 18;
            this.tbx_gewichteterTagesverbrauch.TextChanged += new System.EventHandler(this.tbx_gewichteterTagesverbrauch_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbx_gewichteterJahresverbrauch);
            this.groupBox7.Location = new System.Drawing.Point(347, 424);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(323, 53);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Gewichteter Jahresverbrauch";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbx_gewichteterTagesverbrauch);
            this.groupBox8.Location = new System.Drawing.Point(341, 362);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(329, 56);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Gewichteter Tagesverbrauch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 496);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Zählerstandsrechner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox zS_1;
        private System.Windows.Forms.TextBox zS_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox zS_D;
        private System.Windows.Forms.TextBox zD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tagesverbrauch;
        private System.Windows.Forms.TextBox jV;
        private System.Windows.Forms.TextBox tbx_gewichteterJahresverbrauch;
        private System.Windows.Forms.TextBox tbx_gewichteterTagesverbrauch;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}

