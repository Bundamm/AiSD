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
            var napis = tbInput.Text;
            int[] tab = convertInt(napis);
            BST root = buildBST(tab);
            var napis2 = generujdrzewo(root);
            MessageBox.Show(napis2);

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
        private string generujdrzewo(BST node, string prefix = "", bool isLeft = false)
        {
            if (node == null)
            {
                return "";
            }

            string napis = "";

            string side = isLeft ? "L" : "P";
            string nodeInfo = $"{prefix}Dodano: [{side}] {node.wartosc}\n";

            if (prefix == "")
            {
                napis += $"Korzeñ {node.wartosc};\n";
            }
            else
            {
                napis += $"{prefix}{nodeInfo}";
            }

            if (node.leweDziecko != null || node.praweDziecko != null)
            {
                napis += generujdrzewo(node.leweDziecko, $"{prefix}Rodzic {node.wartosc};\n", true);
                napis += generujdrzewo(node.praweDziecko, $"{prefix}Rodzic {node.wartosc};\n", false);
            }

            return napis;
        }
        public class BST
        {
            public int wartosc;
            public BST leweDziecko;
            public BST praweDziecko;
            public BST rodzic;
            public BST(int wartosc)
            {
                this.wartosc = wartosc;
                leweDziecko = null;
                praweDziecko = null;
                rodzic = null;
            }
            
        }
        public BST buildBST(int[] values)
        {
            if (values == null || values.Length == 0)
            {
                return null;
            }
            BST root = new BST(values[0]);
            for (int i = 1; i < values.Length; i++)
            {
                insertBST(root, values[i]);
            }
            return root;
        }

        public void insertBST(BST root, int value)
        {
            if (value < root.wartosc)
            {
                if (root.leweDziecko == null)
                {
                    root.leweDziecko = new BST(value);
                    root.leweDziecko.rodzic = root;
                }
                else
                {
                    insertBST(root.leweDziecko, value);
                }
            }
            else
            {
                if (root.praweDziecko == null)
                {
                    root.praweDziecko = new BST(value);
                    root.praweDziecko.rodzic = root;
                }
                else
                {
                    insertBST(root.praweDziecko, value);
                }
            }
        }

    }


    
    
}