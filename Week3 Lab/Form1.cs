namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            double number1;
            bool isNumber1 = double.TryParse(input1, out number1);
            if (isNumber1)
            {
                double storedNumber = number1;
            }
            else
            {

                MessageBox.Show("Please enter a valid number.");

            }
            string input2 = textBox2.Text;
            double number2;
            bool isNumber = double.TryParse(input2, out number2);
            if (isNumber)
            {
                double storedNumber = number2;
            }
            else
            {

                MessageBox.Show("Please enter a valid number.");

            }

            double multi = number1 * number2;
            history.Items.Add(multi);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            double number1;
            bool isNumber1 = double.TryParse(input1, out number1);
            if (isNumber1)
            {
                double storedNumber = number1;
            }
            else
            {

                MessageBox.Show("Please enter a valid number.");

            }
            string input2 = textBox2.Text;
            double number2;
            bool isNumber = double.TryParse(input2, out number2);
            if (isNumber)
            {
                double storedNumber = number2;
            }
            else
            {

                MessageBox.Show("Please enter a valid number.");

            }

            double sum = number1 + number2;
            history.Items.Add(sum);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            double number1;
            bool isNumber1 = double.TryParse(input1, out number1);
            if (isNumber1)
            {
                double storedNumber = number1;
            }
            else
            {

                MessageBox.Show("Please enter a valid number.");

            }
            string input2 = textBox2.Text;
            double number2;
            bool isNumber = double.TryParse(input2, out number2);
            if (isNumber)
            {
                double storedNumber = number2;
            }
            else
            {

                MessageBox.Show("Please enter a valid number.");

            }

            double div = number1 / number2;
            history.Items.Add(div);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            double number1;
            bool isNumber1 = double.TryParse(input1, out number1);
            if (isNumber1)
            {
                double storedNumber = number1;
            }
            else
            {

                MessageBox.Show("Please enter a valid number.");

            }
            string input2 = textBox2.Text;
            double number2;
            bool isNumber = double.TryParse(input2, out number2);
            if (isNumber)
            {
                double storedNumber = number2;
            }
            else
            {

                MessageBox.Show("Please enter a valid number.");

            }

            double sub = number1 - number2;
            history.Items.Add(sub);
        }
    }

}