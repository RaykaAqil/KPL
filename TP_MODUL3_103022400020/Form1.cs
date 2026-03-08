namespace TP_MODUL3_103022400020
{
    public partial class Kalkulator : Form
    {
        string input = "";
        int firstNumber = 0;
        bool isPlusClicked = false;

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            textBox1.Text = input;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            textBox1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            textBox1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            textBox1.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            textBox1.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            textBox1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            textBox1.Text = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                firstNumber = int.Parse(input);
                input = "";
                isPlusClicked = true;
                textBox1.Text = "+";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            textBox1.Text = input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isPlusClicked && input != "")
            {
                int secondNumber = int.Parse(input);
                int result = firstNumber + secondNumber;

                textBox1.Text = result.ToString();

                input = result.ToString();
                isPlusClicked = false;
            }
        }
    }
}
