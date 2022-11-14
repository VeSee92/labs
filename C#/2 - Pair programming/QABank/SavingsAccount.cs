using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class SavingsAccount : BankAccount
    {

        public int InterestRate { get; set; }

        public SavingsAccount(string customerName, int balance, int interestRate) : base(customerName, balance)
        {
            InterestRate = interestRate;
        }

        public SavingsAccount(string customerName, int accountNumber, int balance, int interestRate) : base(customerName, accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public new void AddInterest()
        {
            this.Balance = Balance + Balance * InterestRate/100;
        }

    }
}
