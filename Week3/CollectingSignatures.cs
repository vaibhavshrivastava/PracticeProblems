using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public class CollectingSignatures
    {
        public int GetMinPoints(List<Tuple<int, int>> segments)
        {
            int count = 0;
            if (segments.Count() == 0)
            {
                return 0;
            }
            
            else
            {
                var minItem = GetMinItem(segments);
                count++;
                var subSegments = new List<Tuple<int, int>>(); 
                segments.Remove(minItem);
        
                foreach (var item in segments)
                {
                    if (item.Item1 >= minItem.Item1 && item.Item1 <= minItem.Item2)
                    {
                        subSegments.Add(item);
                    }
                }
               
                    
                foreach (var item in subSegments)
                {
                    segments.Remove(item);
                }
                return count+=(GetMinPoints(segments));
            }
        }


        public Tuple<int, int> GetMinItem(List<Tuple<int, int>> segments)
        {
            var minItem = segments[0];
            for (int i = 0; i < segments.Count - 1; i++)
            {
                if (minItem.Item2 > segments[i + 1].Item2)
                {
                    minItem = segments[i + 1];
                }
            }
            return minItem;
        }


        public void TestWithData()
        {
            var input1 = new List<Tuple<int, int>>();
            input1.Add(new Tuple<int, int>(1, 3));
            input1.Add(new Tuple<int, int>(2, 5));
            input1.Add(new Tuple<int, int>(3, 6));

            var input2 = new List<Tuple<int, int>>();
            input2.Add(new Tuple<int, int>(4, 7));
            input2.Add(new Tuple<int, int>(1, 3));
            input2.Add(new Tuple<int, int>(2, 5));
            input2.Add(new Tuple<int, int>(3, 6));


            Console.WriteLine(GetMinPoints(input2).ToString());
        }


    

        public void TestMinPoints()
        {
            var n = Console.ReadLine();
            int num;
            int.TryParse(n, out num);

            var input = new List<Tuple<int, int>>();
            while (num > 0)
            {
                var input2 = Console.ReadLine();
                string[] input2Array = input2.Split(' ');
                var segment = new Tuple<int, int>(int.Parse(input2Array[0]), int.Parse(input2Array[1]));
                input.Add(segment);
                num--;
            }
            Console.WriteLine(GetMinPoints(input).ToString());

        }

    }
}
