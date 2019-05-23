using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class MergeSortProgram
    {
        // T(n)= 2T(n/2)+O(n) => nlog(n)

        public int[] MergeSort(int[] arr)
        {
            if (arr.Length == 1)
                return arr;
            else
            {
                var firstHalf = new int[arr.Length / 2];
                var secondHalf = new int[arr.Length - (arr.Length / 2)];
                Array.Copy(arr, firstHalf, arr.Length / 2);
                Array.Copy(arr, arr.Length / 2, secondHalf, 0, arr.Length - (arr.Length / 2));

                var sortedFirsthal = MergeSort(firstHalf);
                var sortedSecondHalf = MergeSort(secondHalf);
                var result = Merge(sortedFirsthal, sortedSecondHalf);
                return result;
            }
        }

        // take O(n) to merge
        private int[] Merge(int[] a, int[] b)
        {
            int aIndex = 0;
            int bIndex = 0;
            int index = 0;
            int[] sortedArray = new int[a.Length + b.Length];

            while (aIndex <= (a.Length - 1) || bIndex <= (b.Length - 1))
            {
                if(aIndex <= (a.Length - 1) && bIndex <= (b.Length - 1))
                {
                    if (a[aIndex] <= b[bIndex])
                    {
                        sortedArray[index] = a[aIndex];
                        aIndex++;
                    }
                    else
                    {
                        sortedArray[index] = b[bIndex];
                        bIndex++;
                    }
                    index++;
                }

                else if (aIndex<a.Length)
                {
                    sortedArray[index] = a[aIndex];
                    index++;
                    aIndex++;
                }
                else if (bIndex < b.Length)
                {
                    sortedArray[index] = b[bIndex];
                    index++;
                    bIndex++;
                }
            }

            return sortedArray;


        }




    }
}
