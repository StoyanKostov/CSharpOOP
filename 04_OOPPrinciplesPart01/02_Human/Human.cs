using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Human
{
    // Fields
    private string firstName, lastName;

    // Proparties
    public string FirstName
    {
        set { this.firstName = value; }
        get { return this.firstName; }
    }

    public string LastName
    {
        set { this.lastName = value; }
        get { return this.lastName; }
    }

    // Constructor
    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

}