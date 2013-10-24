using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Teacher : IPeople, ICommentable
{
    // Fields
    private string name, comments;
    private List<Discipline> disciplines;

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

    public List<Discipline> Disciplines
    {
        get { return this.disciplines; }
    }

    // Constructor
    public Teacher(string name, string comments = null)
    {
        this.Name = name;
        this.disciplines = new List<Discipline>();
        this.Comments = comments;
    }

    // Methods
    public void AddDiscipline(Discipline discipline)
    {
        this.disciplines.Add(discipline);
    }
}