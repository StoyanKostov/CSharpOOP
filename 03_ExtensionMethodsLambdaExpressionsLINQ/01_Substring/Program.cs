/// Implement an extension method Substring(int index, int length) for the class StringBuilder
/// that returns new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubstringMethod;

class SubstringTest
{

    static void Main(string[] args)
    {
        StringBuilder mySb = new StringBuilder("HelloExtensionMethods");
        try
        {
            Console.WriteLine(mySb.Substring(5, 9));
            //Console.WriteLine(mySb.Substring(-5, 9));
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex.Message);
        }

        StringBuilder sbTest01 = mySb.Substring(5, 9);

    }
}