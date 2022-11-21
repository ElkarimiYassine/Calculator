namespace calculette
{
    public partial class Form1 : Form
    {
        private decimal x = 0.0m;
        private decimal y = 0.0m;
        private decimal r = 0.0m;
        private string op = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = 0.0m;
            y = 0.0m;
            textBox.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = decimal.Parse(textBox.Text);
            textBox.Clear();
            op = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = decimal.Parse(textBox.Text);
            textBox.Clear();
            op = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = decimal.Parse(textBox.Text);
            textBox.Clear();
            op = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            x = decimal.Parse(textBox.Text);
            textBox.Clear();
            op = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (op) { 
                case "-":
                y = decimal.Parse(textBox.Text);
                r = x - y;
                textBox.Text = r.ToString();
                break;
            case "+":
                y = decimal.Parse(textBox.Text);
                r = x + y;
                textBox.Text = r.ToString();
                break;
            case "*":
                y = decimal.Parse(textBox.Text);
                r = x * y;
                textBox.Text = r.ToString();
                break;
            case "/":
                y = decimal.Parse(textBox.Text);
                r = x / y;
                textBox.Text = r.ToString();
                break;
            }
        }
        }
    }
