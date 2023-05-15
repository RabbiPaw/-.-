using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSkobki
{
    internal class Program
    {
        static void Main()
        {
            var Skobki = new Stack<char>();
            string b = Console.ReadLine();
            foreach (char s in b){Skobki.Push(s);}
            List<char> s1 = new List<char>();
            List<char> s2 = new List<char>();
            List<char> s3 = new List<char>();
            foreach (char s in Skobki)
            {
                if (s =='(' || s == ')')
                {
                    s1.Add(s);
                }
                if (s =='{' || s == '}')
                {
                    s2.Add(s);
                }
                if (s =='[' || s == ']')
                {
                    s3.Add(s);
                }
            }
            if (((s1.FindAll(t=>t=='(')).Count() <= (s1.FindAll(t=>t==')')).Count()) && ((s2.FindAll(t => t == '{')).Count() <= (s2.FindAll(t => t == '}')).Count()) && ((s3.FindAll(t => t == '[')).Count() <= (s3.FindAll(t => t == ']')).Count()))
            {
                Console.WriteLine("Все скобки закрыты");
            }
            else { Console.WriteLine("Не все скобки закрыты"); }
        }
    }
}
