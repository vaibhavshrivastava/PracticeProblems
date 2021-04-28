using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class GraphMatrix
    {
        // 2D Grid JaggedArray
        public int[][] grid = {
                        new int []{ 2, 1, 1 },
                        new int []{ 1, 1, 0 },
                        new int []{ 0, 1, 1 }
                      };

        public int[,] gridArray;

        bool[,] visited;
        public GraphMatrix()
        { }
        public GraphMatrix( int [][] Grid)
        {
            this.grid = Grid;
            visited = new bool[Grid.Length,Grid[0].Length];
        }
        public GraphMatrix(int[,] GridArray)
        {
            this.gridArray = GridArray;
            visited = new bool[GridArray.GetLength(0), GridArray.GetLength(1)];
        }

        public void RunDFSOnGrid()
        {
            int x = this.grid.Length;
            int y = this.grid[0].Length;
            DFS(0,0);
        }

        public void DFS(int x, int y)
        {
            visited[x,y] = true;
            Console.WriteLine(grid[x][y]);
            //up
            if (IsValid(x + 1, y))
                DFS(x + 1, y);
            // right
            if (IsValid(x, y + 1))
                DFS(x, y + 1);
            //down
            if (IsValid(x-1, y))
                DFS(x-1, y);
            //left
            if (IsValid(x, y-1))
                DFS(x, y-1);
          
        }
        public bool IsValid(int x,int y)
        {

            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length)
                return false;
            else if(visited[x,y])
                return false;
            else return true;
        }


        public int GetConnectedComponents()
        {
            int count = 0;
            for (int i = 0; i < gridArray.GetLength(0); i++)
            {
                for (int j = 0; j < gridArray.GetLength(1); j++)
                {
                    if (visited[i, j]==false && gridArray[i,j]==1)
                    {
                        count++;
                        DFSOnArray(i, j);
                    }
                }
            }
            return count;
        }

        public void DFSOnArray(int x, int y)
        {
            visited[x, y] = true;
 
            if (IsValidOnArray(x + 1, y))
                DFSOnArray(x + 1, y);
            if (IsValidOnArray(x, y + 1))
                DFSOnArray(x, y + 1);
            if (IsValidOnArray(x - 1, y))
                DFSOnArray(x - 1, y);
            if (IsValidOnArray(x, y - 1))
                DFSOnArray(x, y - 1);
        }

        public bool IsValidOnArray(int x, int y)
        {

            if (x < 0 || x >= gridArray.GetLength(0) || y < 0 || y >= gridArray.GetLength(1))
                return false;
            else if (visited[x, y] || gridArray[x, y] == 0)
                return false;
            else return true;
        }

    }
}
