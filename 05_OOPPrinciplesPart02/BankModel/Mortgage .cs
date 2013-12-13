using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class Mortgage : Account
    {
        // Constructor
        public Mortgage(Customer customer, double balance, double interestRate)
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
                if (months <= 12)
                {
                    return months * InterestRate / 2;
                }
                else
                {
                    return (months - 12) * InterestRate + 12 * InterestRate / 2;
                }
            }
            else if (this.Customer.Type == CustomerType.individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
	            {
                    return (months - 6) * InterestRate;
	            }
            }
            else
            {
                throw new ArgumentException("Invalid customer type");
            }
        }
    }
}
