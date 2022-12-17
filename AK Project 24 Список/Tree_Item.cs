using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_Project_24_Список
{
    public class Tree_Item
    {
        public string Value;
        public Tree_Item Left = null;
        public Tree_Item Right = null;

        public Tree_Item(string s) //при создании элемента ему присваивается значение
        {
            Value = s;
        }
    }
}
