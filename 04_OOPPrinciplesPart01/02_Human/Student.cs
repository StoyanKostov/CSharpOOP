using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : Human
{
    // Fields
    private int grade;

    // Properties
    public int Grade
    {
        set { this.grade = value; }
        get { return this.grade; }
    }

    // Constructor
    public Student(string firstName, string lastName, int grade)
        : base(firstName, lastName)
    {
        this.Grade = grade;
    }
}

