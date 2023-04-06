using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Math Mp = new Math();
            Console.WriteLine("Введите числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write(@"
Что вы хотите сделать с числами?
+ : сложить a и b
- : вычесть b из a 
* : умножить a на b
/ : поделить a на b
");
            string f = Console.ReadLine();
            Console.Clear();
            switch (f)
            {
                case "+":
                    {
                        Mp.Plus(a, b);
                        break;
                    }
                case "-":
                    {
                        Mp.Minus(a, b);
                        break;
                    }
                case "*":
                    {
                        Mp.Ymn(a, b);
                        break;
                    }
                case "/":
                    {
                        Mp.Del(a, b);
                        break;
                    }
            }
        }
    }
}
