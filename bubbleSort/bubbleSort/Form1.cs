namespace bubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            var napis = tbInput.Text;
            int[] tab = convertInt(napis);
            int[] sorted = bubbleSort(tab);
            string wyn = convertString(sorted);
            MessageBox.Show(wyn);
        }

        int[] convertInt(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            int[] liczby = new int[liczbyS.Length];
            for(int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]); 
            }
            return liczby;                                                            

        }
        int[] bubbleSort(int[] tab)
        {
            int temp = tab[0];
            bool czyZamiana = false;

            do
            {
                czyZamiana = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        czyZamiana = true;
                        temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                    }
                }
            } while (czyZamiana == true);

            // wersja z dwoma pêtlami to takie bruteforce
            //funkcje u¿yæ drugi raz
            //jak zrobimy b³¹d to trzeba tylko w funkcji poprawiæ 

            return tab;
        }

        string convertString(int[] tab)
        {
            string wynik = "";
            for (int i = 0; i < tab.Length; i++)
            {

                wynik += tab[i].ToString() + ", ";
            }
            return wynik;
        }

        private void lblWynik_Click(object sender, EventArgs e)
        {

        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}