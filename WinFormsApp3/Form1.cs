namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void form1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, res;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            res = num1 + num2;
            textBox3.Text = res.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, res;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            res = num1 - num2;
            textBox3.Text = res.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, res;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            res = num1 / num2;
            textBox3.Text = res.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double num1, num2, res;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            res = num1 * num2;
            textBox3.Text = res.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
