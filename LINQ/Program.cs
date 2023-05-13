using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums1 = Console.ReadLine().Split(' ');
            int[] nums = new int[nums1.Length];
            int fq = 0;
            foreach(string i in nums1)
            {
                nums[fq]=Convert.ToInt32(i); fq++;
            }
            var minusNums = from p in nums where p < 0 select p;
            var plusNums = from p in nums where p>0 select p;
            var evenNums = from p in nums where p%2 == 0 select p;
            int z = 1;
            foreach(var k in evenNums)
            {
                z = z * k;
            }
            Console.WriteLine(minusNums.Count());
            Console.WriteLine(plusNums.Sum());
            Console.WriteLine(z);
        }
    }
}
