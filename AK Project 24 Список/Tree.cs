using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_Project_24_Список
{
    public class Tree
    {
        public Tree_Item root;

        public Tree() { }
        public Tree(string s) { root.Value = s; }

        public void AddLeaf(string s)
        {
             if (root.Left == null)
            {
                root.Left = new Tree_Item(s);
            }
            else
            {
                root.Right = new Tree_Item(s);
            }
        }
    }
}
