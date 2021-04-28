using Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOutPut
{
    public class TestGraphMatrix
    {
        GraphMatrix testObj = new GraphMatrix();
        public void Test_GraphMatrix_DFS()
        {
            var testJaggedArray = new int[][]
                            {
                                new int []{ 1,2,3},
                                new int []{ 4,5,6},
                                new int []{ 7,8,9}
                            };

            testObj.grid= testJaggedArray;
            testObj.RunDFSOnGrid();
            
        }


        public void Test_ConnectedComponents()
        {
            var testGrid = new int[,]
                {
                    { 1,1,1,1,1,1 },
                    { 1,0,1,1,0,1 },
                    { 1,0,0,0,0,1 },
                    { 1,0,1,1,0,1 }
                };
            var testObj = new GraphMatrix(testGrid);

            var result=testObj.GetConnectedComponents();
        }
    }
}
