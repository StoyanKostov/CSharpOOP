using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Sex
{
    male,
    female
}

public class Animals
{
    // Fields
    private sbyte age;
    private string name;
    private Sex sex;

    // Properties
    public sbyte Age
    {
        set { this.age = value; }
        get { return this.age; }
    }

    public string Name
    {
        set { this.name = value; }
        get { return this.name; }
    }

    public Sex Sex
    {
        set { this.sex = value; }
        get { return this.sex; }
    }

    // Constructor
    public Animals(sbyte age, string name, Sex sex)
    {
        this.Age = age;
        this.Name = name;
        this.Sex = sex;
    }
}