using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        // Fields
        public string Name { get; set; }
        public int? Age { get; set; }

        // Constructor
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        // Methods
        public override string ToString()
        {
            string outPut;
            if (this.Age != null)
            {
                outPut = string.Format("Person name is: {0}\nand age {1}", this.Name, this.Age);
            }
            else
	        {
                outPut = string.Format("Person name is: {0}\nand undefied age", this.Name);
	        }
            return outPut;
        }
    }
}
