/// Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
/// Rewrite the same with LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LambdaExpressions
{
    static void Main(string[] args)
    {
        // Create list to store students (Student class referenced from 04_FilterStudentsByNameAndAge)
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

        // Sort students with Lambda expression by first name and last name in descending order
        var sortedStudentsLambda = studentCollection.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

        // Sort students with LINQ by first name and last name in descending order
        var sortedStudentsLINQ = from student in studentCollection orderby student.FirstName descending, student.LastName descending select student;

        // Console Output
        Console.WriteLine("Sorted students with Lambda expression by first name and last name in descending order");
        foreach (Student student in sortedStudentsLambda)
        {
            {
                Console.WriteLine("Student: {0} {1}", student.FirstName, student.LastName);
            }
        }

        Console.WriteLine("\nSorted students with LINQ by first name and last name in descending order");
        foreach (Student student in sortedStudentsLINQ)
        {
            Console.WriteLine("Student: {0} {1}", student.FirstName, student.LastName);
        }
    }
}