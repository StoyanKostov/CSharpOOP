using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public interface IAccount
    {
        // Methods
        double Deposit(double deposit);
        double calcInterestAmount(int months);
    }
}
