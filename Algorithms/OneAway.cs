using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class OneAway
    {

        //public bool CheckIfOneAway(string str1, string str2)
        //{
        //    bool result;
        //    if (str1.Length > str2.Length)
        //    {
        //         result = checkifCharRemoved(str1, str2);
        //    }
        //    else if (str2.Length > str2.Length)
        //    {
        //         result = checkifCharRemoved(str2, str1);
        //    }
        //    else if (str2.Length == str2.Length)
        //    {
        //        result = checkifCharReplaced(str1, str2);
        //    }
        //    return result;
           
        //}

        private bool checkifCharRemoved(string str1, string str2)
        {
            int sum1 = 0;
            int sum2 = 0;
            foreach (var item in str1)
            {
                sum1 = sum1 + item;
            }

            foreach (var item in str2)
            {
                sum2 = sum2 + item;
            }

            int charValue = sum1 - sum2;
            char removedChar = (char)charValue;

            for (int i = 0; i < str2.Length; i++)
            {
                string temp = str2.Insert(i, removedChar.ToString());
                if (temp == str1)
                    return true;
            }
            return false;
        }


        public static bool OneEditInsert(String s1, String s2)

        {
            int index1 = 0;

            int index2 = 0;

            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }

            return true;
        }
    }
}
