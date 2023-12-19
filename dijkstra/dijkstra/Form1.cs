namespace dijkstra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var w0 = new Wezel4(0);
            var w1 = new Wezel4(1);
            var w2 = new Wezel4(2);
            var w3 = new Wezel4(3);
            var w4 = new Wezel4(4);
            var w5 = new Wezel4(5);
            var d = new Graf(w0);
            d.Add(w0, w1, 3);
            d.Add(w0, w4, 3);
            d.Add(w0, w5, 6);
            d.Add(w1, w2, 1);
            d.Add(w1, w3, 3);
            d.Add(w2, w3, 3);
            d.Add(w2, w5, 7);
            d.Add(w5, w3, 1);
            d.Add(w4, w5, 2);
            d.Dijkstra(w0);
        }
    }
}