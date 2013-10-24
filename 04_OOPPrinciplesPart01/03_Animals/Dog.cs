using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dog : Animals, ISound
{
    // Constructor
    public Dog(sbyte age, string name, Sex sex)
        : base(age, name, sex)
    { 
    }

    // Methods
    public void produceSound()
    {
        Console.WriteLine("Bau");
    }

}