using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dijkstra
{
    public class Wezel4
    {
        public int wartosc;
        public List<Krawedz> ListaKrawedzi = new List<Krawedz>();
        public Wezel4(int wartosc)
        {
            this.wartosc = wartosc;
        }
    }
    public class Krawedz
    {
        public int waga;
        public Wezel4 poczatek;
        public Wezel4 koniec;

        public Krawedz(int waga, Wezel4 poczatek, Wezel4 koniec)
        {
            this.waga = waga;
            this.poczatek = poczatek;
            this.koniec = koniec;

        }
    }
    // var x = this.listaWezlow.ToList(); kopiowanie listy

    public class Element
    {
        public int dystans;
        public Wezel4 poprzednik;
        public Element(int dystans, Wezel4 poprzednik)
        {
            this.dystans = dystans;
            this.poprzednik = poprzednik;
        }
    }

    public class Graf
    {
        public List<Wezel4> Q = new List<Wezel4>();
        public List<Krawedz> krawedzie = new List<Krawedz>();
        public Graf(Wezel4 w)
        {
            Q.Add(w);
        }
        public void Add(Wezel4 w, Wezel4 k, int waga)
        {
            if(!Q.Contains(w))
            {
                Q.Add(w);
            }
            if(!Q.Contains(k))
            {
                Q.Add(k);
            }
            var temp = new Krawedz(waga, w, k);
            if (!krawedzie.Contains(temp))
            {
                krawedzie.Add(temp);
            }
        }


        public Wezel4 ZnajdzMin(Dictionary<Wezel4> tabelka, List<Wezel4> Q)
        {

        }

        public void Dijkstra(Wezel4 start)
        {
            List<int> odleglosci = new List<int>(wezly.Count);
            List<Wezel4> poprzednicy = new List<Wezel4>(wezly.Count);
            
            odleglosci[wezly.IndexOf(start)] = 0;
            poprzednicy[wezly.IndexOf(start)] = null;
            foreach (var w in wezly)
            {
                odleglosci[wezly.IndexOf(w)] = int.MaxValue;
                poprzednicy[wezly.IndexOf(w)] = null;
            }
            
            
            
            

        }


    }
    
}
