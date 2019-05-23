using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
   public class Greedy
    {

        public int GetChange(int m)
        {
            int balance = m;
            int tens=0;
            int fives=0;
            int ones;
            if (balance > 10)
            {
                tens = m / 10;
                balance = m % 10;
            }
            if (balance > 5)
            {
                fives = balance / 5;
                balance = balance % 5;
            }
            ones = balance;
            return (tens + fives + ones);
        }

        public void TestMoneyChange()
        {
            int m;
            string nums = Console.ReadLine();
            int.TryParse(nums, out m);

            var x = GetChange(m);
            Console.WriteLine(x);
        }
    }
}
