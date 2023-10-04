namespace aisd_cw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int wyn = fib((int)nudLiczbaN.Value);
            MessageBox.Show(wyn.ToString());
        }
        int fib(int n)
        {
            if (n == 1) return 1;
            if (n == 0) return 0;
            return fib(n - 1) + fib(n - 2);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
