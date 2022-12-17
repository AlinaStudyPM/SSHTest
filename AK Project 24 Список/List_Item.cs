using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_Project_24_Список
{
    public class List_Item
    {
        public string Value = null;
        public List_Item Next = null;

        public List_Item(string s) //при создании элемента ему присваивается значение
        {
            Value = s;
        }

        public void Del()
        {
            if (Next != null)
            {
                Value = Next.Value;
                Next = Next.Next;
            }
            else
            {
                Value = null;
            }
        }
    }
}
