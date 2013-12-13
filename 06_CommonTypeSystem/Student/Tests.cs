using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Tests
    {
        static void Main(string[] args)
        {
            // Create some students
            Student someOne = new Student("Stoyan", "Bo", "Djambazov", "Na majna si raina", "kdsjf;sdkjf@sdf.com", Specialty.math, University.technicalUniversity, Faculty.fksu, 1111111111, 0888888888, 2);
            Student someOneLikeMe = new Student("Stoyan", "Bo", "Djambazov", "Na majna si raina", "kdsjf;sdkjf@sdf.com", Specialty.math, University.technicalUniversity, Faculty.fksu, 1111111111, 0888888888, 2);
            
            Student someElse = new Student("Bobi", "Di", "Djiji", "Na druga majna si raina", "kdsjf;sdkjf@sdf.com", Specialty.english, University.universityOfCambridge, Faculty.economical, 22, 088888, 3);

            // Override toString()
            Console.WriteLine("toString()");
            Console.WriteLine(someOne);
            Console.WriteLine();

            // Equals()
            Console.WriteLine("Equals()");
            Console.WriteLine(someOne.Equals(someElse));
            Console.WriteLine(someOne.Equals(someOneLikeMe));
            Console.WriteLine();

            // Clone()
            Console.WriteLine("Clone()");
            object copy = someOne.Clone();
            Console.WriteLine("Cloned from someOne:\n{0}", copy);
            Console.WriteLine();

            // GetHashCode()
            Console.WriteLine("GetHashCode()");
            Console.WriteLine(someOne.GetHashCode());
            Console.WriteLine();

            // CompareTo(Student obj)
            Console.WriteLine("CompareTo(Student obj)");
            Console.WriteLine("someOne with someOneElse: {0}", someOne.CompareTo(someElse));
            Console.WriteLine("someOne with someOneLikeMe: {0}", someOne.CompareTo(someOneLikeMe));
        }
    }
}
