using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    //Starting with C# 6, read-only properties can implement the get accessor as an expression-bodied member
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Isabelle", "Butts");
            Console.WriteLine(person.Name);
        }
    }

    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;
        }

        public string Name => $"{firstName} {lastName}";
    }
}
