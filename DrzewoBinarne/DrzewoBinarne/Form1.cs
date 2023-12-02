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
			var x = drzewo.nastepnik(drzewo.korzen.praweDziecko.leweDziecko.praweDziecko);
			var y = drzewo.poprzednik(drzewo.korzen.praweDziecko);
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
	}
}