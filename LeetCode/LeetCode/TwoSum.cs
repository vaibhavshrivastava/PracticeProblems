using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSum
    {
        // Using Hash Table
        public int [] GetIndicesOfTheSum(int [] a,int target)
        {
            int[] index = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                map.Add(a[i], i);
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (map.ContainsKey(target - a[i]))
                {
                    index[0] = i;
                    index[1] = map[target - a[i]];
                    return index;
                }
            }
            throw new Exception("Indicies for the target Not Found");

        }

        //Brute Force Time O(n2) Space O(1) 
        public int[] TwoSumWithLoops(int[] a, int target)
        {
            int[] index = new int[2];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == target)
                    {
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
            return index;
        }

        public Tuple<int, int> TwoSumHashSet(List<int> list, int sum)
        {
            var hs = new HashSet<int>();
            list.ToList().ForEach(x => hs.Add(x));

            for (int i = 0; i < hs.Count; i++)
            {
                var diff = sum - list[i];
                if (hs.Contains(diff))
                {
                    var index = list.IndexOf(diff);
                    return new Tuple<int, int>(i, index);
                }
            }

            return null;
        }

        public void TestTwoSum()
        {
            int[] test1 = new int[] { 1, 23, 4, 5, 6 };
            int[] test2 = new int[] { 3, 3 };

            var result=TwoSumHashSet(test2.ToList<int>(), 6);
        }
    }
}
