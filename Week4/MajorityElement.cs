using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class MajorityElement
    {
        //https://mrdupin.github.io/dnc-majority-element/


        public int FindMaxMajority(int [] arr)
        {
            // IF array has just two elements, compare those two
            if (arr.Length == 2)
            {
                if (arr[0] == arr[1])
                    return arr[0];
                else
                    return -1;
            }
            // else if array has just one element it will be the max majority element 
            else if 
                (arr.Length==1)
                    return arr[0];

            //Find the max majority element
            var firstHalf = new int[arr.Length/2];
            var secondHalf = new int[(arr.Length / 2)+1];
            Array.Copy(arr, firstHalf, arr.Length / 2);
            Array.Copy(arr, arr.Length/2, secondHalf,0, arr.Length-(arr.Length/2));

            var element1 = FindMaxMajority(firstHalf);
            var element2 = FindMaxMajority(secondHalf);

            if (element1 < 0 & element2 < 0)
                return 0;
            else if (element1 >= 0 & element2 < 0)
                return 1;
            else if (element1 < 0 & element2 >= 0)
                return 1;

            else if (element1 == element2)
                return 1;
            else return 0;
             
        }


    }
}
