namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String CalTotal;
        int num1;
        int num2;
        String option;
        int result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(Display.Text);
            Display.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(Display.Text);
            Display.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(Display.Text);
            Display.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(Display.Text);
            Display.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(Display.Text);

            if (option == "+")
                result = num1 + num2;

            if (option == "-")
                result = num1 - num2;

            if (option == "*")
                result = num1 * num2;

            if (option == "/")
                result = num1 / num2;

            Display.Text = result + "";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Display.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
