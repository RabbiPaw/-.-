using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Лямбда
{

    class Program
    {
        delegate double Lambda(double x, double y, double z);
        static Lambda Add = (x, y, z) => { return (x + y + z); };
        static Lambda Multiply = (x, y, z) => { return (x * y * z); };
        static Lambda Maxim =(x, y, z)=>{return (Math.Max(Math.Max(x, y), z));};
        static Lambda Minim = (x, y, z) => { return (Math.Min(Math.Min(x, y), z)); };
        static Lambda MidArefm=(x, y, z) =>{ return ((x + y + z) / 3); };
        public static void Message2(double x, double y, double z)
        {
            Console.WriteLine(@"
1) Выполнить другую процедуру   
Введите любой другой символ для выхода");
            string n = Console.ReadLine();
            Console.Clear();
            switch (n) {
                case "1":
                    Message1(x,y,z);
                    break;
                default:
                    break;
            }
        }
        public static void Message1(double x,double y,double z)
        {
            Console.WriteLine(@"
Что вы хотите сделать с числами?
1) сложить
2) перемножить
3) найти минимальное
4) найти максимальное
5) найти среднее арифметическое

Введите любой другой символ для выхода");
            string n = Console.ReadLine();
            Console.Clear();
            switch (n)
            {
                case "1":
                    Console.WriteLine(Add(x, y, z));
                    Message2(x, y, z);
                    break;
                case "2":
                    Console.WriteLine(Multiply(x, y, z));
                    Message2(x, y, z);
                    break;
                case "3":
                    Console.WriteLine(Minim(x, y, z));
                    Message2(x, y, z);
                    break;
                case "4":
                    Console.WriteLine(Maxim(x, y, z));
                    Message2(x, y, z);
                    break;
                case "5":
                    Console.WriteLine(MidArefm(x, y, z));
                    Message2(x, y, z);
                    break;
                default:
                    break;
            }

        }
        static void Main()
        {
            double x = 0;
            double y = 0;
            double z = 0;
            Console.WriteLine("Введите числа:");
            bool t = false;
            while (t == false)
            {
                Console.Write("x: ");
                string a = Console.ReadLine();
                bool k = double.TryParse(a, out var number);
                Console.Clear();
                if (k == false)
                {
                    Console.WriteLine("Неправильный ввод");
                }
                else
                {
                    t = true;
                    x = Convert.ToDouble(a);
                }
            }
            t = false;
            while (t == false)
            {
                Console.Write("y: ");
                string b = Console.ReadLine();
                bool k = double.TryParse(b, out var number);
                Console.Clear();
                if (k == false)
                {
                    Console.WriteLine("Неправильный ввод");
                }
                else
                {
                    t = true;
                    y = Convert.ToDouble(b);
                }
            }
            t = false;
            while (t == false)
            {
                Console.Write("z: ");
                string c = Console.ReadLine();
                bool k = double.TryParse(c, out var number);
                Console.Clear();
                if (k == false)
                {
                    Console.WriteLine("Неправильный ввод");
                }
                else
                {
                    t = true;
                    z = Convert.ToDouble(c);
                }
                Message1(x, y, z);
            }

        }

        
    }
}
