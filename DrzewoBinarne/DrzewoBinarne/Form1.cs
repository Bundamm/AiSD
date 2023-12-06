namespace DrzewoBinarne
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void start_Click(object sender, EventArgs e)
		{
			var w1 = new Wezel3(5);
			var drzewo = new drzewoBinarne(w1);
			drzewo.Add(4);
			drzewo.Add(10);
			drzewo.Add(3);
			drzewo.Add(4);
			drzewo.Add(5);
			drzewo.Add(3);
			drzewo.Add(8);
			drzewo.Add(11);
			var x = drzewo.Nastepnik(drzewo.korzen.leweDziecko.praweDziecko);
			var y = drzewo.Poprzednik(drzewo.korzen.praweDziecko);
		}
		int[] convertInt(string napis)
		{
			var liczbyS = napis.Trim().Split(' ');
			int[] liczby = new int[liczbyS.Length];
			for (int i = 0; i < liczbyS.Length; i++)
			{
				liczby[i] = int.Parse(liczbyS[i]);
			}
			return liczby;
		}

		private void button1_Click(object sender, EventArgs e) { 


			var w1 = new Wezel3(5);
			var d = new drzewoBinarne(w1);
			d.Add(4);
			d.Add(3);
			d.Add(8);
			d.Add(7);
			d.Add(9);
			d.Add(2);
			d.Add(2);

			var w = d.ZnajdzNajmniejszy(d.korzen);
			while (w != null)
				w = d.Nastepnik(w);

		}

		private void start_Click_1(object sender, EventArgs e)
		{

		}
	}
}