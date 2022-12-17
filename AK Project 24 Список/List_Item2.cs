using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_Project_24_Список
{
    public class List_Item2
    {
        public string Value;
        public List_Item2 Next = null;
        public List_Item2 Prev = null;

        public List_Item2(string s) //при создании элемента ему присваивается значение
        {
            Value = s;
        }
        public List_Item2(string s, List_Item2 t)
        {
            Value = s;
            Prev = t;
        }

        public void Del()
        {
            Prev.Next = Next;
            Next.Prev = Prev;
        }
    }
}
