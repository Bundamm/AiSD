using System.Windows.Forms.VisualStyles;

namespace NWP
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
            string s1 = "0abaabbaaa";
            string s2 = "0babab";
            int n = s1.Length;
            int m = s2.Length;
            int[,] tab = new int[n, m];
            for (int i = 1; i < tab.GetLength(0); i++)
            {
                for (int j = 1; j < tab.GetLength(1); j++)
                {
                    if (s1[i] == s2[j])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;

                    }
                    else
                    {
                        tab[i, j] = Math.Max(tab[i - 1, j], tab[i, j - 1]);
                    }
                }
            }


            string wynik = "";

            int a = n - 1;
            int b = m - 1;

            while (true)
            {
                if(a == 0 || b == 0)
                {
                    break;
                }
                
                int x = tab[a, b];
                if (x == tab[a, b-1])
                {
                    x = tab[a, b-1];
                    b = b - 1;
                    
                }
                else if (x == tab[a-1, b])
                {
                    x = tab[a-1, b];
                    a = a - 1;
                    
                }
                else
                {
                    
                    x = tab[a - 1, b - 1];
                    a = a - 1;
                    b = b - 1;
                    wynik = s1[a] + wynik;
                }
            }

            MessageBox.Show(wynik);
        }
    }
}