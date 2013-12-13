using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class Bank
    {
        // Fields
        private string name;
        private List<Account> acounts;
     
        // Properties
        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<Account> Acounts
        {
            get { return this.acounts; }
        }

        // Constructor
        public Bank(string name) 
        {
            this.Name = name;
            this.acounts = new List<Account>();
        }

        // Methods
        public void addAcount(Account acount) 
        {
            this.acounts.Add(acount);
        }
    }
}
