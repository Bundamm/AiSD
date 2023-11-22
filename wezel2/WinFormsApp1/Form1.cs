namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string napis = "";
        List<Wezel2> odwiedzone = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel2(1);
            var w2 = new Wezel2(2);
            var w3 = new Wezel2(3);
            var w4 = new Wezel2(4);
            var w5 = new Wezel2(5);
            var w6 = new Wezel2(6);

            w1.Add(w2);
            w1.Add(w3);
            w2.Add(w4);
            w2.Add(w6);
            w3.Add(w4);
            w4.Add(w5);
            napis = "";
            // Odwiedzone te¿ trzeba czyœciæ
            odwiedzone.Clear();
            depth(w1);
            MessageBox.Show(napis);
        }
        void depth(Wezel2 s)
        {

            odwiedzone.Add(s);

            napis += s.wartosc.ToString() + " ";

            foreach (var sasiad in s.sasiad)
            {
                if (!odwiedzone.Contains(sasiad))
                {
                    depth(sasiad);
                }
            }

            /*
           // Queue<Wezel2> kolejka = new Queue<Wezel2>();
            List<Wezel2> usuniete = new List<Wezel2>();

            usuniete.Add(s);
           // kolejka.Enqueue(s);
            while(kolejka.Count > 0)
            {

                //Wezel2 aktualny = kolejka.Dequeue();
                napis += " " + aktualny.wartosc;
                foreach (var sasiad in aktualny.sasiad)
                {
                    if (!usuniete.Contains(sasiad))
                    {
                       // kolejka.Enqueue(sasiad);
                        usuniete.Add(sasiad);
                    }
                    
                }
            }
            */
            /*
            List<Wezel2> stos = new List<Wezel2>();
            List<Wezel2> usuniete = new List<Wezel2>();
            stos.Add(s);
            while(stos.Count > 0)
            {
                Wezel2 aktualny = stos[stos.Count -1];
                stos.RemoveAt(stos.Count - 1);
                
                if (!usuniete.Contains(aktualny))
                {
                    napis += " " + aktualny.wartosc;
                    usuniete.Add(aktualny);
                    foreach(var sasiad in aktualny.sasiad)
                    {
                        if (!usuniete.Contains(sasiad))
                        {
                            stos.Add(sasiad);
                        }
                    }
                }
                
   
            }
            */

        }
    }
}