// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FilterStudentsByNameAndAge
{
    static void Main(string[] args)
    {
        // Create list to store students
        List<Student> studentCollection = new List<Student>();
        studentCollection.Add(new Student("Kristle", "Dell", 22));
        studentCollection.Add(new Student("Modesto", "Angers", 6));
        studentCollection.Add(new Student("Humberto", "Yoon", 19));
        studentCollection.Add(new Student("Aaron", "Racine", 26));
        studentCollection.Add(new Student("Willodean", "Depaz", 52));
        studentCollection.Add(new Student("Lula", "Seat", 64));
        studentCollection.Add(new Student("Lizzette", "Beecham", 20));
        studentCollection.Add(new Student("Corey", "Whalley", 21));
        studentCollection.Add(new Student("Caitlyn", "Walburn", 99));
        studentCollection.Add(new Student("Williams", "Pflug", 23));
        studentCollection.Add(new Student("Penny", "Rock", 5));
        studentCollection.Add(new Student("Lura", "Hisey", 3));

        // Filter students whose age is between 18 and 24.
        var filteredStudents = from student in studentCollection where (student.Age >= 18) && (student.Age <= 24) select student;

        // Console Output
        foreach (Student student in filteredStudents)
        {
            Console.WriteLine("Student: {0} {1}", student.FirstName, student.LastName);
        }
    }
}