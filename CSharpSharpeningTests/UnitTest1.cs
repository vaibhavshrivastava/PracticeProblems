using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CSharpSharpeningTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void  WithoutYield()
        {

            var someNumbers = Enumerable.Range(1, 10);

            var evens = GetEvenNumbersUsingYield(someNumbers);
            foreach (var even in evens)
            {
                Debug.WriteLine("OutPut:" + even);
                if (even == 6)
                {
                    break;
                }
            }
        }

        public IEnumerable<int> GetEvenNumbersUsingYield(IEnumerable<int> e)
        {
            foreach (var item in e)
            {
                Debug.WriteLine("Processing Number" + item);
                if (item % 2 == 0)
                {
                   // Debug.WriteLine("Printing even numbers"+item);
                    yield return item;
                }

            }
        }
    }
}
