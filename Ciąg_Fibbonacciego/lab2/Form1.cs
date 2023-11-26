using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         /*
        private Dictionary<int, int> cache = new Dictionary<int, int>()
        {
            [0] = 0,
            [1] = 1
        };
        */
        private void wciskaj_Click(object sender, EventArgs e)
        {
            long liczba = (long)ln.Value;
            long wyn = fib2(liczba);
            MessageBox.Show(wyn.ToString());
        }
        
        long fib2(long n)
        {
            if (n == 0 || n == 1) return n;
            long[] wyrazy = new long[n+1];
            wyrazy[1] = 1;
            

            for(int i = 2; i < wyrazy.Length; i++)
            {
                wyrazy[i] = wyrazy[i - 1] + wyrazy[i - 2];
            }
            // robimy tutaj jeszcze raz t¹ operacjê bo pêtla siê koñczy przed pi¹tym elementem którego chcemy wyliczyæ i to zwracamy, jeœli nie jest n+1 w new.
            //            return wyrazy[n - 1] + wyrazy[n - 2]
            return wyrazy[n];
        }
        
    }
}