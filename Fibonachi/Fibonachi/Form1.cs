namespace Fibonachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                int x;
                if (n <= 0)
                {
                    MessageBox.Show("اعداد کوچکتر از 1 وارد نکنید");
                    return;
                }
                n = n - 1;
                x = fib(n);
                MessageBox.Show("جمله ی" + textBox1.Text + "ام برابر است با:" + x.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int fib(int n)
        {
            if (n <= 0)
                return n;
            if (n == 1)
                return n;
            else
                return fib(n - 1) + fib(n - 2);
        }
    }
}