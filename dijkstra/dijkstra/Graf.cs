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
        public int iloscKrawedzi;
        public Wezel4(int wartosc)
        {
            this.wartosc = wartosc;
            this.iloscKrawedzi = 0;
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
            poczatek.iloscKrawedzi++;
        }
    }
    
    public class Graf
    {
        public List<Wezel4> wezly = new List<Wezel4>();
        public List<Krawedz> krawedzie = new List<Krawedz>();
        public Graf(Wezel4 w)
        {
            wezly.Add(w);
        }
        public void Add(Wezel4 w, Wezel4 k, int waga)
        {
            if(!wezly.Contains(w))
            {
                wezly.Add(w);
            }
            if(!wezly.Contains(k))
            {
                wezly.Add(k);
            }
            var temp = new Krawedz(waga, w, k);
            if (!krawedzie.Contains(temp))
            {
                krawedzie.Add(temp);
            }
        }

        public void Dijkstra(Wezel4 start)
        {
            List<int> odleglosci = new List<int>(wezly.Count);
            List<Wezel4> poprzednicy = new List<Wezel4>(wezly.Count);
            List<Wezel4> nieodwiedzone = new List<Wezel4>(wezly);

            foreach(var w in wezly)
            {
                odleglosci.Add(int.MaxValue);
                poprzednicy.Add(null);
            }
            odleglosci[wezly.IndexOf(start)] = 0;
            
            while(nieodwiedzone.Count > 0)
            {
                Wezel4 aktualny = null;
                foreach(var w in nieodwiedzone)
                {
                    if(aktualny == null || odleglosci[wezly.IndexOf(w)] < odleglosci[wezly.IndexOf(aktualny)])
                    {
                        aktualny = w;
                    }
                }
                nieodwiedzone.Remove(aktualny);
                foreach (var krawedz in krawedzie)
                {
                    int nowaOdleglosc = odleglosci[wezly.IndexOf(aktualny)] + krawedz.waga;
                    if(nowaOdleglosc < odleglosci[wezly.IndexOf(krawedz.koniec)])
                    {
                        odleglosci[wezly.IndexOf(krawedz.koniec)] = nowaOdleglosc;
                        poprzednicy[wezly.IndexOf(krawedz.koniec)] = aktualny;
                    }
                }
            }
            

        }


    }
    
}
