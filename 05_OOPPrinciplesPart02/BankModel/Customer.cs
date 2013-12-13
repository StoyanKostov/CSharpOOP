using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public enum CustomerType
    { 
        individual,
        company,
    }

    public class Customer
    {
        // Fields
        //private List<Account> customerAccounts;
        private CustomerType type;

        // Properties
        public CustomerType Type 
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        // Constructor
        public Customer(CustomerType type)
        {
            this.Type = type;
            //this.customerAccounts = new List<Account>();
        }
        
        // Methods
        //public void addAccount(Account account)
        //{
        //    this.customerAccounts.Add(account);
        //}
    }
}
