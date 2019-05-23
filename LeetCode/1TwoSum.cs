using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
   public class TwoSumProb
    {
        public int[] TwoSum(int[] nums,int target)
        {
            int[] indices = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        indices[0] = i;
                        indices[1] = j;
                    break;
                }
            }
            return indices;

        }


        public void TestTwoSumProb()
        {
           var answer= TwoSum(new int []{2,7,11,15},9);
            Console.WriteLine(answer[0].ToString() + answer[1].ToString());
        }

    }


}
