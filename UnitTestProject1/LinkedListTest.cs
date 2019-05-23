using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListNew;

namespace UnitTestProject1
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void TestLinkedListMiddleElement()
        {
            MiddleElement m = new MiddleElement();
            for (int i = 0; i < 2; i++)
            {
                m.Push(i);
            }
           var data= m.GetMiddleElement();
        }
    }
}
