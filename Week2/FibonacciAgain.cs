
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{

    //Say, F2015 mod 3 we just need to find the remainder of 2015 when divided by 8. 
    //Since 2015 = 251·8 + 7, we conclude that F2015 mod 3 = F7 mod 3 = 1. 
    class FibonacciAgain
    {
        public int GetPiscanoPerioid(Int64 Mod)
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
                    fibonacciMod = (a + b)%Mod;
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


        public Int64 CalculateFibonacciWihMod(Int64 num,Int64 mod)
        {
            Int64 fibonacciWithMod = 0;
            Int64 a = 0;
            Int64 b = 1;

            for (int i=1;i<num;i++)
            {
                fibonacciWithMod = (a + b) % mod;
                a = b;
                b = fibonacciWithMod;
            }
            return fibonacciWithMod;
        }
        public Int64 GetFibonacchiLarge(Int64 num, Int64 mod)
        {
            Int64 piscanoPeriod = GetPiscanoPerioid(mod);
            Int64 remainderOfNumWithPiscano = num % piscanoPeriod;
            var largeFibonacciMod=CalculateFibonacciWihMod(remainderOfNumWithPiscano,mod) ;

            return largeFibonacciMod % mod;

        }


        public int CalculateLastDigitOfTheSum2(Int64 num)
        {
            int first = 0;
            int second = 1;
            int fibonacciLastDigit = 0;
            int sum = first + second;
            for (int i = 2; i < num+1; i++)
            {
                fibonacciLastDigit = (first + second) % 10;
                first = second;
                second = fibonacciLastDigit;
                sum=sum+fibonacciLastDigit;
            }
            return sum % 10;
        }


        public int CalculateLastDigitOfTheSum(Int64 num)
        {
            int first = 0;
            int second = 1;
            int fibonacciLastDigit = 0;
            int sum = first + second;
            for (int i = 2; i < num + 3; i++)
            {
                fibonacciLastDigit = (first + second) % 10;
                first = second;
                second = fibonacciLastDigit;

            }
            return fibonacciLastDigit - 1;
        }


        public Int64 CalculateBetween(Int64 m, Int64 n)
        {
            Int64 sum = 0;
            FibonachiOne test = new FibonachiOne();
            for (Int64 i = m; i<n+1; i++)
            {
                sum=(sum+ test.GetLastDigitofFibo(i));
            }
            return sum%10;
        }

       
    }
}
