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
            foreach (char s in b)
            {
                if (s == '(' || s == '{' || s == '[')
                {
                    Skobki.Push(s);
                }
                else if (Skobki.Peek() == '(' && s == ')')
                {
                    Skobki.Pop();
                }
                else if (Skobki.Peek() == '{' && s == '}')
                {
                    Skobki.Pop();
                }
                else if (Skobki.Peek() == '[' && s == ']')
                {
                    Skobki.Pop();
                }
                else
                {
                    Console.WriteLine("Не все скобки закрыты");
                    Environment.Exit(0);
                }
            }

            if (Skobki.Count() == 0)
            {
                Console.WriteLine("Все скобки закрыты");
            }
            else
            {
                Console.WriteLine("Не все скобки закрыты");
            }

            } 
        }
    }
