using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week2
{
    public class FibonacciAgainTest
    {
        public static int GetPiscanoPerioid(Int64 Mod)
        {
            int period = 0;
            int sequence = 0;
            Int64 fibonacciMod = 1;
            Int64 a = 0;
            Int64 b = 1;
            Int64 c = 0;
            List<Int64> remainders = new List<Int64>();
            while (true)
            {
                if (sequence == 0)
                {
                    fibonacciMod = 0;
                }
                else if (sequence == 1)
                {
                    fibonacciMod = 1;
                }
                else
                {
                    fibonacciMod = (a + b) % Mod;
                    a = b;
                    b = fibonacciMod;
                }

                remainders.Add(fibonacciMod);
                sequence++;
                if (sequence >= 5)
                {
                    int length = remainders.Count();
                    if (remainders[length - 1] == 1 & remainders[length - 2] == 0)
                    {
                        period = length - 2;
                        break;
                    }
                }
            }
            return period;
        }


        public static Int64 CalculateFibonacciWihMod(Int64 num, Int64 mod)
        {
            Int64 fibonacciWithMod=0 ;
            
            Int64 a = 0;
            Int64 b = 1;
            if (num == 1)
            {
                fibonacciWithMod = 1;
            }
            for (int i = 1; i < num; i++)
            {
                fibonacciWithMod = (a + b) % mod;
                a = b;
                b = fibonacciWithMod;
            }
            return fibonacciWithMod;
        }
        public static Int64 GetFibonacchiLarge(Int64 num, Int64 mod)
        {
            int piscanoPeriod = GetPiscanoPerioid(mod);
            Int64 remainderOfNumWithPiscano = num % piscanoPeriod;
            var largeFibonacciMod = CalculateFibonacciWihMod(remainderOfNumWithPiscano, mod);

            return largeFibonacciMod % mod;

        }

        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            string[] nums2 = nums.Split(' ');
            Int64[] myInts = Array.ConvertAll(nums2, s => Int64.Parse(s));

            var x = GetFibonacchiLarge(myInts[0], myInts[1]);
            Console.WriteLine(x.ToString());
        }
    }
}