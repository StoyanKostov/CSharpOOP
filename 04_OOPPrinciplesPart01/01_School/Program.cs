using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Teacher someTeacher = new Teacher("someone");
        someTeacher.AddDiscipline(new Discipline("Biology", 3, 5));

        Teacher otherTeacher = new Teacher("someoneOther");
        otherTeacher.AddDiscipline(new Discipline("Math", 12, 50));

        Console.WriteLine(otherTeacher.Disciplines[0].Name);

        School mySchool = new School("Maksim Gorki");
        mySchool.AddClass(new StudentsClass("Uniqe"));
        Console.WriteLine(mySchool.StudentsClasses[0].UniqueIdentifier);
        mySchool.AddClass(new StudentsClass("Uniqe"));
        Console.WriteLine(mySchool.StudentsClasses[1].UniqueIdentifier);
    }
}