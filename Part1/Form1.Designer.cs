namespace Part1
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
        private void InitializeComponent() {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(410, 25);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(197, 29);
            label1.TabIndex = 1;
            label1.Text = "Your string here: ";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(180, 29);
            label2.TabIndex = 6;
            label2.Text = "Encoded string: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 83);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(410, 25);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(142, 29);
            label3.TabIndex = 8;
            label3.Text = "Input Code: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 123);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(410, 25);
            textBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(158, 29);
            label4.TabIndex = 10;
            label4.Text = "Output Code: ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(211, 163);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(410, 25);
            textBox4.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(644, 84);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 12;
            button1.Text = "Copy!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(644, 120);
            button2.Name = "button2";
            button2.Size = new Size(83, 25);
            button2.TabIndex = 13;
            button2.Text = "Copy!";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(644, 163);
            button3.Name = "button3";
            button3.Size = new Size(83, 25);
            button3.TabIndex = 14;
            button3.Text = "Copy!";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(644, 205);
            button4.Name = "button4";
            button4.Size = new Size(95, 60);
            button4.TabIndex = 15;
            button4.Text = "PRINT";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(211, 205);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(410, 60);
            textBox5.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 268);
            label5.Name = "label5";
            label5.Size = new Size(45, 18);
            label5.TabIndex = 17;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(644, 40);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(83, 25);
            textBox6.TabIndex = 18;
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
    }
}
