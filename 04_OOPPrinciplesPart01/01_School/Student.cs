using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : IPeople, ICommentable
{
    // Fields
    private string name, comments;
    private sbyte classNumber;
    
    // Properties
    public string Name
    {
        set { this.name = value; }
        get { return this.name; }
    }

    public string Comments
    {
        set { this.comments = value; }
        get { return this.comments; }
    }

    public sbyte ClassNumber
    {
        set { this.classNumber = value; }
        get { return this.classNumber; }
    }

    // Constructor
    public Student(string name, sbyte classNumber, string comments = null)
    {
        this.Name = name;
        this.Comments = comments;
        this.ClassNumber = classNumber;
    }
}