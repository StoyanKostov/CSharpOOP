/// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DivisibleBy7And3
{
    static void Main(string[] args)
    {
        // Create array to do test
        List<int> inputArray = new List<int>{ 1, 21, 3, 4, 5, 42, 8 };

        // lambda expression
        var outputArrayLambda = inputArray.FindAll(number => ((number % 3) == 0) && ((number % 7) == 0));

        // LINQ
        var outputArrayLINQ = from number in inputArray where (number % 3 == 0) && (number % 7 == 0) select number;

        //Console output
        Console.WriteLine("Numbers that are divisible by 7 and 3 (lambda expression)");
        foreach (var item in outputArrayLambda)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nNumbers that are divisible by 7 and 3 (LINQ)");
        foreach (var item in outputArrayLINQ)
        {
            Console.WriteLine(item);
        }
    }
}