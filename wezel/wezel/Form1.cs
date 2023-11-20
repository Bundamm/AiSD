namespace wezel
{
    public partial class Form1 : Form
    {
        string napis = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel(5);

            var w2 = new Wezel(3);
            var w3 = new Wezel(1);
            var w4 = new Wezel(2);
            var w5 = new Wezel(4);
            var w6 = new Wezel(6);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);
            A(w1);
            MessageBox.Show(napis);
            napis = "";
        }
        void A(Wezel w)
        {

            napis += " " + w.wartosc.ToString();
            for (int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }

        }
    }


}