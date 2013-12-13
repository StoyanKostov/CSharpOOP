using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class Deposit : Account, IWithdrawable
    {
        // Constructor
        public Deposit(Customer customer, double balance, double interestRate)
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
            else if ((this.Balance > 0) && (this.Balance < 1000))
            {
                return 0;
            }
            else
            {
                return months * InterestRate;
            }
        }

        public double withdraw(double withdraw)
        {
            return this.Balance -= withdraw;
        }
    }
}
