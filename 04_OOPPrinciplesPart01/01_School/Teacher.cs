using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Teacher : IPeople
{
    // Fields
    private string name;
    private List<Discipline> disciplines;

    // Properties
    public string Name
    {
        set { this.name = value; }
        get { return this.name; }
    }

    public List<Discipline> Disciplines
    {
        get { return this.disciplines; }
    }

    // Constructor
    public Teacher(string name)
    {
        this.Name = name;
        this.disciplines = new List<Discipline>();
    }

    // Methods
    public void AddDiscipline(Discipline discipline)
    {
        this.disciplines.Add(discipline);
    }
}