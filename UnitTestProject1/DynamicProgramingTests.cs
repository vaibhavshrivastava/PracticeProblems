using System;
using System.Diagnostics;
using C1Week5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week5;

namespace UnitTestProject1
{
    [TestClass]
    public class DynamicProgramingTests
    {
        [TestMethod]
        public void MoneyChangeDynamicTest()
        {
            MoneyChange mc = new MoneyChange();
            int testValue =5000;
            var table = new int[testValue+1];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = -1;
            }

            var coins = new int[] { 1, 3, 4 };
            //var result_old = mc.MoneyChangeRecursive(34, coins);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = mc.MoneyChangeDynamic(testValue, coins, table);
            watch.Stop();
            Debug.Print("Total time by method 1" + watch.ElapsedMilliseconds + "  Result-->"+result);
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            var result2 = mc.MoneyChangeDynamic2(testValue, coins, table);
            watch2.Stop();
            Debug.Print("Total time by method 1" + watch2.ElapsedMilliseconds + "  Result-->" + result2);
        }

        [TestMethod]
        public void PrimitiveCalculatorTest()
        {
            PrimitiveCalculator Pc = new PrimitiveCalculator();
            var testValue = 96234;

            var table = new int[testValue + 1];

            table[0] = 0;
            table[1] = 0;
            for (int i = 2; i < table.Length; i++)
            {
                table[i] = -1;
            }
            var testResult3 = Pc.CalculateMinSteps(testValue,table);
        }
    }
}
