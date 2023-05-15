using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main()
        {
            List<string> list = new List<string>();
            List<string> list1 = new List<string>() { "2", "4", "5" };
            List<int>list2 = new List<int>() { 5,7,1,54,6,8,9 };
            foreach (string s in list1)
            {
                Console.Write(s +" ");
            }
            Console.WriteLine();
            
            list.Add("1");
            list.Add("2");
            foreach (string s in list)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            foreach(int s in list2)
            {
                Console.Write(s+" ");
            }
            Console.WriteLine();
            Console.WriteLine(list.Count());
            Console.WriteLine(list.Concat(list1));
            foreach (string s in list.Concat(list1))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine(list.Contains("1"));
            foreach (string s in list.Distinct())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            foreach (string s in list.Except(list1))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            foreach (string s in list.FindAll(s => s is string))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine(list.GetHashCode());
            Console.WriteLine(list1.Remove("2"));
            Console.WriteLine(list2.Max());
            list2.Clear();
            foreach (int s in list2)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();


        }
    }
}
