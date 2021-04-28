using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MultiDimentionalArray
    {
        public int[,] TwoDGrid;
        public int[,,] ThreeDGrid;

        public int[][] jaggedArray;// Jagged array means array of array, possibly of different sizes 

        public void ADDTwoDArray(int rows, int columns)
        {
            TwoDGrid = new int[rows, columns]; 
            // Initialization , without specifying the dimentions 
            // TwoDGrid = new int[,]{{1,2}, {3,4}, {5,6}};  

            // Initialization, with specifying the dimentions 
            // TwoDGrid= new int[2,3]{{1,2},{3,4}, {5,6}};
        }

        public void ADDTwoDArray(int x, int y, int z)
        {
            ThreeDGrid = new int[x, y, z];
        }


        public void AddJaggedArray(int numberOfArrays)
        {
            jaggedArray = new int[numberOfArrays][];

            /* In place initialization 
             * 
             * jaggedArray = new int[][]
             *                      {
             *                      new int[]{1,2,3,4},
             *                      new int[]{5,6,7},
             *                      new int[]{8,9}
             *                      };
             *                      
             *                      OR
             *                      
             *                      jaggedArray = 
             *                      {
             *                      new int[]{1,2,3,4},
             *                      new int[]{5,6,7},
             *                      new int[]{8,9}
             *                      };
             * 
             * */

        }

    }
}
