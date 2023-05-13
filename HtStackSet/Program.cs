using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HtStackSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable Ht = new Hashtable();
            Stack St = new Stack();
            Ht.Add("1", "1");
            Ht.Add("2", "2");
            Console.WriteLine("Hashtable");
            foreach (var key in Ht.Keys)
            {
                Console.WriteLine(key + " " + Ht[key]);
            }
            Console.WriteLine();
            Console.WriteLine(Ht.ContainsValue("1"));
            Console.WriteLine();
            Console.WriteLine(Ht.ContainsValue("2"));
            Console.WriteLine();
            Ht.Remove("1");
            Console.WriteLine(Ht.ContainsKey("1"));
            Console.WriteLine();
            Console.WriteLine(Ht.ContainsKey("2"));
            Console.WriteLine();
            Console.WriteLine(Ht.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(Ht.GetType());
            Console.WriteLine();
            Console.WriteLine(Ht.GetEnumerator());
            Console.WriteLine();
            Console.WriteLine(Ht.Equals(Ht));
            Console.WriteLine();
            Console.WriteLine(Ht.Count);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Stack");
            Ht.Clear();

            St.Push("1");
            St.Push("2");
            foreach (var k in St)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();
            Console.WriteLine(St.Contains("2"));
            Console.WriteLine();
            Console.WriteLine(St.Pop());
            Console.WriteLine();
            Console.WriteLine(St.Contains("1"));
            Console.WriteLine();
            Console.WriteLine(St.Peek());
            Console.WriteLine();
            Console.WriteLine(St.GetType());
            Console.WriteLine();
            Console.WriteLine(St.Count);
            Console.WriteLine();
            Console.WriteLine(St.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(St.Equals(St));
            Console.WriteLine();
            Console.WriteLine(St.GetEnumerator());
            St.Clear();


            string[] One = { "1", "2", "3" };
            string[] Two = { "2", "3", "4" };
            Console.WriteLine("Set");
            Console.WriteLine("One");
            foreach(var k in One)
            {
                Console.Write(k +" ");
            }
            Console.WriteLine();
            Console.WriteLine("Two");
            foreach(var k in Two) { Console.Write(k +" ");}
            Console.WriteLine();
            Console.WriteLine();
            var r = One.Except(Two);
            foreach(var k in r)
            {
                Console.Write(k +" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            r = One.Intersect(Two);
            foreach (var k in r)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            r = One.Union(Two);
            foreach (var k in r)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            r= One.Concat(Two);
            foreach (var k in r)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            r=r.Distinct();
            foreach (var k in r)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(r.Count());
            Console.WriteLine();
            Console.WriteLine(r.Contains("1"));
            Console.WriteLine();
            Console.WriteLine(r.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(r.GetType());
            Console.WriteLine();
            Console.WriteLine(r.GetEnumerator());
            Console.WriteLine();
            foreach (var k in r.Skip(2))
            {
                Console.Write(k + " ");
            }

        }
    }
}
