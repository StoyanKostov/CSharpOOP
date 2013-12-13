/// Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
/// Override ToString() to display the information of a person and if age is not specified – to say so. 
/// Write a program to test this functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Tests
    {
        static void Main(string[] args)
        {
            Person someOne = new Person("ForeverYung");
            Person someOneElse = new Person("Aged", 66);

            Console.WriteLine(someOne);
            Console.WriteLine("==================================");
            Console.WriteLine(someOneElse);
        }
    }
}
