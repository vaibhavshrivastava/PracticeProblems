using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public class MaximiseAdRevenue
    {


        public int MaxAdRevenue(int n, List<int>profit,List<int>clicksPerDay)
        {
            int sum = 0;
            profit.Sort();
            clicksPerDay.Sort();
            for (int i = 0; i < n; i++)
            {
               sum+= profit[i] * clicksPerDay[i];
            }
            return sum;
        }


        public void TestMaxAdRev()
        {
            var n = Console.ReadLine();
            int num;
            int.TryParse(n, out num);
            var input1=Console.ReadLine();
            string[] inputArray = input1.Split(' ');
            int[] profit = Array.ConvertAll(inputArray, s => int.Parse(s));

            var input2 = Console.ReadLine();
            string[] input2Array = input2.Split(' ');
            int[] clicks = Array.ConvertAll(input2Array, s => int.Parse(s));


            var answer1 = MaxAdRevenue(num, profit.ToList<int>(), clicks.ToList<int>());
            Console.WriteLine(answer1);
        }

    }



}
