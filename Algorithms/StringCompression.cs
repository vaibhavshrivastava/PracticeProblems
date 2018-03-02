using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class StringCompression
    {

        public string StringCompress(string input)
        {
            int index = 0;
            string temp=null;
            while (index < input.Length )
            {
                int count = 1;
                if(index+1< input.Length)
                if (input[index] == input[index + 1])
                {
                    int innerindex = index;
                    while (innerindex + 1 < input.Length && input[innerindex] == input[innerindex + 1])
                    {
                        count++;
                        innerindex++;
                    }
                    index = innerindex;
                }
                
                
                if (count > 1) 
                {
                    if (string.IsNullOrEmpty(temp))
                        temp = input[index].ToString() + count.ToString();
                    else
                        temp = temp + input[index].ToString() + count.ToString();
                }
                else 
                {
                    if (string.IsNullOrEmpty(temp))
                        temp = input[index].ToString();

                    else
                        temp = temp + input[index].ToString();
                }
                index++;
                
            }
            if (temp.Length >= input.Length)
                temp = input;
            return temp;
        }
  

        public void TestStringCompression()
        {
            Console.WriteLine("Enter string to compress");
            string s = Console.ReadLine();

            string output=StringCompress(s);

            Console.WriteLine("OutPut---->   "+output);
            Console.ReadKey();
        }
    }
}
