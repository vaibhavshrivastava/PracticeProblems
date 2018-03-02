using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
   public class Test
    {
        static void Main(string[] args)
        {

            StringCompression s = new StringCompression();
           // s.TestStringCompression();

            Fibonacci fib = new Fibonacci();
            Console.WriteLine("Enter number for Fibonacci");
            int n =int.Parse(Console.ReadLine());
            Console.WriteLine(fib.GetFibonacci(n));
            Console.ReadLine();





            // Test Urilify 
            /*
            Urlify u = new Urlify();
            Console.WriteLine("Enter string ...\n");
            string input = Console.ReadLine();
            string output = u.UrlifyString(input);
            Console.WriteLine(output);
            Console.ReadKey();
            */
        }
    }
}
