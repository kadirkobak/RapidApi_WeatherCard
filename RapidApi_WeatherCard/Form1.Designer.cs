namespace RapidApi_WeatherCard
{
    partial class Form1
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblWindSpeed = new Label();
            lblFahrenheit = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 54);
            label1.TabIndex = 0;
            label1.Text = "İstanbul, TR";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.sunny;
            pictureBox1.Location = new Point(21, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(187, 41);
            label2.TabIndex = 2;
            label2.Text = "İstanbul, TR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(21, 137);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 3;
            label3.Text = "Today";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(202, 278);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 4;
            label4.Text = "Today";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(195, 191);
            label5.Name = "label5";
            label5.Size = new Size(191, 81);
            label5.TabIndex = 5;
            label5.Text = "00.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(365, 191);
            label6.Name = "label6";
            label6.Size = new Size(21, 23);
            label6.TabIndex = 6;
            label6.Text = "C";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(74, 347);
            label7.Name = "label7";
            label7.Size = new Size(67, 28);
            label7.TabIndex = 7;
            label7.Text = "Wind:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(40, 375);
            label8.Name = "label8";
            label8.Size = new Size(102, 28);
            label8.TabIndex = 8;
            label8.Text = "Moisture:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(25, 403);
            label9.Name = "label9";
            label9.Size = new Size(117, 28);
            label9.TabIndex = 9;
            label9.Text = "Fahrenheit:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(147, 347);
            label10.Name = "label10";
            label10.Size = new Size(36, 28);
            label10.TabIndex = 10;
            label10.Text = "00";
            // 
            // lblWindSpeed
            // 
            lblWindSpeed.AutoSize = true;
            lblWindSpeed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblWindSpeed.ForeColor = SystemColors.ControlLightLight;
            lblWindSpeed.Location = new Point(147, 375);
            lblWindSpeed.Name = "lblWindSpeed";
            lblWindSpeed.Size = new Size(36, 28);
            lblWindSpeed.TabIndex = 11;
            lblWindSpeed.Text = "00";
            // 
            // lblFahrenheit
            // 
            lblFahrenheit.AutoSize = true;
            lblFahrenheit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFahrenheit.ForeColor = SystemColors.ControlLightLight;
            lblFahrenheit.Location = new Point(147, 403);
            lblFahrenheit.Name = "lblFahrenheit";
            lblFahrenheit.Size = new Size(36, 28);
            lblFahrenheit.TabIndex = 12;
            lblFahrenheit.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(476, 466);
            Controls.Add(lblFahrenheit);
            Controls.Add(lblWindSpeed);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblWindSpeed;
        private Label lblFahrenheit;
    }
}
