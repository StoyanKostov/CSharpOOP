///Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Extensions
{
    // Sum extension method
    public static T SumExtended<T>(this IEnumerable<T> source)
    {
        dynamic sum = 0;
        foreach (var value in source)
        {
            sum += value;
        }
        return sum;
    }
    
    // Product extension method
    public static T ProductExtended<T>(this IEnumerable<T> source)
    {
        dynamic product = 1;
        
        foreach (var value in source)
        {
            product *= value;
        }

        return product;
    }

    // Find min value  extension method
    public static T MinExtended<T>(this IEnumerable<T> source)
    {
        dynamic min = source.First();
        foreach (var currentValue in source.Skip(1))
        {
            if ( min > currentValue )
            {
                min = currentValue;
            }
        }
        return min;
    }

    // Find max value  extension method
    public static T MaxExtended<T>(this IEnumerable<T> source)
    {
        dynamic max = source.First();
        foreach (var currentValue in source.Skip(1))
        {
            if (max < currentValue)
            {
                max = currentValue;
            }
        }
        return max;
    }

    // Average extension method
    public static T AverageExtended<T>(this IEnumerable<T> source)
    {
        dynamic sum = 0;
        foreach (var value in source)
        {
            sum += value;
        }
        return sum / source.Count();
    }
}


class IEnumerableExtensionMethods
{
    static void Main(string[] args)
    {
        List<int> testCollection = new List<int> { 3, 2, 1, 4, 5 };
        Console.WriteLine( "Sum {0}, Product {1}, Min {2}, Max {3}, Average {4}", 
            testCollection.SumExtended(),
            testCollection.ProductExtended(),
            testCollection.MinExtended(),
            testCollection.MaxExtended(),
            testCollection.AverageExtended() );
    }
}