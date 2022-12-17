using AK_Project_24_Список;

/*List MyList = new List();
for (int i = 0; i <= 25; i++)
{
    string t = Convert.ToString("abcdefghijkttlmnopqbrstuvwxyz"[i]);
    MyList.AddTail(t);
}
MyList.Print();
Console.WriteLine();

//Вывод k элемента с конца
Console.Write("Какой номер с конца мы ищем? ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MyList.FindEnd(k).Value);
Console.WriteLine();

//Удаление элемента с индексом d (через метод класса)
Console.Write("Какой элемент вы хотите удалить? ");
string d = Console.ReadLine();
List_Item temp = MyList.FindValue(d);
temp.Del();
MyList.Print();
Console.WriteLine();

//Добавление элемента в начало
Console.Write("Введите элемент, который хотите добавить в начало списка: ");
string x = Console.ReadLine();
MyList.AddHead(x);
MyList.Print();
Console.WriteLine();

//Разворот односвязного списка
Console.WriteLine("Что будет, если его развернуть?");
Console.ReadKey();
MyList.Reverse().Print();
Console.WriteLine();

//Проверка на палиндром
Console.WriteLine("Это палиндром? ");
Console.ReadKey();
Console.WriteLine(MyList.IsPalindrome());
Console.ReadKey();
Console.Write("А это палиндром? ");
List PalindromeList = new List();
//PalindromeList.Head = new List_Item("t");
PalindromeList.AddTail("t");
PalindromeList.AddTail("h");
PalindromeList.AddTail("e");
PalindromeList.AddTail("r");
PalindromeList.AddTail("e");
PalindromeList.AddTail("h");
PalindromeList.AddTail("t");
PalindromeList.Print();
Console.ReadKey();
Console.WriteLine(PalindromeList.IsPalindrome());
Console.WriteLine();
Console.ReadKey();

//Удаление дубликатов
MyList.AddTail("a");
MyList.AddTail("a");
MyList.Print();
MyList.DeleteRepeats();
MyList.Print();
Console.WriteLine("Теперь все элементы точно уникальные!");*/



List2 MyList = new List2();
for (int i = 0; i <= 26; i++)
{
    string t = Convert.ToString("abcdefghijklmnopqbrstuvwxyz"[i]);
    MyList.AddTail(t);
}
MyList.Print();
Console.WriteLine();

Console.Write("Какой элемент вы хотите добавить в конец: ");
string a = Console.ReadLine();
MyList.AddTail(a);
MyList.Print();
Console.WriteLine();

Console.Write("Какой элемент вы хотите добавить в начало: ");
string b = Console.ReadLine();
MyList.AddHead(b);
MyList.Print();
Console.WriteLine();

Console.Write("Какой элемент с конца вы ищете: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MyList.FindEnd(c).Value);
Console.WriteLine();

Console.WriteLine("Давайте развернем список: ");
MyList = MyList.Reverse();
MyList.Print();
Console.WriteLine();

Console.WriteLine("Давайте удалим какой-нибудь элемент: ");
List_Item2 temp = MyList.Head;
for (int i = 0; i < 7; i++)
{
    temp = temp.Next;
}
temp.Del();
MyList.Print();
Console.WriteLine();

Console.WriteLine("Это палиндром? ");
Console.WriteLine(MyList.IsPalyndrome());
List2 MyList2 = new List2();
MyList2.AddTail("w");
MyList2.AddTail("e");
MyList2.AddTail("s");
MyList2.AddTail("e"); 
MyList2.AddTail("w");
Console.Write("А это палиндром? ");
Console.WriteLine(MyList2.IsPalyndrome());
MyList2.Print();

Console.WriteLine();

/*Console.WriteLine("Давайте уберём одинаковые элементы: ");
MyList.DeleteRepeats();
MyList.Print();
Console.WriteLine();*/