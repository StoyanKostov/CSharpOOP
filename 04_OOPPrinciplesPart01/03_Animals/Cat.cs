using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat : Animals, ISound
{
    // Constructor
    public Cat(sbyte age, string name, Sex sex)
        : base(age, name, sex)
    {   
    }

    // Methods
    public void produceSound()
    {
        Console.WriteLine("Miau");
    }

}
