using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank someBank = new Bank("United");
            someBank.addAcount(new Mortgage(new Customer(CustomerType.individual), 200, 2));
            Console.WriteLine(someBank.Acounts[0].calcInterestAmount(8));
        }
    }
}
