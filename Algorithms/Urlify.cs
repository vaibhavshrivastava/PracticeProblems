using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Urlify
    {


      
        public string UrlifyString(string input)
        {
                input = input.Trim();
                input=input.Replace(" ", "%20");
                return input;
        }
    }

 
}
