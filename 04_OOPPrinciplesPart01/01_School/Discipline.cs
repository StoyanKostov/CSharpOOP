using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Discipline : ICommentable
{
    // Fields
    private string name, comments;
    private uint lectures, exercises;

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
    public Discipline(string name, uint lectures, uint exercises, string comments = null)
    {
        this.Name = name;
        this.Comments = comments;
        this.Lectures = lectures;
        this.Exercises = exercises;
    }
}