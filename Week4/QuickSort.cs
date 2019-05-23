using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
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

        public int[] ThreeWayPartition(int[] a, int start, int end)
        {
            int m1 = start;
            int m2 = end;
            int pivot = a[m1];
            int i = start;
            while (i <= m2)
            {
                if (a[i] < pivot)
                {
                    a = Swap(a, i, m1);
                    i++;
                    m1++;
                }
                else if (a[i] > pivot)
                {
                    a = Swap(a, i, m2);
                    m2--;
                }
                else i++;
            }

            int[] indices = new int[2];
            indices[0] = m1;
            indices[1] = m2;
            return indices;
        }

        public int[] Swap(int[]a,int index1, int index2 )
        {
            int temp = a[index2];
            a[index2] = a[index1];
            a[index1] = temp;
            return a;
        }


        public void BetterQuickSort(int[] a, int start, int end)
        {
            if (start < end)
            {
                var indices=ThreeWayPartition(a, start, end);
                BetterQuickSort(a, start, indices[0]-1);
                BetterQuickSort(a, indices[1]+1, end );
            }
        }

        public void QuickSortImproved(int[] a, int start, int end)
        {
            BetterQuickSort(a,  start,  end);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }

        public void QuickSort_Randomized(int[] a, int start, int end)
        {
            QuickSort(a, start, end);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }

    }
}
