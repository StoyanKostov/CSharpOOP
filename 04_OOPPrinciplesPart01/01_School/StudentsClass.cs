using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentsClass
{
    // Fields
    private string uniqueIdentifier;
    private List<Student> students;
    private List<Teacher> teachers;

    // Properties
    public string UniqueIdentifier
    {
        set { this.uniqueIdentifier = value; }
        get { return this.uniqueIdentifier; }
    }

    public List<Student> Students
    {
        get { return this.students; }
    }

    public List<Teacher> Teachers
    {
        get { return this.teachers; }
    }

    // Constructor
    public StudentsClass(string uniqueIdentifier)
    {
        this.UniqueIdentifier = uniqueIdentifier;
        this.students = new List<Student>();
        this.teachers = new List<Teacher>();
    }

    // Methods
    public void AddStudent(Student student)
    {
        this.students.Add(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        this.teachers.Add(teacher);
    }
}

