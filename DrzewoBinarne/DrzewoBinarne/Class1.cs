using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static DrzewoBinarne.Form1;

namespace DrzewoBinarne
{
	public class Wezel3
	{
		public int wartosc;
		public Wezel3 rodzic;
		public Wezel3 leweDziecko;
		public Wezel3 praweDziecko;
		public Wezel3(int liczba)
		{
			this.wartosc = liczba;
		}
		public void Add(int liczba)
		{
			var dziecko = new Wezel3(liczba);
			dziecko.rodzic = this;
			if (liczba < this.wartosc)
			{
				this.leweDziecko = dziecko;
			}
			else
			{
				this.praweDziecko = dziecko;
			}
		}
	}
	public class drzewoBinarne
	{
		public Wezel3 korzen;
		public int liczbaWezlow = 0;
		public drzewoBinarne(Wezel3 korzen)
		{
			this.korzen = korzen;

		}
		public override string ToString()
		{
			return this.korzen.ToString();
		}

		public void Add(int liczba)
		{
			if(this.korzen == null)
			{
				this.korzen = new Wezel3(liczba);
				return;
			}
			var rodzic = this.znajdzRodzica(liczba);
			rodzic.Add(liczba);
			liczbaWezlow++;
		}
		public Wezel3 znajdzRodzica(int liczba)
		{
			var w = this.korzen;
			while (true)
			{
				if (liczba < w.wartosc)
				{
					if (w.leweDziecko != null)
					{
						w = w.leweDziecko;
					}
					else
					{
						return w;
					}
				}
				else
				{
					if (w.praweDziecko != null)
					{
						w = w.praweDziecko;
					}
					else
					{
						return w;
					}
				}
			}
		}
		public Wezel3 ZnajdzNajmniejszy(Wezel3 b)
		{
			while (b.leweDziecko != null) 
				b = b.leweDziecko;
			return b;
		}
		public Wezel3 ZnajdzNajwiekszy(Wezel3 b)
		{
			while (b.praweDziecko != null)
				b = b.praweDziecko;

			return b;
		}
		public Wezel3 Znajdz(int liczba)
		{
			var w = this.korzen;
			
			while (true)
			{
				if (w.wartosc == liczba) 
					return w;
				if (liczba < w.wartosc)
				{
					if (w.leweDziecko != null) 
						w = w.leweDziecko;
					else 
						return null;
				}
				else
				{
					if(w.praweDziecko != null) 
						w = w.praweDziecko;
					else 
						return null;
				}
			}
		}
		public Wezel3 Nastepnik(Wezel3 w)
		{
			if(w.praweDziecko != null)
			{
				return this.ZnajdzNajmniejszy(w.praweDziecko);
			}			
			while(w.rodzic != null)
			{
                if (w.rodzic.leweDziecko == w)
				{
                    return w.rodzic;
                }
                w = w.rodzic;
			}
			return null;

		}

		public Wezel3 Poprzednik(Wezel3 w)
		{
            if (w.leweDziecko != null)
            {
                return this.ZnajdzNajwiekszy(w.praweDziecko);
            }
            while (w.rodzic != null)
            {
                if (w.rodzic.praweDziecko == w)
                {
                    return w.rodzic;
                }
                w = w.rodzic;
            }
            return null;
        }

		//public Wezel3 Usun(Wezel3 w)
		//{
			//gdy nie ma dzieci, to odwiazujemy wezel
			//gdy jest jedno dziecko to wchodzi na miejsce rodzica
			//gdy jest dwoje dzieci, używam losowo następnika bądź poprzednika o boże
		//}
	}
}
