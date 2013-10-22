using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student : IPeople
{
    // Fields
    private string name;
    private sbyte classNumber;
    
    // Properties
    public string Name
    {
        set { this.name = value; }
        get { return this.name; }
    }

    public sbyte ClassNumber
    {
        set { this.classNumber = value; }
        get { return this.classNumber; }
    }

    // Constructor
    public Student(string name, sbyte classNumber)
    {
        this.Name = name;
        this.ClassNumber = classNumber;
    }
}