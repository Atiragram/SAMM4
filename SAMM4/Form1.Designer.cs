namespace SAMM4
{
    partial class Form1
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
            this.defectNumeric = new System.Windows.Forms.NumericUpDown();
            this.timeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.repairNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.defectNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // defectNumeric
            // 
            this.defectNumeric.DecimalPlaces = 2;
            this.defectNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.defectNumeric.Location = new System.Drawing.Point(330, 55);
            this.defectNumeric.Margin = new System.Windows.Forms.Padding(5);
            this.defectNumeric.Name = "defectNumeric";
            this.defectNumeric.Size = new System.Drawing.Size(200, 31);
            this.defectNumeric.TabIndex = 0;
            this.defectNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // timeNumeric
            // 
            this.timeNumeric.Location = new System.Drawing.Point(330, 156);
            this.timeNumeric.Margin = new System.Windows.Forms.Padding(5);
            this.timeNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timeNumeric.Name = "timeNumeric";
            this.timeNumeric.Size = new System.Drawing.Size(200, 31);
            this.timeNumeric.TabIndex = 1;
            this.timeNumeric.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во часов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Интенсивность потока неисправностей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "неисправн./сутки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "суток";
            // 
            // repairNumeric
            // 
            this.repairNumeric.DecimalPlaces = 2;
            this.repairNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.repairNumeric.Location = new System.Drawing.Point(330, 106);
            this.repairNumeric.Margin = new System.Windows.Forms.Padding(5);
            this.repairNumeric.Name = "repairNumeric";
            this.repairNumeric.Size = new System.Drawing.Size(200, 31);
            this.repairNumeric.TabIndex = 7;
            this.repairNumeric.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Интенсивность потока ремона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "исправление./сутки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 236);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(561, 151);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 463);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.repairNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeNumeric);
            this.Controls.Add(this.defectNumeric);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.defectNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown defectNumeric;
        private System.Windows.Forms.NumericUpDown timeNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown repairNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

