using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Worker : Human
{
    // Fields
    private int weekSalary, workHoursPerDay;
    
    // Property
    public int WeekSalary
    {
        set { this.weekSalary = value; }
        get { return this.weekSalary; }
    }

    public int WorkHoursPerDay
    {
        set { this.workHoursPerDay = value; }
        get { return this.workHoursPerDay; }
    }

    // Constructor
    public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    // Methods
    public double MoneyPerHour() // returns money earned by hour by the worker
    {
        return (double)weekSalary / (5 * workHoursPerDay);
    }

}