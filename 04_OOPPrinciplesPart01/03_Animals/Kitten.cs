using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kitten : Cats, ISound
{
    // Constructor
    public Kitten(sbyte age, string name)
        : base(age, name, Sex.female)
    { 
    }

    // Methods
    public void produceSound()
    {
        Console.WriteLine("kittie");
    }

}