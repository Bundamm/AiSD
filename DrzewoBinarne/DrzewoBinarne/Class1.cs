using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrzewoBinarne
{
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

        public BST buildBST(int[] values)
        {
            if(values == null || values.Length == 0)
            {
                return null;
            }
            BST root = new BST(values[0]);
            for(int i = 1; i < values.Length; i++)
            {
                insertBST(root, values[i]);
            }
            return root;
        }

        public void insertBST(BST root, int value)
        {
            if(value < root.wartosc) { 
                if(root.leweDziecko == null)
                {
                    root.leweDziecko= new BST(value);
                    root.leweDziecko.rodzic = root;
                }
                else
                {
                    insertBST(root.leweDziecko, value);
                }
            }
            else
            {
                if(root.praweDziecko == null)
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
