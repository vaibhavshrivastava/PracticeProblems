using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public class FractionalKnapsack
    {
        public decimal GetMaxvalueOfLoot(int numberOfItems,int capacityOfBag,List<Tuple<decimal, decimal>> valueAndWeightsOfItems)
        {
            decimal maxValueOfLoot=0.0000M;
            List<Tuple<decimal, decimal>> valueAndWeightsList = valueAndWeightsOfItems;
            while (capacityOfBag > 0)
            {
                var item=GetMaxValueItem(valueAndWeightsOfItems);

                if (item.Item2 <= capacityOfBag)
                {
                    maxValueOfLoot += item.Item1;
                    capacityOfBag = capacityOfBag - (int)item.Item2;
                }
                else
                {
                    maxValueOfLoot = (item.Item1 / item.Item2) * (capacityOfBag);
                    capacityOfBag = 0;
                }
                valueAndWeightsList.Remove(item);
            }
            return Math.Round((Decimal)maxValueOfLoot,4 , MidpointRounding.AwayFromZero);
        }


        public Tuple<decimal, decimal> GetMaxValueItem(List<Tuple<decimal, decimal>> valueAndWeightsOfItems)
        {
            decimal max = 0.0000M;
            Tuple<decimal, decimal> maxItem =null;
            foreach (var item in valueAndWeightsOfItems)
            {
                var tempMax = item.Item1 / item.Item2;
                if (tempMax > max)
                {
                    max = tempMax;
                    maxItem=new Tuple<decimal, decimal>(item.Item1, item.Item2);
                }
            }
            return maxItem;
        }


        public void TestMaxValueOfTheLoot()
        {
            var testList = new List<Tuple<decimal, decimal>>() ;
            testList.Add(new Tuple<decimal, decimal>(60, 20));
            testList.Add(new Tuple<decimal, decimal>(100, 50));
            testList.Add(new Tuple<decimal, decimal>(120, 30));
            var asnser=GetMaxvalueOfLoot(3, 50, testList);


            var testList2 = new List<Tuple<decimal, decimal>>();
            testList.Add(new Tuple<decimal, decimal>(500, 30));
         
            var asnser2 = GetMaxvalueOfLoot(1, 0, testList);

        }

        public void TestFromConsole()
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            int[] myInts = Array.ConvertAll(nums, s => int.Parse(s));
            int n = myInts[0];
            int capacity = myInts[1];

            var testList = new List<Tuple<decimal, decimal>>();

            var values = new int[n];
            var weights = new int[n];
            for (int i = 0; i < n; i++)
            {
                string num = Console.ReadLine();
                string[] nums2 = num.Split(' ');
                decimal[] myInt = Array.ConvertAll(nums2, s => decimal.Parse(s));
                testList.Add(new Tuple<decimal, decimal>(myInt[0], myInt[1]));
              
            }

            var asnser = GetMaxvalueOfLoot(n,capacity, testList);
            Console.WriteLine(asnser);

        }

    }
}
