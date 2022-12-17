using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_Project_24_Список
{
    public class List2
    {
        public List_Item2 Head = new List_Item2(null);
        public List2() { }
        public List2(string s)
        {
            Head.Value = s;
        }

        public void AddTail(string s) //добавление элемента в конец списка
        {
            if (Head.Value == null) { Head = new List_Item2(s); }
            else
            {
                List_Item2 temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new List_Item2(s, temp);
            }
        }

        public void Print() //Вывод списка на экран
        {
            List_Item2 temp = Head;
            while (temp.Next != null)
            {
                Console.Write(temp.Value);
                Console.Write(" ");
                temp = temp.Next;
            }
            Console.WriteLine(temp.Value);
        }

        public void AddHead(string s) //Добавление элемента в начало
        {
            List_Item2 NewHead = new List_Item2(s);
            Head.Prev = NewHead;
            NewHead.Next = Head;
            Head = NewHead;
        }

        public List_Item2 FindEnd(int k) //к-ый элемент с конца
        {
            List_Item2 temp = Head;
            List_Item2 ans = Head;
            int ind1 = 0, ind2 = 0;
            while (temp != null)
            {
                if (ind2 - ind1 == k)
                {
                    ans = ans.Next;
                    ind1 += 1;
                }
                temp = temp.Next;
                ind2 += 1;
            }
            if (ind2 - ind1 != k)
            {
                ans = new List_Item2(null);
            }
            return ans;
        }

        public List2 Reverse() //Разворот списка
        {
            List2 ListReverse = new List2(Head.Value);
            List_Item2 temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                ListReverse.AddHead(temp.Value);
            }
            return ListReverse;
        }
        public bool IsPalyndrome() //Проверка на палиндром
        {
            List_Item2 temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            List_Item2 temp2 = Head;
            while (temp != temp2 && temp2.Next != temp)
            {
                if (temp2.Value != temp.Value)
                {
                    return false;
                }
            }
            return true;
        }

        public void DeleteRepeats() //Удаление дубликатов
        {
            List_Item2 temp = Head;
            List_Item2 temp2;
            while (temp.Next != null)
            {
                temp2 = Head;
                while (temp2.Next != null)
                {
                    if (temp.Value == temp2.Value && temp != temp2)
                    {
                        temp2.Del();
                    }
                    else
                    {
                        temp2 = temp2.Next;
                    }
                }
                if (temp.Value == temp2.Value)
                {
                    temp2.Del();
                }
                temp = temp.Next;
            }
        }
    }
}
