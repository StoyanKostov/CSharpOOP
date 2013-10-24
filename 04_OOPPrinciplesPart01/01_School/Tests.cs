/// We are given a school. In the school there are classes of students.
/// Each class has a set of teachers. Each teacher teaches a set of disciplines. Students have name and unique class number. 
/// Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people.
/// Students, classes, teachers and disciplines could have optional comments (free text block).
///	Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tests
{
    static void Main(string[] args)
    {
        // School
        School mySchool = new School("Maksim Gorki");

        // Add Class to School
        mySchool.AddClass(new StudentsClass("Uniqe"));

        // Add Student to Class
        mySchool.StudentsClasses["Uniqe"].AddStudent(new Student("Me", 27)); // Comment is optional

        // Add Teacher to Class
         mySchool.StudentsClasses["Uniqe"].AddTeacher(new Teacher("Klasniya"));

        // Add Dicipline to Teacher in Class
        mySchool.StudentsClasses["Uniqe"].Teachers[0].AddDiscipline(new Discipline("Math", 2, 4));

        
        // Console Output
        Console.WriteLine(mySchool.Name);
        Console.WriteLine(mySchool.StudentsClasses["Uniqe"].UniqueIdentifier);
        Console.WriteLine(mySchool.StudentsClasses["Uniqe"].Students[27].Name);
        Console.WriteLine(mySchool.StudentsClasses["Uniqe"].Teachers[0].Name);
        Console.WriteLine(mySchool.StudentsClasses["Uniqe"].Teachers[0].Disciplines[0].Name);

    }
}