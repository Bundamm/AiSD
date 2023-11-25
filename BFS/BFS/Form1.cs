namespace BFS
{
    public partial class Form1 : Form
    {
        string napis = "";
        List<Wezel3> odwiedzone = new();
        Queue<Wezel3> queue = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel3(1);
            var w2 = new Wezel3(3);
            var w3 = new Wezel3(8);
            var w4 = new Wezel3(4);
            var w5 = new Wezel3(6);

            w1.Add(w2);
            w1.Add(w3);
            w2.Add(w4);
            w2.Add(w5);
            w3.Add(w5);
            odwiedzone.Clear();
            queue.Clear();
            BFS3(w1);
            MessageBox.Show(napis);
        }

        void BFS(Wezel3 wez)
        {
            if (!odwiedzone.Contains(wez))
            {
                napis += wez.wartosc.ToString() + " ";
                odwiedzone.Add(wez);
                queue.Enqueue(wez);
            }
            while (queue.Count > 0)
            {
                var s = queue.Dequeue();
                foreach (var sasiad in s.sasiad)
                {
                    if (!odwiedzone.Contains(sasiad))
                    {
                        queue.Enqueue(sasiad);
                    }

                }
                if(queue.Count > 0)
                {
                    var x = queue.Peek();
                    BFS(x);
                }
            }
        }

        void BFS2(Wezel3 wez)
        {
            odwiedzone.Add(wez);
            queue.Enqueue(wez);
            while(queue.Count > 0)
            {
                var s = queue.Dequeue();
                foreach(var sasiad in s.sasiad)
                {
                    if (!odwiedzone.Contains(sasiad))
                    {
                        queue.Enqueue(sasiad);
                    }
                }
                if(queue.Count > 0)
                {
                    napis += s.wartosc.ToString() + " ";
                    odwiedzone.Add(queue.Peek());
                    s = queue.Peek();
                }
            }
        }

        void BFS3(Wezel3 wez)
        {
            napis += wez.wartosc + " ";
            odwiedzone.Add(wez);
            foreach (var s in wez.sasiad)
            {
                queue.Enqueue(s);
            }

            while (queue.Count > 0)
            {
                if (!odwiedzone.Contains(queue.Peek())) napis += queue.Peek().wartosc + " ";
                odwiedzone.Add(queue.Peek());
                foreach (var s in queue.Peek().sasiad)
                {
                    if (!odwiedzone.Contains(s)) queue.Enqueue(s);
                }
                queue.Dequeue();
            }
        }
    }
}