using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoToolPracticeProblems
{
    // Comp[ute Fn modulo m 
    public class Fibonachi2
    {
        public Int64 GetNFibonacci(int n)
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
                    num = first + second;
                    first = second;
                    second = num;
                }
                return num;
            }


        }
        public void GetThePattern(Int64 number,Int64 modNumber)
        {
            List<Int64> pattern = new List<Int64>()  ;
            // First get the pattern 
            for (int i = 0; i < number; i++)
            {
                pattern.Add(GetNFibonacci(i) % modNumber);
                if (pattern.Count() > 10)  // will have to handle for small values
                {
                    CheckPattern(pattern);
                }
            }
        }

        public void CheckPattern(List<Int64> modList)
        {
       
            for (int i = 2; i < modList.Count; i++)
            {
                if ((i * 2) > modList.Count)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (modList[j] != modList[i + j])
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }


        public int GetPiscanoPeriod(Int64 num)
        {
            Int64 a = 0;
            Int64 b = 1;
            Int64 c = a + b;
            int period = 0;
            for (int i = 0; i < 2*num; i++)
            {
                c = (a + b) % num;
                a = b;
                b = c;
                if (a == 0 && b == 1)
                {
                    period = i + 1;
                    break;
                }
            }

            return period;
        }

    }
}
