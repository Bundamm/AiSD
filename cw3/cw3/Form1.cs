namespace cw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void start_Click(object sender, EventArgs e)
        {
            int[] tab = { 8, 7, 2, 5, 4 };

            string wyn = bubbleSort(tab);
            MessageBox.Show(wyn);
        }

        string bubbleSort(int[] tab)
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
            
            string wynik = "";
            for(int i = 0; i < tab.Length; i++) { 
           
                wynik += tab[i].ToString() + ", ";
            }

            return wynik;
        }

    }
}