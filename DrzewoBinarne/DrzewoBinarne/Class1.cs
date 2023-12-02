using System;
using System.Collections.Generic;
using System.Linq;
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

		public void Add(int liczba)
		{
			if(korzen == null)
			{
				korzen = new Wezel3(liczba);
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
		public Wezel3 znajdzNajmniejszy(Wezel3 b)
		{
			var w = b;
			while (w.leweDziecko != null)
			{
				w = w.leweDziecko;
			}
			return w;
		}
		public Wezel3 znajdzNajwiekszy(Wezel3 b)
		{
			var w = b;
			while (w.praweDziecko != null)
			{
				w = w.praweDziecko;
			}
			return w;
		}
		public Wezel3 znajdz(int liczba)
		{
			var w = this.korzen;
			if (w.wartosc == liczba) return w;
			while (true)
			{
				if(liczba < w.wartosc)
				{
					if (w.leweDziecko != null)
					{
						w = w.leweDziecko;
						if (w.wartosc == liczba)
						{
							return w;
						}
					}
					else
					{
						return null;
					}
				}
				else
				{
					if(w.praweDziecko != null)
					{
						w = w.praweDziecko;
						if(w.wartosc == liczba)
						{
							return w;
						}
						
					}
					else
					{
						return null;
					}
				}
			}
		}
		public Wezel3 nastepnik(Wezel3 w)
		{
			if(w.praweDziecko != null)
			{
				return znajdzNajmniejszy(w.praweDziecko);
			}
			if (w.rodzic == null) return null;

			while(w == w.rodzic.praweDziecko)
			{
				w = w.rodzic;
				if (w.rodzic == null) return null;
			}
			return w.rodzic;
		}
		public Wezel3 poprzednik(Wezel3 w)
		{
			if(w.leweDziecko != null)
			{
				return znajdzNajwiekszy(w.leweDziecko);
			}
			if (w.rodzic == null) return null;
			while(w == w.rodzic.leweDziecko)
			{
				w = w.rodzic;
				if (w.rodzic == null) return null;
			}
			return w.rodzic;
		}
	}
}
