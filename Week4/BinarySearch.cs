using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class BinarySearch
    {
        public int GetElementIndex(int [] input, int item,int start, int end)
        {
            int lenght = (end - start) ;
            if (lenght == 1)
            {
                if (input[start] == item)
                    return start;
                else if (input[end] == item)
                    return end;
                else return -1;
            }
            else
            {
                if (input[start + (lenght / 2)] > item)
                {
                    return GetElementIndex(input, item, start, start + (lenght / 2));
                }
                else
                   return GetElementIndex(input, item, start + (lenght / 2), end);
            }
        }

        // This Function should go inside main
        public void TestBinarySearch()
        {
            var input1 = Console.ReadLine();
            string[] InputArr = input1.Split(' ');
            var input=GetArrayElements(InputArr);

            var input2 = Console.ReadLine();
            string[] searchItemArray = input2.Split(' ');
            var SearchIteminput = GetArrayElements(searchItemArray);

            foreach (var item in SearchIteminput.arr)
            {
                Console.Write(GetElementIndex(input.arr,item,0, input.arr.Length-1)+" ");
            }

        }


        public InputDetails GetArrayElements(string [] arr)
        {
            int[] inputArray = Array.ConvertAll(arr, s => int.Parse(s));
            int numberOfElement = inputArray[0];
            InputDetails input = new InputDetails(numberOfElement);
            for (int i = 1; i < inputArray.Length; i++)
            {
                input.arr[i - 1] = inputArray[i];
            }

            return input;
        }
    }

    public class InputDetails
    {
        public int elementCount;
        public int[] arr;
        public InputDetails(int numberOfElements)
        {
            elementCount = numberOfElements;
            arr = new int[numberOfElements];
        }
    }
}
