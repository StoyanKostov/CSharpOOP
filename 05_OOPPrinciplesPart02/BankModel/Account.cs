using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public abstract class Account : IAccount
    {
        // Fields
        private Customer customer;
        private double balance;
        private double interestRate;

        // Properties
        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set 
            {
                this.interestRate = value;
            }
        }

        public Customer Customer 
        {
            get
            {
                return this.customer;
            }
            set 
            {
                this.customer = value;
            }
        }

        // Constructor
        protected Account(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        // Methods
        public abstract double calcInterestAmount(int months);

        public double Deposit(double deposit)
        {
            return this.balance += deposit;
        }
    }
}
