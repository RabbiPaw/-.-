using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Math: IMath
    {
        public void Plus(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Minus(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Ymn(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Del(int a, int b)
        {
            if (b != 0){Console.WriteLine(a / b);}
            else { Console.WriteLine("Error"); }
        }
    }
}
