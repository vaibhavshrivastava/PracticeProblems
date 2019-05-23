using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class Fibonacci
    {
        // This implementation uses recursion which is bad in this case as it is making duplicate calls to process same data
        public int GetFibonacciBad(int n)
        {
            if (n == 0) { Console.WriteLine("0"); return 0; }
            else if (n == 1) { Console.WriteLine("1"); return 1; }
            else
            {
                Console.WriteLine(n);
                return (GetFibonacciBad(n - 1) + GetFibonacciBad(n - 2));
            }
        }


        //This is a better implementaion as it uses 
        public Int64 GetFibonacci(int n)
        {
            Int64 a = 0;
            Int64 b = 1;
            Int64 c = 0;
            if (n == 0) { Console.WriteLine("0"); return 0; }

            else if (n == 1) { Console.WriteLine("0,1"); return 1; }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    c = a + b;
                    //Console.WriteLine("{0}", c);
                    a = b;
                    b = c;
                }
                return c;
            }
        }
    }
}
