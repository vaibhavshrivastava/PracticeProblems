using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            var result=SortDups(new int[] { 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2 });
            countOccurences(new int[] { 1,1});
        }


        public static int[] SortDups(int [] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public static void countOccurences(int[] arr)
        {
            /*
            * Basic way - O(n) space and O(n) time .
            * Map<Integer, Integer> map = new HashMap<>();
            * for(int i : arr)
            * map.put(i, map.getOrDefault(i,0) + 1);
            * print(map);
            */
            //Following approach will make use of modified binary search to reduce the time complexity to approximately O(logn).

            var map = new Dictionary<int, int>();
            binarySearch(arr, 0, arr.Length - 1, map);
            print(map);
        }

        private static void binarySearch(int[] arr, int start, int end, Dictionary<int, int> map)
        {
            if (start > end)
            {
                return;
            }
            else
            {
                int mid = start + (end - start) / 2;
                if (arr[start] == arr[end])
                {
                    int value = -1;
                    map.TryGetValue(arr[start], out value);
                    if (value != -1)
                    {
                        map[arr[start]] = value + end - start + 1;
                    }
                    else
                    {
                        map.Add(arr[start], value + end - start + 1);
                    }
                }
                else
                {
                    binarySearch(arr, start, mid, map);
                    binarySearch(arr, mid + 1, end, map);
                }
            }
        }

        private static void print(Dictionary<int, int> map)
        {
            foreach (var entry in map)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }
        }
    }


    public class QuickSort
    {
        public List<int> quicksort(List<int> a)
        {
            Random r = new Random();

            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            if (a.Count <= 1)
                return a;
            int pos = r.Next(a.Count);

            int pivot = a[pos];
            a.RemoveAt(pos);
            foreach (int x in a)
            {
                if (x <= pivot)
                {
                    less.Add(x);
                }
                else
                {
                    greater.Add(x);
                }
            }
            return concat(quicksort(less), pivot, quicksort(greater));
        }

        public List<int> concat(List<int> less, int pivot, List<int> greater)
        {
            List<int> sorted = new List<int>(less);
            sorted.Add(pivot);
            foreach (int i in greater)
            {
                sorted.Add(i);
            }

            return sorted;
        }

        


    }
}
