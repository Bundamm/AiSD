namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string napis = "";
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
        }
        void depth(Wezel2 s)
        {

            napis += " " + s.wartosc.ToString();
            
            do
            {
                for (int i = 0; i < w.dzieci.Count; i++)
                {
                    depth(s.sasiad[i]);
                }
            } while(v)


        }
    }
}