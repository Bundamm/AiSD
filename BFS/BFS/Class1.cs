using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class Wezel3
    {
        public int wartosc;
        public List<Wezel3> sasiad = new List<Wezel3>();

        public Wezel3(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public bool Add(Wezel3 s)
        {
            if (this == s) return false;
            bool wynik = false;
            if(!this.sasiad.Contains(s))
            {
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
