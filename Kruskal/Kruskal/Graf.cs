using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kruskal
{
    public class Wezel5
    {
        public int wartosc;
        //public List<Krawedz> ListaWychodzacychKrawedzi = new List<Krawedz>();
        public Wezel5(int wartosc)
        {
            this.wartosc = wartosc;
        }
    }
    public class Krawedz
    {
        public int waga;
        public Wezel5 poczatek;
        public Wezel5 koniec;
        public Krawedz(int waga, Wezel5 poczatek, Wezel5 koniec)
        {
            this.waga = waga;
            this.poczatek = poczatek;
            this.koniec = koniec;
        }
    }
    public class Graf
    {
        public int IloscWierzcholkow
        {
            get { return this.listaWierzcholkow.Count; }
        }
        public List<Krawedz> listaKrawedzi = new List<Krawedz>();
        public List<Wezel5> listaWierzcholkow = new List<Wezel5>();
        public Graf(Krawedz krawedz)
        {

            this.listaKrawedzi.Add(krawedz);
            this.listaWierzcholkow.Add(krawedz.poczatek);
            this.listaWierzcholkow.Add(krawedz.koniec);
        }
        public void Add(Krawedz k)
        {
            if (!listaKrawedzi.Contains(k))
            {
                listaKrawedzi.Add(k);
            }

            if (!listaWierzcholkow.Contains(k.poczatek))
            {
                listaWierzcholkow.Add(k.poczatek);
            }

            if (!listaWierzcholkow.Contains(k.koniec))
            {
                listaWierzcholkow.Add(k.koniec);
            }
        }
        public int Sprawdz(Krawedz k)
        {
            int sytuacja = 0;
            if (!listaWierzcholkow.Contains(k.poczatek))
            {
                sytuacja++;
            }
            if (!listaWierzcholkow.Contains(k.koniec))
            {
                sytuacja++;
            }
            return sytuacja;
        }
        public Graf Kruskal()
        {
            var wynik = this.listaKrawedzi.OrderBy(k => k.waga);

        }
    }
   
}
