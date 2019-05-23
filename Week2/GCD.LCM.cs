using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoToolPracticeProblems
{
    public class GCD
    {

        public Int64 GetGCD(Int64 a, Int64 b)
        {
            Int64 result;
            if (a > b)
            {
                result=ComputeGCD(a, b);
            }
            else
            result=ComputeGCD(b, a);

            return result;
        }
        private Int64 ComputeGCD(Int64 g, Int64 s)
        {
            if (s == 0)
            {
                return g;
            }
            Int64 x=g % s;
            return ComputeGCD(s, x);            
        }





        /*
        static void Main(string[] args)
        {
            GCD gcd = new GCD();
            var x = gcd.GetGCD(0, 0);
            Console.WriteLine(x.ToString());
            Console.ReadLine();
        }
        */




        public Int64 GetLCM(Int64 a, Int64 b)
        {
            return (a * b) / GetGCD(a, b);
        }

        /*
                string nums = Console.ReadLine();
                string[] nums2 = nums.Split(' ');
                int[] myInts = Array.ConvertAll(nums2, s => int.Parse(s));
                GCD gcd = new GCD();
                var x = gcd.GetLCM(myInts[0], myInts[1]);
                Console.WriteLine(x.ToString());
                Console.ReadLine();
                }
        */


    }
}
