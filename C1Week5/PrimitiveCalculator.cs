using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1Week5
{
    public class PrimitiveCalculator
    {
        public int CalculateMinSteps(int value, int [] table)
        {
            if (table[value] != -1)
            {
                return table[value];
            }
            else
            {
                for (int i = 2; i <= value; i++)
                {
                    var minForIteration = int.MaxValue;
                    if (i % 3 == 0)
                    {
                        var minTemp = 1 + CalculateMinSteps(i / 3,table);
                        if (minTemp < minForIteration)
                        {
                            minForIteration = minTemp;
                        }
                    }
                    if (i % 2 == 0)
                    {
                        var minTemp = 1 + CalculateMinSteps(i / 2, table);
                        if (minTemp < minForIteration)
                        {
                            minForIteration = minTemp;
                        }
                    }
                    var min = 1 + CalculateMinSteps(i - 1, table);
                    if (min < minForIteration)
                    {
                        minForIteration = min;
                    }

                    table[i] = minForIteration;
                }
                var sequence = new List<int>();
                for (int i = value; i > 1; )
                {
                    sequence.Add(i);
                    if (table[i- 1] == (table[i] - 1) )
                    {
                        i = i - 1;
                    }
                    else if (i % 2 == 0 && (table[i / 2] == (table[i] - 1)))
                    {
                        i = i / 2;
                    }
                    else if (i % 3 == 0 && (table[i / 3] == (table[i] - 1)))
                    {
                        i = i / 3;
                    }
                }
                sequence.Reverse();
                foreach (var item in sequence)
                {
                    Debug.Print(item.ToString());
                }

                return table[value];
            }
                
        }

        
    }
}
