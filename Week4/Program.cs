using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinarySearch bs = new BinarySearch();

            //bs.TestBinarySearch();
            //    var value=bs.SearchElement(new int[] { 3, 4, 5, 6, 7, 8, 9, 10, 11,12,33,44,55,66,77,88,99}, 55, 0, 16);
            //    Console.WriteLine(value);

            /*
            MajorityElement mj = new MajorityElement();
            var val =mj.FindMaxMajority(new int []{1,1,1,2,3,4,3,4,5,6,7,8,1,1,1,1});
            var val2 = mj.FindMaxMajority(new int[] {1,1,2,2,2});




            MergeSortProgram mgp = new MergeSortProgram();
            var result=  mgp.MergeSort(new int[] { 4, 5, 2, 3, 1, 9, 7, 12, 11, 13, 14, 6, 15,99,98,44,87,89,23,56 });
            */

            /*
            QuickSortClass qs = new QuickSortClass();
            int[] test = new int[] { 1,1,1,1,1,1,1,1,4, 5, 2, 3, 1, 9, 7, 12, 11, 13, 14, 6, 15, 99, 98, 44, 87, 89, 23, 56 };
            qs.QuickSort_Randomized(test, 0, test.Length - 1);

            qs.QuickSortImproved(test, 0, test.Length-1);
            */

            Inversions inv = new Inversions();
            inv.TestInversionsMergeSort();
            inv.TestInversion();
        }
    }
}
