using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SpiralArray
    {
        public void PrintSpiralArray(int[,] inputArray)
        {
            int top = 0;
            int bottom = inputArray.GetLength(0);

            int left = 0;
            int right = inputArray.GetLength(1);

            int dir = 1;
            while (bottom > top && right > left)
            {
                if (dir == 1)
                {
                    for (int i = left; i < right; i++)
                    {
                        Console.WriteLine(inputArray[top,i]);
                    }
                    top++;
                    dir = 2; 
                }

                else if (dir == 2)
                {
                    for (int i = top; i < bottom; i++)
                    {
                        Console.WriteLine(inputArray[i,right-1]);
                    }
                    right--;
                    dir = 3;
                }

                else if (dir == 3)
                {
                    for (int i = right-1; i >= left; i--)
                    {
                        Console.WriteLine(inputArray[bottom-1,i]);
                    }
                    bottom--;
                    dir = 4;
                }
                else if (dir == 4)
                {
                    for (int i = bottom-1; i >= top; i--)
                    {
                        Console.WriteLine(inputArray[i,left]);
                    }
                    left++;
                    dir = 1;
                }

            }
        }

    }
}
