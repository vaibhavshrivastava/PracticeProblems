using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{

    //Imnplement an algorithm to determine if a string has all unique characters 
    class Array11
    {
        static void Main1(string[] args)
        {
            // CallIsUnique();
            // CallIsPermutation();
            int x = SumoftwodimentionalArray();
            Console.WriteLine("Sum is  {0}",x);
            Console.ReadKey();
        }


        private static bool IsUnique(string input)
        {
            //Assuming given string is an ASCII string 
            bool[] str = new bool[128];
            if (input.Length > 128)
                return false;
            for (int i = 0; i < input.Length; i++)
            {
                int value = input[i];
                if (str[value])
                {
                    return false;
                }
                str[value] = true;
            }
            return true;
         }

        private static void CallIsUnique()
        {
            Console.WriteLine("Enter input string \n");
            string input = Console.ReadLine();
            Console.WriteLine(IsUnique(input).ToString());
            Console.ReadLine();
        }

        // Given two strings , write a method to decide if one is a permutation of the other
        private static bool IsPertumation(string a , string b)
        {
            bool[] str = new bool[128];
            for (int i = 0; i < a.Length; i++)
            {
                int val = a[i];
                str[val] = true;
            }

            for (int i = 0; i < b.Length; i++)
            {
                int val = b[i];
                if (!str[val])
                return false;

            }
            return true;
        }

        private static void CallIsPermutation()
        {
            Console.WriteLine("Enter first string");
            string a=Console.ReadLine();
            Console.WriteLine("Enter second string");
            string b = Console.ReadLine();
            Console.WriteLine(IsPertumation(a, b));
            Console.ReadLine();

        }

        public static int SumoftwodimentionalArray()
        {
            
           int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
                    int sum = int.MinValue;
                    for (int j = 0; j < 4; j++)
                    {
                
                        for (int i = 0; i < 4; i++)
                        {
                            int temp = -63;
                            temp = arr[i][j] + arr[i + 1][j] + arr[i + 2][j] + arr[i + 1][j + 1] + arr[i][j + 2] + arr[i + 1][j + 2] + arr[i + 2][j + 2];
                    if (temp > sum)
                    {
                        sum = temp;
                    }
                        }

                    
                    }
                return sum;
                
            }









    }

            
            

    
}
