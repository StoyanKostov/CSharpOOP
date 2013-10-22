/// Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FilterArrayByName
{
    static void Main(string[] args)
    {
        // Create list to store students
        List<Student> studentCollection = new List<Student>();
        studentCollection.Add(new Student("Kristle", "Dell"));
        studentCollection.Add(new Student("Modesto", "Angers"));
        studentCollection.Add(new Student("Humberto", "Yoon"));
        studentCollection.Add(new Student("Aaron", "Racine"));
        studentCollection.Add(new Student("Willodean", "Depaz"));
        studentCollection.Add(new Student("Lula", "Seat"));
        studentCollection.Add(new Student("Lizzette", "Beecham"));
        studentCollection.Add(new Student("Corey", "Whalley"));
        studentCollection.Add(new Student("Caitlyn", "Walburn"));
        studentCollection.Add(new Student("Williams", "Pflug"));
        studentCollection.Add(new Student("Penny", "Rock"));
        studentCollection.Add(new Student("Lura", "Hisey"));

        // Filter students  whose first name is before its last name alphabetically
        var filteredSudents = from student in studentCollection where student.FirstName.CompareTo(student.LastName) < 0 select student;

        // Console Output
        foreach (Student student in filteredSudents)
        {
            Console.WriteLine("Student: {0} {1}", student.FirstName, student.LastName);
        }
    }
}