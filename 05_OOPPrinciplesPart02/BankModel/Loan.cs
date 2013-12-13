using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class Loan : Account
    {
        // Constructor
        public Loan(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // Method
        public override double calcInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months must be positive value");
            }
            else if (this.Customer.Type == CustomerType.company)
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    return (months - 2) * InterestRate;
                }
            }
            else if (this.Customer.Type == CustomerType.individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    return (months - 3) * InterestRate;
                }
            }
            else
            {
                throw new ArgumentException("Invalid customer type");
            }
        }
    }
}
