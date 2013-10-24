/// Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. 
/// Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
/// that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy. 
/// Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
/// Initialize a list of 10 workers and sort them by money per hour in descending order.
/// Merge the lists and sort them by first name and last name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tests
{
    static void Main(string[] args)
    {
        // Students
        List<Student> students = new List<Student>();
        students.Add(new Student("Aleks", "Aleksiev", 8));
        students.Add(new Student("Bogdan", "Bachkov", 1));
        students.Add(new Student("Milana", "Argirova", 5));
        students.Add(new Student("Petur", "Vulev", 7));
        students.Add(new Student("Aleksander", "Filkov", 11));
        students.Add(new Student("Mihcail", "Paskalev", 3));
        students.Add(new Student("Ida", "Tersieva", 1));
        students.Add(new Student("Bilyana", "Miteva", 0));
        students.Add(new Student("Yanica", "Ilieva", 4));
        students.Add(new Student("Bianka", "Dimitrova", 6));

        // Sort students by grade in ascending order
        var sortedStudents = from student in students orderby student.Grade select student;

        Console.WriteLine("Sorted students by grade in ascending order");
        foreach (var student in sortedStudents)
        {
            {
                Console.WriteLine("Student: {0} {1}, grade {2}", student.FirstName, student.LastName, student.Grade);
            }
        }
        Console.WriteLine();

        // Workers
        List<Worker> workers = new List<Worker>();
        workers.Add(new Worker("Aleks", "Aleksiev", 160, 8));
        workers.Add(new Worker("Bogdan", "Bachkov", 100, 10));
        workers.Add(new Worker("Milana", "Argirova", 200, 15));
        workers.Add(new Worker("Petur", "Vulev", 60, 7));
        workers.Add(new Worker("Aleksander", "Filkov", 300, 3));
        workers.Add(new Worker("Mihcail", "Paskalev", 230, 7));
        workers.Add(new Worker("Ida", "Tersieva", 430, 10));
        workers.Add(new Worker("Bilyana", "Miteva", 320, 15));
        workers.Add(new Worker("Yanica", "Ilieva", 245, 12));
        workers.Add(new Worker("Bianka", "Dimitrova", 330, 10));

        // Sort workers by money per hour in descending order
        var sortedWorkers = from worker in workers orderby worker.MoneyPerHour() descending select worker;

        Console.WriteLine("Sorted workers by money per hour in descending order");
        foreach (var worker in sortedWorkers)
        {
            {
                Console.WriteLine("Student: {0} {1}, money per hour {2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }
        }
        Console.WriteLine();

        // Merge list
        List<Human> mergedList = new List<Human>();
        mergedList.AddRange(students);
        mergedList.AddRange(workers);

        // Sort students and workers by first and last name
        var sortedMergedList = from human in mergedList orderby human.FirstName, human.FirstName select human;

        foreach (var human in sortedMergedList)
        {
            Console.WriteLine("Human: {0} {1}", human.FirstName, human.LastName);
        }
    }
}