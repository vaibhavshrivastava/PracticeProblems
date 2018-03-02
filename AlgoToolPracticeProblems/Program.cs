using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoToolPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               FibonachiOne fb = new FibonachiOne();
            
            var x=fb.GetNFibonacci(10);
            */

            // LastDigitTest 
            //var x = fb.GetLastDigitofFibo(327305);
            
            /*
            GCD gcd = new GCD();
            var x =gcd.GetGCD(225 ,150);
            Console.WriteLine(x.ToString());
            Console.ReadLine();
            */

            string nums = Console.ReadLine();
            string[] nums2 = nums.Split(' ');
            int[] myInts = Array.ConvertAll(nums2, s => int.Parse(s));
            GCD gcd = new GCD();
            var x=gcd.GetLCM(myInts[0], myInts[1]);
            Console.WriteLine(x.ToString());
            Console.ReadLine();
        }
    }
}
