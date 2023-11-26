using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Wezel2
    {
        public int wartosc;
        public List<Wezel2> sasiad = new List<Wezel2>();

        public Wezel2(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public bool Add(Wezel2 s)
        {
            if (this == s) return false;
            bool wynik = false;
            if (!this.sasiad.Contains(s)) { 
                this.sasiad.Add(s);
                wynik = true;
            }
            if (!s.sasiad.Contains(s))
            {
                s.sasiad.Add(this);
                wynik = true;
            }
            return wynik;
        }
    }
}
