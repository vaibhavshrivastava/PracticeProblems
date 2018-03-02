using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MaxPairwiseProduct
    {
        public static Int64 MaxpairWiseProduct(int[] x)
        {
            x = x.OrderByDescending(c => c).ToArray();
            Int64 result= x[0]* x[1];
            return result;
        }

        public static void Main1(string []args)
        {
            int input= int.Parse(Console.ReadLine());
            
            string nums=Console.ReadLine();
            string[] nums2 = nums.Split(' ');
            int[] myInts = Array.ConvertAll(nums2, s => int.Parse(s));
            Console.WriteLine(MaxpairWiseProduct(myInts));
        }
    }
}
