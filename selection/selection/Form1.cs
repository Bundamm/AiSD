using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace selection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] tab = { 3, 5, 7, 2, 6, 8, 1, 10 };
            string res = selSort(tab);
            MessageBox.Show(res);

            
            

            
        }
        string selSort(int[] tab)
        {
            int minI,temp;
            for (int i = 0; i < tab.Length-1; i++)
            {
                minI = i;
                for (int j = i; j < tab.Length; j++) //i+1?
                {
                    if (tab[j] < tab[minI])
                    {
                        minI = j;
                    }
                }
                temp = tab[i];
                tab[i] = tab[minI];
                tab[minI] = temp;
            }
            string wynik = "";
            for(int i = 0; i < tab.Length; i++) {
                wynik += tab[i].ToString() + ", ";
            }
            return wynik;
        }
    }
}
