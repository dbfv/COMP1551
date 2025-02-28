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
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(10, 121);
            label5.Name = "label5";
            label5.Size = new Size(89, 16);
            label5.TabIndex = 17;
            label5.Text = "Word count: 0";
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Enabled = false;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(564, 11);
            button6.Name = "button6";
            button6.Size = new Size(83, 53);
            button6.TabIndex = 22;
            button6.Text = "PRINT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = Color.Cyan;
            label6.Location = new Point(481, 6);
            label6.Name = "label6";
            label6.Size = new Size(43, 27);
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
            label4.Location = new Point(10, 242);
            label4.Name = "label4";
            label4.Size = new Size(143, 27);
            label4.TabIndex = 10;
            label4.Text = "Output Code: ";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(564, 247);
            button3.Name = "button3";
            button3.Size = new Size(83, 22);
            button3.TabIndex = 14;
            button3.Text = "Copy!";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(564, 197);
            button2.Name = "button2";
            button2.Size = new Size(83, 22);
            button2.TabIndex = 13;
            button2.Text = "Copy!";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(564, 152);
            button1.Name = "button1";
            button1.Size = new Size(83, 22);
            button1.TabIndex = 12;
            button1.Text = "Copy!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(185, 247);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(359, 23);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(185, 197);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(359, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(10, 192);
            label3.Name = "label3";
            label3.Size = new Size(129, 27);
            label3.TabIndex = 8;
            label3.Text = "Input Code: ";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(185, 152);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(359, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(10, 147);
            label2.Name = "label2";
            label2.Size = new Size(163, 27);
            label2.TabIndex = 6;
            label2.Text = "Encoded string: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(369, 27);
            label1.TabIndex = 1;
            label1.Text = "Your string here (40 characters max) ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(10, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(534, 71);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(10, 71);
            label10.Name = "label10";
            label10.Size = new Size(296, 16);
            label10.TabIndex = 29;
            label10.Text = "❌ String length must be within 1-40 characters!";
            label10.Click += label10_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(10, 87);
            label12.Name = "label12";
            label12.Size = new Size(281, 16);
            label12.TabIndex = 30;
            label12.Text = "❌ Only uppercase characters are acceptable!";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.ForeColor = Color.Blue;
            label13.Location = new Point(10, 105);
            label13.Name = "label13";
            label13.Size = new Size(176, 16);
            label13.TabIndex = 31;
            label13.Text = "ℹ️ N is in interval [-25, 25]";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(481, 36);
            numericUpDown1.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 25, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(63, 23);
            numericUpDown1.TabIndex = 32;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.Cyan;
            label7.Location = new Point(10, 298);
            label7.Name = "label7";
            label7.Size = new Size(126, 27);
            label7.TabIndex = 33;
            label7.Text = "Input Sort: ";
            label7.Click += label7_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(185, 302);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(359, 23);
            textBox5.TabIndex = 34;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(652, 488);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(label5);
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
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label12;
        private Label label13;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private TextBox textBox5;
    }
}
                                      