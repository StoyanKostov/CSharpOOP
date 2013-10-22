using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class School
{
    // Fields
    private string name;
    private List<StudentsClass> studentsClasses;

    // Properties
    public string Name
    {
        set { this.name = value; }
        get { return this.name; }
    }

    public List<StudentsClass> StudentsClasses
    {
        get { return this.studentsClasses; }
    }

    // Constructor
    public School( string name )
    {
        this.name = name;
        this.studentsClasses = new List<StudentsClass>();
    }

    // Methonds
    public void AddClass(StudentsClass param)
    {
        foreach (var studentsClass in studentsClasses)
        {
            if (studentsClass.UniqueIdentifier == param.UniqueIdentifier)
            {
                throw new ArgumentException("Class identifier must be unique");
            }
        }
        StudentsClasses.Add(param);
    }
}

