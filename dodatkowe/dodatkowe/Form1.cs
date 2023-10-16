using System.ComponentModel.DataAnnotations;

namespace dodatkowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            int a1 = (int)a.Value;
            int b2 = (int)b.Value;
            string wyn = sumak(a1, b2);
            MessageBox.Show(wyn);
        }

        string sumak(int a, int b)
        {
            string aa = a.ToString();
            string bb = b.ToString();
            int maxLen = Math.Max(aa.Length, bb.Length);
            int next = 0;
            int cyfra1 = 0;
            int cyfra2 = 0;
            string wynik = "";
            for(int i = 0; i< maxLen; i++)
            {
                if (i < aa.Length)
                {
                    cyfra1 = aa[aa.Length - 1 - i] - '0';
                }
                else cyfra1 = 0;
                if (i < bb.Length)
                {
                    cyfra2 = bb[bb.Length - 1 - i] - '0';
                }
                else cyfra2 = 0;
                int suma = cyfra1 + cyfra2 + next;
                
                wynik = (suma % 10) + wynik;
                if(next > 0)
                {
                    wynik = next + wynik;
                }

            }
            return wynik;

            /*
            string liczba1 = a.ToString();
            string liczba2 = b.ToString();
            int maxLength = Math.Max(liczba1.Length, liczba2.Length);
            int carry = 0;
            string wynik = "";

            for (int i = 0; i < maxLength; i++)
            {
                int cyfra1 = i < liczba1.Length ? liczba1[liczba1.Length - 1 - i] - '0' : 0;
                int cyfra2 = i < liczba2.Length ? liczba2[liczba2.Length - 1 - i] - '0' : 0;
                int suma = cyfra1 + cyfra2 + carry;
                carry = suma / 10;
                wynik = (suma % 10) + wynik;
            }

            if (carry > 0)
            {
                wynik = carry + wynik;
            }

            return wynik;
            */
        }

    }
}