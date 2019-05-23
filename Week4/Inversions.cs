using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class Inversions
    {
        public void Getinversions(int[] a)
        {
            int i = 0;
            int inversionCounts = 0;
            while (i < a.Length)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[j] < a[i])
                    {
                        Console.WriteLine(i + " "+ j + "Values "+ a[i]+" "+ a[j]);
                        inversionCounts++;
                    }
                }
                i++;
            }
            Console.WriteLine("Total Counts => "+inversionCounts);
        }

        public void TestInversion()
        {
            int[] a = new int[] { 2, 3, 9, 2, 9 };
            Getinversions(a);
        }


        public InversionCount SortCount(int[] a)
        {
            InversionCount ic=new InversionCount();
            List<int> firsthalf = new List<int>();
            List<int> secondhalf = new List<int>();
            int middle = a.Length / 2;

            if (a.Length == 1)
            {
                return ic=new InversionCount { sortedArray = a, inversionCount = 0 };
            }
            else
            {
                for (int i = 0; i < middle; i++)
                {
                    firsthalf.Add(a[i]);
                }

                for (int j = middle; j < a.Length; j++)
                {
                    secondhalf.Add(a[j]);
                }

                 var ic1= SortCount(firsthalf.ToArray());
                 ic.inversionCount += ic1.inversionCount;

                 var ic2 = SortCount(secondhalf.ToArray());
                 ic.inversionCount += ic2.inversionCount;

                 var ic3 = MergeInversion(ic1.sortedArray, ic2.sortedArray);
                 ic3.inversionCount += ic.inversionCount;
                 return ic3;
                
            }
        }

        public InversionCount MergeInversion(int[] left, int[] right)
        {
            InversionCount icTemp = new InversionCount();
            List<int> SortedList = new List<int>();
            var leftList = left.ToList<int>();
            var rightList = right.ToList<int>();

            while (leftList.Count > 0 || rightList.Count > 0)
            {
                if (leftList.Count > 0 && rightList.Count > 0)
                {
                    if (leftList.First<int>() > rightList.First<int>())
                    {
                        SortedList.Add(rightList.First<int>());
                        rightList.Remove(rightList.First<int>());
                        foreach (var item in leftList)
                        {
                            icTemp.inversionCount++;
                        }
                    }
                    else
                    {
                        SortedList.Add(leftList.First<int>());
                        leftList.Remove(leftList.First<int>());
                    }
                }
                else if (leftList.Count == 0)
                {
                    
                        SortedList.Add(rightList.First<int>());
                        rightList.Remove(rightList.First<int>());
                    
                    
                }

                else if (rightList.Count == 0)
                {
                        SortedList.Add(leftList.First<int>());
                        rightList.Remove(leftList.First<int>()); 
                }
            }

            icTemp.sortedArray = SortedList.ToArray();
            return icTemp;
        }

        public void TestInversionsMergeSort()
        {
            int[] a = new int[] { 2,3,9,2,9 };
            var result = SortCount(a);
            Console.WriteLine(result);
                
        }
    }

    public class InversionCount
    {
        public int[] sortedArray;
        public int inversionCount;
    }


  

}



/* Previous implementation
 *  public int[] Merge(int[] a, int[] b)
        {
            List<int> SortedList = new List<int>();
            int aIndex = 0;
            int bIndex = 0;
            if (a.Length == 0)
            {
                return b;
            }
            else if (b.Length == 0)
            {
                return a;
            }
            else
            {

                while (aIndex < a.Length || bIndex < b.Length)
                {
                    
                    if (aIndx == a.Length)
                    {
                        SortedList.Add(b[bIndex]);
                        bIndex++;
                        continue;
                    }
                    else if (bIndex == b.Length)
                    {
                        SortedList.Add(a[aIndex]);
                        aIndex++;
                    }
                    else if (a[aIndex] < b[bIndex])
                    {
                        SortedList.Add(a[aIndex]);
                        aIndex++;
                    }
                    else
                    {
                        SortedList.Add(b[bIndex]);
                        bIndex++;
                    }
                }
                 
            }
            return SortedList.ToArray();
        }



     public int[] InversionsWithMerge(int[] a)
        {
            List<int> firsthalf = new List<int>();
            List<int> secondhalf = new List<int>();
            int middle = a.Length / 2;
            if (a.Length == 1)
                return a;
            else
            {
                for (int i = 0; i < middle; i++)
                {
                    firsthalf.Add(a[i]);
                }

                for (int j = middle; j < a.Length; j++)
                {
                    secondhalf.Add(a[j]);
                }

                InversionsWithMerge(firsthalf.ToArray());
                InversionsWithMerge(secondhalf.ToArray());
                return Merge(firsthalf.ToArray(),secondhalf.ToArray());
            }
        }


        public int[] Merge(int[] a, int[] b)
        {
            InversionCount ic = new InversionCount();
            int inversionCount = 0;
            List<int> SortedList = new List<int>();
            int aIndex = 0;
            int bIndex = 0;
            if (a.Length == 0)
            {
                return b;
            }
            else if (b.Length == 0)
            {
                return a;
            }
            else
            {
                while (aIndex < a.Length || bIndex < b.Length)
                {
                    if (aIndex < a.Length && bIndex < b.Length)
                    {
                        if (a[aIndex] < b[bIndex])
                        {
                            SortedList.Add(a[aIndex]);
                            aIndex++;
                        }
                        else
                        {
                            SortedList.Add(b[bIndex]);
                            bIndex++;
                            inversionCount++;
                        }
                    }

                    else
                    {
                        if (aIndex == a.Length)
                        {
                            SortedList.Add(b[bIndex]);
                            bIndex++;
                        }
                        else if (bIndex == b.Length)
                        {
                            SortedList.Add(a[aIndex]);
                            aIndex++;
                        }
                    }
                }
                 
            }
            return SortedList.ToArray();
        }

        */
