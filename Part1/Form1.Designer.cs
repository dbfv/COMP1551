using System.Windows.Forms;

namespace Part1 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label5 = new Label();
            button6 = new Button();
            label6 = new Label();
            label4 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(101, 18);
            label5.TabIndex = 17;
            label5.Text = "Word count: 0";
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(644, 12);
            button6.Name = "button6";
            button6.Size = new Size(95, 60);
            button6.TabIndex = 22;
            button6.Text = "RUN";
            button6.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = Color.Cyan;
            label6.Location = new Point(460, 9);
            label6.Name = "label6";
            label6.Size = new Size(48, 29);
            label6.TabIndex = 20;
            label6.Text = "N: ";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(12, 272);
            label4.Name = "label4";
            label4.Size = new Size(158, 29);
            label4.TabIndex = 10;
            label4.Text = "Output Code: ";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(644, 94);
            button4.Name = "button4";
            button4.Size = new Size(95, 60);
            button4.TabIndex = 15;
            button4.Text = "PRINT";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(644, 278);
            button3.Name = "button3";
            button3.Size = new Size(95, 25);
            button3.TabIndex = 14;
            button3.Text = "Copy!";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(644, 222);
            button2.Name = "button2";
            button2.Size = new Size(95, 25);
            button2.TabIndex = 13;
            button2.Text = "Copy!";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(644, 171);
            button1.Name = "button1";
            button1.Size = new Size(95, 25);
            button1.TabIndex = 12;
            button1.Text = "Copy!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(211, 278);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(410, 25);
            textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 222);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(410, 25);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(142, 29);
            label3.TabIndex = 8;
            label3.Text = "Input Code: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 171);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(410, 25);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(180, 29);
            label2.TabIndex = 6;
            label2.Text = "Encoded string: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(406, 29);
            label1.TabIndex = 1;
            label1.Text = "Your string here (40 characters max) ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(410, 25);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(745, -5);
            button5.Name = "button5";
            button5.Size = new Size(10, 598);
            button5.TabIndex = 19;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(11, 77);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(460, 77);
            label8.Name = "label8";
            label8.Size = new Size(0, 18);
            label8.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(820, 20);
            label9.Name = "label9";
            label9.Size = new Size(45, 18);
            label9.TabIndex = 26;
            label9.Text = "label9";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(191, 20);
            label11.Name = "label11";
            label11.Size = new Size(0, 18);
            label11.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(11, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 80);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(12, 80);
            label10.Name = "label10";
            label10.Size = new Size(328, 18);
            label10.TabIndex = 29;
            label10.Text = "❌ String length must be within 1-40 characters!";
            label10.Click += label10_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(12, 98);
            label12.Name = "label12";
            label12.Size = new Size(302, 18);
            label12.TabIndex = 30;
            label12.Text = "❌ Only uppercase characters are acceptable!";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.ForeColor = Color.Blue;
            label13.Location = new Point(12, 118);
            label13.Name = "label13";
            label13.Size = new Size(445, 18);
            label13.TabIndex = 31;
            label13.Text = "ℹ️ N is in interval [-25, 25]";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(460, 41);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(132, 25);
            numericUpDown1.TabIndex = 32;
            numericUpDown1.Minimum = -25;
            numericUpDown1.Maximum = 25;
            numericUpDown1.Increment = 1;
            numericUpDown1.DecimalPlaces = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(745, 549);
            Controls.Add(numericUpDown1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(label5);
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
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button button6;
        private Label label6;
        private Label label4;
        private TextBox textBox6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label12;
        private Label label13;
        private NumericUpDown numericUpDown1;
    }
}
                                      