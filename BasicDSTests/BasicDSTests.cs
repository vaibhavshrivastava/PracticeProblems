using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C2Week1;
namespace BasicDSTests
{
    [TestClass]
    public class BasicDSTests
    {
        [TestMethod]
        public void CheckBracketsTest1()
        {
            string testInput = "{[]}()";
            CheckBracket cb = new CheckBracket();
            var result=cb.Check_Brackets(testInput);
            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void CheckBracketsTest2()
        {
            string testInput = "foo(bar);";
            CheckBracket cb = new CheckBracket();
            var result = cb.Check_Brackets(testInput);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void CheckBracketsTest3()
        {
            string testInput = "foo(bar[i);";
            CheckBracket cb = new CheckBracket();
            var result = cb.Check_Brackets(testInput);
            Assert.AreEqual(result, 10);
        }


        [TestMethod]
        public void TreeHeightTest()
        {
            int[] input = new int[] { -1, 0, 4, 0, 3 };
            MyTree myTree = new MyTree();
            myTree.CreateTree(input);

            var result = myTree.CalculateTreeHeight(myTree.root);
        }
    }
}
