/// 1.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty.
/// Use an enumeration for the specialties, universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
/// 2.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
/// 3.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    enum Specialty 
    {
        math,
        biology,
        english,
    }

    enum University
    {
        technicalUniversity,
        harvardUniversity,
        universityOfCambridge,
    }

    enum Faculty
    {
        economical,
        fksu,
    }

    class Student : ICloneable, IComparable<Student>
    {
        // Fields
        private string firstName, middleName, lastName, permanentAddress, eMail;
        private Specialty studentSpecialty;
        private University studentUniversity;
        private Faculty studentFaculty;
        private int socialSecurityNumber, mobilePhone;
        private byte course;

        // Properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set { this.permanentAddress = value; }
        }

        public string EMail
        {
            get { return this.eMail; }
            set { this.eMail = value; } // !!!Need some validation
        }

        public Specialty StudentSpecialty
        {
            get { return this.studentSpecialty; }
            set { this.studentSpecialty = value; }
        }

        public University StudentUniversity
        {
            get { return this.studentUniversity; }
            set { this.studentUniversity = value; }
        }

        public Faculty StudentFaculty
        {
            get { return this.studentFaculty; }
            set { this.studentFaculty = value; }
        }

        public int SocialSecurityNumber
        {
            get { return this.socialSecurityNumber; }
            set { this.socialSecurityNumber = value; }
        }

        public int MobilePhone
        {
            get { return this.mobilePhone; }
            set { this.mobilePhone = value; }
        }

        public byte Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        // Constructor
        private Student() { }

        public Student(string firstName, string middleName, string lastName, string permanentAddress, string eMail, Specialty studentSpecialty, University studentUniversity, Faculty studentFaculty, int socialSecurityNumber, int mobilePhone, byte course)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.PermanentAddress = permanentAddress;
            this.EMail = eMail;
            this.StudentSpecialty = studentSpecialty;
            this.StudentUniversity = studentUniversity;
            this.StudentFaculty = studentFaculty;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.MobilePhone = mobilePhone;
            this.Course = course;
        }

        // Methods
        public override bool Equals(object obj)
        {
            // If parameter is null
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Student
            Student castedObject = obj as Student;
            if (castedObject == null)
            {
                return false;
            }

            // Return true if the fields match
            return this.SocialSecurityNumber == castedObject.SocialSecurityNumber;
        }

        public static bool operator ==(Student a, Student b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.SocialSecurityNumber == b.SocialSecurityNumber;
        }

        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }


        public override string ToString()
        {
            return string.Format("Student details\nFirst name: {0},\nMiddle name: {1},\nLast Name: {2},\nStudent University: {3},\nStudentSpecialty: {4}", this.FirstName, this.MiddleName, this.LastName, this.StudentUniversity, this.StudentSpecialty);
        }

        public override int GetHashCode()
        {
            return this.LastName.GetHashCode() ^ this.SocialSecurityNumber.GetHashCode();
        }

        // TASK 2: Add implementations of the ICloneable interface
        public object Clone()
        {
            Student obj = new Student();
            obj.FirstName = this.FirstName;
            obj.MiddleName = this.MiddleName;
            obj.LastName = this.LastName;
            obj.PermanentAddress = this.PermanentAddress;
            obj.EMail = this.EMail;
            obj.StudentSpecialty = this.StudentSpecialty;
            obj.StudentUniversity = this.StudentUniversity;
            obj.StudentFaculty = this.StudentFaculty;
            obj.SocialSecurityNumber = this.SocialSecurityNumber;
            obj.MobilePhone = this.MobilePhone;
            obj.Course = this.Course;
            return obj;
        }

        // Task 3: Implement the  IComparable<Student> interface to compare students
        public int CompareTo(Student obj)
        {
            if (this.LastName != obj.LastName)
            {
                return (String.Compare(this.LastName, obj.LastName));
            }
            if (this.FirstName != obj.FirstName)
            {
                return (String.Compare(this.FirstName, obj.FirstName));
            }
            if (this.SocialSecurityNumber != obj.SocialSecurityNumber)
            {
                return (this.SocialSecurityNumber - obj.SocialSecurityNumber);
            }
            return 0;
        }
    }
}
