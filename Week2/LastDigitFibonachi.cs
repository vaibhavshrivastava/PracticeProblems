using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    //Task. Given an integer n, find the nth Fibonacci number Fn
    public class FibonachiOne
    {
        public Int64 GetNFibonacci(int n)
        {
            Int64 first = 0;
            Int64 second = 1;
            Int64 num=0;
            if (n == 0)
            {
                return second;
            }
            else if (n == 1)
            {
                return 1;
            }
            else 
            {
                
                for (int i = 2; i <= n; i++)
                {
                    num = first + second;
                    first = second;
                    second = num;
                }
                return num;
            }
            
            
        }


        public Int64 GetLastDigitofFibo(Int64 n)
        {
            Int64 first = 0;
            Int64 second = 1;
            Int64 num = 0;
            if (n == 0)
            {
                return second;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {

                for (int i = 2; i <= n; i++)
                {
                    num = (first + second) %10;
                    first = second;
                    second = num;
                }
                return num;
            }

        }

       

        /*
          static void Main(string[] args)
          {
               FibonachiOne fb = new FibonachiOne();
               var x=fb.GetNFibonacci(10);
            
               // LastDigitTest 
               //var x = fb.GetLastDigitofFibo(327305);
        
               Console.WriteLine(x.ToString());
               Console.ReadLine();
        }
        */
    }
}
