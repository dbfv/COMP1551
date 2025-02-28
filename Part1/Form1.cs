namespace Part1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.Text = "I like yo cut G"; //change window's name (title)

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            label5.Text = $"Character count: {textBox1.Text.Length}";  //display character count
            bool enableButton1 = false;
            bool enableButton2 = false;
            Validator.ValidateString(textBox1.Text, label5);

            if (Validator.errorList[0] == "String length is within 1-40 characters.") {
                label10.ForeColor = Color.Green;
                label10.Text = "✅ " + Validator.errorList[0];
                enableButton1 = true;
            }
            else {
                label10.ForeColor = Color.Red;
                label10.Text = "❌ " + Validator.errorList[0];
                enableButton1 = false;
            }

            if (Validator.errorList[1] == "All characters are uppercase letters!") {
                label12.ForeColor = Color.Green;
                label12.Text = "✅ " + Validator.errorList[1];
                enableButton2 = true;
            }
            else {
                label12.ForeColor = Color.Red;
                label12.Text = "❌ " + Validator.errorList[1];
                enableButton2 = false;
            }
            if (enableButton1 && enableButton2) {
                button6.Enabled = true;
            }
            else {
                button6.Enabled = false;
            }
        }//textbox1_TextChanged

        private void button1_Click(object sender, EventArgs e) {
            Clipboard.SetText(textBox2.Text);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e) {

        }

        private void label11_Click(object sender, EventArgs e) {

        }

        private void Form1_Paint(object sender, PaintEventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void pictureBox2_Click(object sender, EventArgs e) {

        }

        private void label13_Click(object sender, EventArgs e) {

        }

        private void label10_Click(object sender, EventArgs e) {
            //console 1st line
        }

        private void label12_Click(object sender, EventArgs e) {
            //console 2nd line
        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void button6_Click(object sender, EventArgs e) {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = $"{Transformer.Encode(textBox1.Text, Convert.ToInt16(numericUpDown1.Value))}";

            int[] inputCode;
            inputCode = (int[])Transformer.AsciiCode(textBox1.Text);
            foreach (int num in inputCode) {
                textBox3.Text += num;
            }

            int[] outputCode;
            outputCode = (int[])Transformer.AsciiCode(textBox2.Text);
            foreach (int num in outputCode) {
                textBox4.Text += num;
            }

            textBox5.Text = Transformer.Sort(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            Clipboard.SetText(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e) {
            Clipboard.SetText(textBox4.Text);
        }

        private void button4_Click(object sender, EventArgs e) {
            Clipboard.SetText(textBox5.Text);
        }
    }
}





