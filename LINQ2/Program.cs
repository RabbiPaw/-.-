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
            int[]nums = new int[nums1.Length];
            int fq = 0;
            foreach(string i in nums1)
            {
                nums[fq]=Convert.ToInt32(i); fq++;
            }
            var minusNums = from p in nums where p < 0 select p;
            var plusNums = from p in nums where p>0 select p;
            var NumsK5 = from p in nums where p%5 == 0 select p;

            foreach (int i in plusNums) {
                Console.Write(' ');
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine(minusNums.Sum());
            Console.WriteLine(NumsK5.Count());
            Console.WriteLine();
            List<int> nums2 = new List<int>(); 
            foreach(int i in nums) {
            if (i % 2 != 0)
                {
                    nums2.Add(i);
                }
                        }
            minusNums = from p in nums2 where p < 0 select p;
            plusNums = from p in nums2 where p > 0 select p;
            NumsK5 = from p in nums2 where p % 5 == 0 select p;
            foreach (int i in plusNums)
            {
                Console.Write(' ');
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine(minusNums.Sum());
            Console.WriteLine(NumsK5.Count());
        }
    }
}
