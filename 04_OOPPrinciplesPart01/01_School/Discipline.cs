using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Discipline
{
    // Fields
    private string name;
    private uint lectures;
    private uint exercises;

    // Properties
    public string Name
    {
        set { this.name = value; }
        get { return this.name; }
    }

    public uint Lectures
    {
        set { this.lectures = value; }
        get { return this.lectures; }
    }

    public uint Exercises
    {
        set { this.exercises = value; }
        get { return this.exercises; }
    }

    // Constructor
    public Discipline(string name, uint lectures, uint exercises)
    {
        this.Name = name;
        this.Lectures = lectures;
        this.Exercises = exercises;
    }
}