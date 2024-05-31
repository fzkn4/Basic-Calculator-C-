namespace calcushit
{
    partial class Form2
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
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 195, 152);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 5);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(157, 157, 157);
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(211, 45);
            label1.TabIndex = 1;
            label1.Text = "CALCULATOR";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(254, 253, 237);
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(44, 107);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(167, 33);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Enter += textEnter;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(254, 253, 237);
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(44, 179);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.Size = new Size(167, 33);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Enter += textEnter;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(254, 253, 237);
            textBox3.Enabled = false;
            textBox3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(44, 248);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(167, 50);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(44, 89);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 5;
            label2.Text = "1st number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(44, 161);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 6;
            label3.Text = "2nd number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(44, 230);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Result:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(254, 253, 237);
            button2.FlatAppearance.BorderColor = Color.FromArgb(254, 253, 237);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 253, 237);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 112, 112);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.IndianRed;
            button2.Location = new Point(524, 6);
            button2.Name = "button2";
            button2.Padding = new Padding(2);
            button2.Size = new Size(35, 35);
            button2.TabIndex = 8;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(157, 157, 157);
            button1.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(157, 157, 157);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 253, 237);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F);
            button1.ForeColor = Color.FromArgb(49, 54, 63);
            button1.Location = new Point(249, 80);
            button1.Name = "button1";
            button1.Size = new Size(60, 50);
            button1.TabIndex = 9;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += buttonClick;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(157, 157, 157);
            button3.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(157, 157, 157);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 253, 237);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 18F);
            button3.ForeColor = Color.FromArgb(49, 54, 63);
            button3.Location = new Point(315, 80);
            button3.Name = "button3";
            button3.Size = new Size(60, 50);
            button3.TabIndex = 10;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonClick;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(157, 157, 157);
            button4.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(157, 157, 157);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 253, 237);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 18F);
            button4.ForeColor = Color.FromArgb(49, 54, 63);
            button4.Location = new Point(381, 80);
            button4.Name = "button4";
            button4.Size = new Size(60, 50);
            button4.TabIndex = 11;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonClick;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(157, 157, 157);
            button5.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(157, 157, 157);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 253, 237);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 18F);
            button5.ForeColor = Color.FromArgb(49, 54, 63);
            button5.Location = new Point(249, 136);
            button5.Name = "button5";
            button5.Size = new Size(60, 50);
            button5.TabIndex = 12;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttonClick;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(157, 157, 157);
            button6.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(157, 157, 157);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 253, 237);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 18F);
            button6.ForeColor = Color.FromArgb(49, 54, 63);
            button6.Location = new Point(315, 135);
            button6.Name = "button6";
            button6.Size = new Size(60, 50);
            button6.TabIndex = 13;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += buttonClick;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(157, 157, 157);
            button7.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(157, 157, 157);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 253, 237);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 18F);
            button7.ForeColor = Color.FromArgb(49, 54, 63);
            button7.Location = new Point(381, 136);
            button7.Name = "button7";
            button7.Size = new Size(60, 50);
            button7.TabIndex = 14;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonClick;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(157, 157, 157);
            button8.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
            button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(157, 157, 157);
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 253, 237);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 18F);
            button8.ForeColor = Color.FromArgb(49, 54, 63);
            button8.Location = new Point(249, 192);
            button8.Name = "button8";
            button8.Size = new Size(60, 50);
            button8.TabIndex = 15;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttonClick;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(157, 157, 157);
            button9.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
            button9.FlatAppearance.MouseDownBackColor = Color.FromArgb(157, 157, 157);
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 253, 237);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 18F);
            button9.ForeColor = Color.FromArgb(49, 54, 63);
            button9.Location = new Point(315, 191);
            button9.Name = "button9";
            button9.Size = new Size(60, 50);
            button9.TabIndex = 16;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = false;
            button9.Click += buttonClick;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(157, 157, 157);
            button10.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
            button10.FlatAppearance.MouseDownBackColor = Color.FromArgb(157, 157, 157);
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 253, 237);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 18F);
            button10.ForeColor = Color.FromArgb(49, 54, 63);
            button10.Location = new Point(381, 192);
            button10.Name = "button10";
            button10.Size = new Size(60, 50);
            button10.TabIndex = 17;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = false;
            button10.Click += buttonClick;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(157, 157, 157);
            button11.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
            button11.FlatAppearance.MouseDownBackColor = Color.FromArgb(157, 157, 157);
            button11.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 253, 237);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 18F);
            button11.ForeColor = Color.FromArgb(49, 54, 63);
            button11.Location = new Point(315, 247);
            button11.Name = "button11";
            button11.Size = new Size(60, 50);
            button11.TabIndex = 18;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            button11.Click += buttonClick;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(255, 195, 116);
            button12.FlatAppearance.BorderColor = Color.FromArgb(255, 195, 116);
            button12.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 253, 237);
            button12.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 232, 151);
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.FromArgb(220, 107, 25);
            button12.Location = new Point(249, 247);
            button12.Name = "button12";
            button12.Size = new Size(60, 50);
            button12.TabIndex = 19;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(198, 235, 197);
            button13.FlatAppearance.BorderColor = Color.FromArgb(198, 235, 197);
            button13.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 253, 237);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            button13.ForeColor = Color.FromArgb(161, 195, 152);
            button13.Location = new Point(447, 80);
            button13.Name = "button13";
            button13.Size = new Size(60, 50);
            button13.TabIndex = 20;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(198, 235, 197);
            button14.FlatAppearance.BorderColor = Color.FromArgb(198, 235, 197);
            button14.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 253, 237);
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            button14.ForeColor = Color.FromArgb(161, 195, 152);
            button14.Location = new Point(447, 135);
            button14.Name = "button14";
            button14.Size = new Size(60, 50);
            button14.TabIndex = 21;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(198, 235, 197);
            button15.FlatAppearance.BorderColor = Color.FromArgb(198, 235, 197);
            button15.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 253, 237);
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            button15.ForeColor = Color.FromArgb(161, 195, 152);
            button15.Location = new Point(447, 191);
            button15.Name = "button15";
            button15.Size = new Size(60, 50);
            button15.TabIndex = 22;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(198, 235, 197);
            button16.FlatAppearance.BorderColor = Color.FromArgb(198, 235, 197);
            button16.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 253, 237);
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            button16.ForeColor = Color.FromArgb(161, 195, 152);
            button16.Location = new Point(447, 247);
            button16.Name = "button16";
            button16.Size = new Size(60, 50);
            button16.TabIndex = 23;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(231, 136, 149);
            button17.FlatAppearance.BorderColor = Color.FromArgb(231, 136, 149);
            button17.FlatAppearance.MouseDownBackColor = Color.FromArgb(231, 136, 149);
            button17.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 228, 201);
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.ForeColor = Color.IndianRed;
            button17.Location = new Point(381, 247);
            button17.Name = "button17";
            button17.Size = new Size(60, 50);
            button17.TabIndex = 24;
            button17.Text = "C";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 253, 237);
            ClientSize = new Size(561, 343);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
    }
}