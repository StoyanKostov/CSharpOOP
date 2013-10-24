using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tomcat : Cats, ISound
{
    // Constructor
    public Tomcat(sbyte age, string name)
        : base(age, name, Sex.male)
    { 
    }

    // Methods
    public void produceSound()
    {
        Console.WriteLine("Tomcaaaaaaaaaaaaaat");
    }

}