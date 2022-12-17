using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_Project_24_Список
{
    public class List
    {
        public List_Item Head = new List_Item(null);

        public List() { }
        public List(string s) { Head.Value = s; }

        public void AddTail(string s) //добавление элемента в конец списка
        {
            if (Head.Value == null) { Head = new List_Item(s); }
            else
            {
                List_Item temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new List_Item(s);
            }
        }
        public void Print() //Вывод списка на экран
        {
            List_Item temp = Head;
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
            List_Item NewHead = new List_Item(s);
            NewHead.Next = Head;
            Head = NewHead;
        }
        public List_Item FindEnd(int k) //к-ый элемент с конца
        {
            List_Item temp = Head;
            List_Item ans = Head;
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
                ans = new List_Item(null);
            }
            return ans;
        }
        public List_Item FindValue(string s) //Поиск заданного значения
        {
            List_Item temp = Head;
            List_Item refuse = new List_Item(null);
            if (temp.Value == s)
            {
                refuse = temp;
            }
            while (temp.Next != null)
            {
                temp = temp.Next;
                if (temp.Value == s)
                    refuse = temp;
            }
            return refuse;
        }
        public List Reverse() //Разворот списка
        {
            List ListReverse = new List(Head.Value);
            List_Item temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                ListReverse.AddHead(temp.Value);
            }
            return ListReverse;
        }
        public bool IsPalindrome() //Проверка на палиндром
        {
            List ReversedList = this.Reverse();
            List_Item tmp1 = Head;
            List_Item tmp2 = ReversedList.Head;
            bool Flag = true;
            if (tmp1.Value != tmp2.Value)
            {
                Flag = false;
                return Flag;
            }
            while (tmp1 != null && tmp2 != null)
            {
                if (tmp1.Value != tmp2.Value)
                {
                    Flag = false;
                }
                tmp1 = tmp1.Next;
                tmp2 = tmp2.Next;
            }
            return Flag;
        }
        public void DeleteRepeats() //Удаление дубликатов
        {
            List_Item temp = Head;
            List_Item temp2;
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
        public void Create(string[] mass)
        {
            foreach (string massItem in mass)
            {
                this.AddTail(massItem);
            }
            /*for (int i = 0; i < mass.Length; i++)
            {
                this.AddTail(mass[i]);
            }*/
        }
    }
}
