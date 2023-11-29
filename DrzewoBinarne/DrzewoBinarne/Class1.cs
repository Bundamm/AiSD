using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DrzewoBinarne.Form1;

namespace DrzewoBinarne
{
    public class DrzewoBinarne
    {
        public Węzeł3 korzeń;
        public int liczbaWęzłów;

        public DrzewoBinarne(int liczba)
        {
            this.korzeń = new Węzeł3(liczba);
            this.liczbaWęzłów = 1;
        }

        void Add(int liczba)
        {
            Węzeł3 rodzic = this.znajdzRodzica(liczba);
            rodzic.AddDziecko(liczba);
        }

        public Węzeł3 znajdzRodzica(int liczba)
        {

            var w = this.korzeń;
            while (true)
            {
                if (liczba < w.wartosc)
                {
                    if (w.leweDziecko != null)
                    {
                        w = w.leweDziecko;
                    }
                    else return w;
                }
                else
                {
                    if (w.praweDziecko != null)
                    {
                        w = w.praweDziecko;
                    }
                    else return w;
                }
            }
        }
    }


    public class Węzeł3
    {
        public int wartosc;
        public Węzeł3 leweDziecko;
        public Węzeł3 praweDziecko;
        public Węzeł3 rodzic;
        public Węzeł3(int wartosc)
        {
            this.wartosc = wartosc;
        }

        
        public void Add(int liczba)
        {
            var dziecko = new Węzeł3(liczba);
            dziecko.korzen = this;
            if(liczba < this.wartosc)
            {
                this.leweDziecko = dziecko;
            }
            else 
                this.praweDziecko = dziecko;
        }
    }
}
