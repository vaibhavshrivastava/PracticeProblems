using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week4;

namespace UnitTestProject1
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void TestQuickSort()
        {
            QuickSortClass qs = new QuickSortClass();
            int[] test = new int[] { 11, 2, 3, 56, 34, 89, 4, 78, 90, 12, 13, 16, 56 };
            qs.QuickSort(test, 0, test.Length - 1);
            var result = test;
        }
    }
}




        
