using System.Data;
using Part1.classes;

namespace Part1
{
    public partial class Form1 : Form
    {
        private DBConnector dBConnector;
        public Form1()
        {
            InitializeComponent();
            Text = "String Processor"; //change window's name (title)
            dBConnector = new DBConnector();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the data from database
            DataTable dt = dBConnector.GetAllRecords();

            // Clear existing columns
            dataGridView1.Columns.Clear();

            // Configure the specific columns we want to show
            dataGridView1.AutoGenerateColumns = false;

            // Add and configure the DateTime column with specific sizing
            DataGridViewTextBoxColumn datetimeColumn = new()
            {
                Name = "datetime",
                HeaderText = "Date Time",
                DataPropertyName = "datetime",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, // makes the column fit it's content
                MinimumWidth = 125  //width of column
            };
            dataGridView1.Columns.Add(datetimeColumn);

            // Add other columns
            dataGridView1.Columns.Add("inputString", "Input String");
            dataGridView1.Columns["inputString"].DataPropertyName = "inputString";

            // Add and configure the Encode Value column with specific sizing
            DataGridViewTextBoxColumn encodeValueColumn = new()
            {
                Name = "encodeValue",
                HeaderText = "Encode Value",
                DataPropertyName = "encodeValue",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            };
            dataGridView1.Columns.Add(encodeValueColumn);

            // Set the data source
            dataGridView1.DataSource = dt;

            // Adjust columns after data is loaded
            dataGridView1.Columns["datetime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Prevent users from resizing the columns
            dataGridView1.Columns["datetime"].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns["encodeValue"].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns["inputString"].Resizable = DataGridViewTriState.False;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label5.Text = $"Character count: {textBox1.Text.Length}";  //display character count
            bool enableButton1 = false;
            bool enableButton2 = false;
            Validator.S = textBox1.Text;


            if (Validator.errorList[0][0] == '✅')
            {
                label10.ForeColor = Color.Green;
                label10.Text = Validator.errorList[0];
                enableButton1 = true;
            }
            else
            {
                label10.ForeColor = Color.Red;
                label10.Text = Validator.errorList[0];
                enableButton1 = false;
            }

            if (Validator.errorList[1][0] == '✅')
            {
                label12.ForeColor = Color.Green;
                label12.Text = Validator.errorList[1];
                enableButton2 = true;
            }
            else
            {
                label12.ForeColor = Color.Red;
                label12.Text = Validator.errorList[1];
                enableButton2 = false;
            }
            if (enableButton1 && enableButton2)
            {
                button6.Enabled = true;
            }
            else
            {
                button6.Enabled = false;
            }
        }//textbox1_TextChanged

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            //console 1st line
        }

        private void label12_Click(object sender, EventArgs e)
        {
            //console 2nd line
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = $"{StringProcess.Encode(textBox1.Text, Convert.ToInt16(numericUpDown1.Value))}";

            int[] inputCode;
            inputCode = (int[])StringProcess.AsciiCode(textBox1.Text);
            foreach (int num in inputCode)
            {
                textBox3.Text += num;
            }

            int[] outputCode;
            outputCode = (int[])StringProcess.AsciiCode(textBox2.Text);
            foreach (int num in outputCode)
            {
                textBox4.Text += num;
            }

            textBox5.Text = StringProcess.Sort(textBox1.Text);

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            // Insert the new record
            dBConnector.Insert(textBox1.Text, Convert.ToInt16(numericUpDown1.Value), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

            // Refresh the DataGridView with updated data
            DataTable dt = dBConnector.GetAllRecords();
            dataGridView1.DataSource = dt;

            // Re-apply the column sizing for datetime
            dataGridView1.Columns["datetime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["datetime"].Resizable = DataGridViewTriState.False;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox4.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox5.Text);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}






