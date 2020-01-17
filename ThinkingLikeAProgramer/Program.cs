using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkingLikeAProgramer
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPattern1();
            Console.ReadKey();
        }

        //Exercise solutions

        // ########
        //  ######
        //   ####
        //    ##

        static void PrintPattern1()
        {
            int depth = 4;
            int width = 8;
            for (int r = 1; r <= depth; r++)
            {
                for (int c = 1; c <= width; c++)
                {
                    if (c < r || c > (1+ width - r))
                        Console.Write(" ");
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }
            /*
             * ########
               ########
            */


    }
}
