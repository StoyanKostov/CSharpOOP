using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StudentsClass
{
    // Fields
    private string uniqueIdentifier;
    private Dictionary<int, Student> students;
    private List<Teacher> teachers;

    // Properties
    public string UniqueIdentifier
    {
        set { this.uniqueIdentifier = value; }
        get { return this.uniqueIdentifier; }
    }

    public Dictionary<int, Student> Students
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
        this.students = new Dictionary<int, Student>();
        this.teachers = new List<Teacher>();
    }

    // Methods
    public void AddStudent(Student student)
    {
        if (students.ContainsKey(student.ClassNumber)) // Check for  unique class number
        {
            throw new ArgumentException("Student Class Number must be unique");
        }
        else
        {
            students.Add(student.ClassNumber, student);
        }
    }

    public void AddTeacher(Teacher teacher)
    {
        this.teachers.Add(teacher);
    }
}

