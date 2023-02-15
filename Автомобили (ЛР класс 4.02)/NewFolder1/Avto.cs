using System;
using System.Xml.Linq;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Data;

namespace GG
{
    public class Avto
    {
        public string mark;
        public string color;
        public string year;
        public string vlad;
        public Avto(string mark, string color, string year, string vlad)
        {
            this.mark = mark;
            this.color = color;
            this.year = year;
            this.vlad = vlad;
            

        }
    }
    public class Vladel
    {
        public string surname;
        public string name;
        public string otch;
        public string buy;
        public string sell;

        public Vladel(string surname, string name, string otch, string buy, string sell)
        {
            this.surname = surname;
            this.name = name;
            this.otch = otch;
            this.buy = buy;
            this.sell = sell;
        }
    }
    class Main1
    {
        public static void Vvod(out List<Avto> list1, out List<Vladel>list2)
        {
            list1 = new List<Avto>();
            list2 = new List<Vladel>();
            List<Vladel>op = new List<Vladel>();
            Console.Write("Марка: ");
            string mark = Console.ReadLine();
            Console.Clear();
            Console.Write("Цвет: ");
            string color = Console.ReadLine();
            Console.Clear();
            Console.Write("Год выпуска: ");
            string year = Console.ReadLine();
            Console.Clear();
            Console.Write("Количество владельцев: ");
            string vlad = Console.ReadLine();
            Console.Clear();
            int l = Convert.ToInt32(vlad);
            for (int i = 0; i < l; i++)
            {
                Console.Write("Фамилия: ");
                string surname = Console.ReadLine();
                Console.Clear();
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.Clear();
                Console.Write("Отчество: ");
                string otch = Console.ReadLine();
                Console.Clear();
                Console.Write("Год покупки: ");
                string buy = Console.ReadLine();
                Console.Clear();
                Console.Write("Год продажи: ");
                string sell = Console.ReadLine();
                Console.Clear();
                op.Add(new Vladel(surname, name, otch, buy, sell));
            }
            list1.Add(new Avto(mark, color, year, vlad));
            list2.AddRange(op);
        }
        public static void Message()
        {
            Console.Write(@"
Список автомобилей
1) Добавить автомобиль в базу данных
2) Автомобили с одним владельцем
3) Автомобили моложе n-го года
4) Автомобили определенной марки
5) Выход
Что вы хотите сделать?: ");

        }
        public static void Main()
        {
            List<Avto> list1 = new List<Avto>();
            List<Vladel> list2 = new List<Vladel>();
            List<Avto>A =  new List<Avto>();
            List<Vladel>B = new List<Vladel>();
            Message();
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            bool q = true;
            while (q)
            {
                if (n == 1)
                {
                    Console.Clear();
                    Vvod(out list1, out list2) ;
                    A.AddRange(list1);
                    B.AddRange(list2);
                }
                if (n == 2)
                {
                    int p = list1.Count;
                    int c = 0;
                    int x = 0;
                    while (x != p)
                    {
                        if (p != 0)
                        {
                            if (Convert.ToInt32(A[x].vlad) == 1)
                            {
                                Console.Write(A[x].mark);
                                Console.Write(" ");
                                Console.Write(A[x].color);
                                Console.Write(" ");
                                Console.Write(A[x].year);
                                Console.Write(" ");
                                Console.Write(A[x].vlad);
                                Console.Write(" ");
                                Console.Write(B[x].surname);
                                Console.Write(" ");
                                Console.Write(B[x].name);
                                Console.Write(" ");
                                Console.Write(B[x].otch);
                                Console.Write(" ");
                                Console.Write(B[x].buy);
                                Console.Write(" ");
                                Console.Write(B[x].sell);
                                Console.Write("\n");

                            }
                        }
                        x++;
                        c++;
                    }

                    if (c == 0)
                    {
                        Console.WriteLine("Отсутствуют машины, удовлетворяющие данному критерию");
                    }
                }

                if (n == 3)
                {
                    Console.Write("Введите год,позже кторого вышла машина: ");
                    int qwe = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    int p = A.Count;
                    int c = 0;
                    int x = 0;
                    while (x != p)
                    {
                        int i= 0;
                        int f = Convert.ToInt32(A[x].vlad);
                        if (p != 0)
                        {
                            if (Convert.ToInt32(A[x].year) > qwe)
                            {
                                Console.Write(A[x].mark);
                                Console.Write(" ");
                                Console.Write(A[x].color);
                                Console.Write(" ");
                                Console.Write(A[x].year);
                                Console.Write(" ");
                                Console.Write(A[x].vlad);
                                Console.Write(" ");
                                while (i!=f)
                                {
                                    Console.Write(B[x+i].surname);
                                    Console.Write(" ");
                                    Console.Write(B[x+i].name);
                                    Console.Write(" ");
                                    Console.Write(B[x + i].otch);
                                    Console.Write(" ");
                                    Console.Write(B[x + i].buy);
                                    Console.Write(" ");
                                    Console.Write(B[x + i].sell);
                                    Console.Write(" ");
                                    i++;
                                }
                                Console.Write("\n");

                            }
                        }
                        x++;
                        c++;

                    }
                    if (c == 0)
                    {
                        Console.WriteLine("Отсутствуют машины, удовлетворяющие данному критерию");
                    }
                }
            if (n == 4)
            {
                Console.Write("Введите марку машины: ");
                string qwep = Convert.ToString(Console.ReadLine());
                    Console.Clear();
                    int p = A.Count;
                    int c = 0;
                    int x = 0;
                    while (x != p)
                    {
                        int i = 0;
                        int f = Convert.ToInt32(A[x].vlad);
                        if (p != 0)
                        {
                            if (A[x].mark == qwep)
                            {
                                Console.Write(A[x].mark);
                                Console.Write(" ");
                                Console.Write(A[x].color);
                                Console.Write(" ");
                                Console.Write(A[x].year);
                                Console.Write(" ");
                                Console.Write(A[x].vlad);
                                Console.Write(" ");
                                while (i != f)
                                {
                                    Console.Write(B[x + i].surname);
                                    Console.Write(" ");
                                    Console.Write(B[x + i].name);
                                    Console.Write(" ");
                                    Console.Write(B[x + i].otch);
                                    Console.Write(" ");
                                    Console.Write(B[x + i].buy);
                                    Console.Write(" ");
                                    Console.Write(B[x + i].sell);
                                    Console.Write(" ");
                                    i++;
                                }
                                Console.Write("\n");

                            }
                        }
                        x++;
                        c++;

                    }
                    if (c == 0)
                    {
                        Console.WriteLine("Отсутствуют машины, удовлетворяющие данному критерию");
                    }
                }
            if (n >= 5) q = false;
                if (n < 5)
                {
                    Console.WriteLine(@"
1) В меню
2) Выход");
                    int ol = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (ol == 1)
                    {
                        Message();
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        q = false;
                    }
                }
        }
    }
    }
}
