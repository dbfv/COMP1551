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
        private void InitializeComponent()
        {
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
            button4 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(18, 128);
            label5.Name = "label5";
            label5.Size = new Size(76, 14);
            label5.TabIndex = 17;
            label5.Text = "Word count: 0";
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Enabled = false;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(572, 12);
            button6.Name = "button6";
            button6.Size = new Size(83, 49);
            button6.TabIndex = 2;
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
            label6.Location = new Point(489, 7);
            label6.Name = "label6";
            label6.Size = new Size(39, 26);
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
            label4.Location = new Point(18, 257);
            label4.Name = "label4";
            label4.Size = new Size(133, 26);
            label4.TabIndex = 10;
            label4.Text = "Output Code: ";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(572, 263);
            button3.Name = "button3";
            button3.Size = new Size(83, 24);
            button3.TabIndex = 4;
            button3.Text = "Copy!";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(572, 209);
            button2.Name = "button2";
            button2.Size = new Size(83, 24);
            button2.TabIndex = 3;
            button2.Text = "Copy!";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(572, 162);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 2;
            button1.Text = "Copy!";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox4.Location = new Point(193, 263);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(359, 23);
            textBox4.TabIndex = 35;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox3.Location = new Point(193, 209);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(359, 23);
            textBox3.TabIndex = 36;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(18, 204);
            label3.Name = "label3";
            label3.Size = new Size(120, 26);
            label3.TabIndex = 37;
            label3.Text = "Input Code: ";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox2.Location = new Point(193, 162);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(359, 23);
            textBox2.TabIndex = 38;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(18, 156);
            label2.Name = "label2";
            label2.Size = new Size(158, 26);
            label2.TabIndex = 39;
            label2.Text = "Encoded String: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(18, 8);
            label1.Name = "label1";
            label1.Size = new Size(169, 26);
            label1.TabIndex = 1;
            label1.Text = "Your String Here:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox1.Location = new Point(18, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(18, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(534, 76);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(18, 76);
            label10.Name = "label10";
            label10.Size = new Size(254, 14);
            label10.TabIndex = 29;
            label10.Text = "❎ String length must be within 1-40 characters!";
            label10.Click += label10_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(18, 93);
            label12.Name = "label12";
            label12.Size = new Size(238, 14);
            label12.TabIndex = 30;
            label12.Text = "❎ Only uppercase characters are acceptable!";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.ForeColor = Color.Blue;
            label13.Location = new Point(18, 111);
            label13.Name = "label13";
            label13.Size = new Size(150, 14);
            label13.TabIndex = 31;
            label13.Text = "ℹ️ N is in interval [-25, 25]";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            numericUpDown1.Location = new Point(489, 35);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 25, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(63, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.Cyan;
            label7.Location = new Point(18, 316);
            label7.Name = "label7";
            label7.Size = new Size(118, 26);
            label7.TabIndex = 33;
            label7.Text = "Input Sort: ";
            label7.Click += label7_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox5.Location = new Point(193, 321);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(359, 23);
            textBox5.TabIndex = 34;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(572, 322);
            button4.Name = "button4";
            button4.Size = new Size(83, 24);
            button4.TabIndex = 5;
            button4.Text = "Copy!";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-5, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(685, 430);
            tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.pexels_eberhardgross_1287142;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(677, 400);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.Screenshot_2024_07_12_144218;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(677, 400);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 44);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(371, 317);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 14F);
            label8.ForeColor = Color.Cyan;
            label8.Location = new Point(18, 8);
            label8.Name = "label8";
            label8.Size = new Size(227, 26);
            label8.TabIndex = 2;
            label8.Text = "Your Converting History:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(674, 422);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Button button6;
        private Label label6;
        private Label label4;
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
        private PictureBox pictureBox1;
        private Label label10;
        private Label label12;
        private Label label13;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private TextBox textBox5;
        private Button button4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label8;
        private DataGridView dataGridView1;
    }
}
                                      