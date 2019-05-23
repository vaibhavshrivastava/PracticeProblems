using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class QuickSortClass
    {

        public void QuickSort(int[] a, int start, int end)
        {
            //Base Contdition
            //GetPartition 

            //QuickSort(Array, start, Pindex-1)
            //QuickSort(Array, Pindex+1, end)
        
            if (start<end)
            {
                var index = Partition(a, start, end);
                QuickSort(a, start, index - 1);
                QuickSort(a, index + 1, end);
            }
}
            
        public int Partition(int[]a, int start, int end)
        {
            int pivot = end;
            int pIndex = start;
            for (int i = start; i <= end-1; i++)
            {
                if (a[i] < a[pivot])
                {
                    int tmp = a[i];
                    a[i] = a[pIndex];
                    a[pIndex] = tmp;
                    pIndex++;
                }
            }
            int temp = a[pivot];
            a[pivot] = a[pIndex];
            a[pIndex] = temp;
      
            return pIndex;
        }

        
    }
}
