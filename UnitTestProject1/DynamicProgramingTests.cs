using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week5;

namespace UnitTestProject1
{
    [TestClass]
    public class DynamicProgramingTests
    {
        [TestMethod]
        public void TestmoneyChangeDynamic()
        {
            MoneyChange mc = new MoneyChange();
            int testValue = 34;
            var table = new int[testValue+1];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = -1;
            }

            var coins = new int[] { 1, 3, 4 };
            var result_old = mc.MoneyChangeRecursive(34, coins);
            var result=mc.MoneyChangeDynamic(testValue, coins, table);
        }
    }
}
