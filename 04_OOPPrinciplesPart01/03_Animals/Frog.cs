using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Frog : Animals, ISound
{
    // Constructor
    public Frog(sbyte age, string name, Sex sex)
        : base(age, name, sex)
    { 
    }

    // Methods
    public void produceSound()
    {
        Console.WriteLine("Kva");
    }

}
