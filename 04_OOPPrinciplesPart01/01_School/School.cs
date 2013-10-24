using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class School
{
    // Fields
    private string name;
    private Dictionary<string, StudentsClass> studentsClasses;

    // Properties
    public string Name
    {
        set { this.name = value; }
        get { return this.name; }
    }

    public Dictionary<string, StudentsClass> StudentsClasses
    {
        get { return this.studentsClasses; }
    }

    // Constructor
    public School( string name )
    {
        this.name = name;
        this.studentsClasses = new Dictionary<string, StudentsClass>();
    }

    // Methonds
    public void AddClass(StudentsClass param) // Check for unique identifier
    {
        if (studentsClasses.ContainsKey(param.UniqueIdentifier))
        {
            throw new ArgumentException("Class identifier must be unique");
        }
        else
        {
            StudentsClasses.Add(param.UniqueIdentifier, param);
        }
    }
}

