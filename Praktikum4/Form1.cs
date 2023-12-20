namespace Praktikum4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox1.Text);
            int result = 1;
            label2.Text = value.ToString() + "! = ";
            for(int i = 1; i < value; i++)
            {
                result = result * i;
                label2.Text += i.ToString() + " * ";
            }
            result = result * value;
            label2.Text += value + " = " + result.ToString();
        }
    }
}
