using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class CurrentAccount : BankAccount
    {

        public int Overdraft { get; set; }

        public CurrentAccount(string customerName, int balance, int overdraft) : base(customerName, balance)
        {
            Overdraft = overdraft;
        }

        public CurrentAccount(string customerName, int accountNumber, int balance, int overdraft) : base(customerName, accountNumber, balance)
        {
            Overdraft = overdraft;
        }

        public new void Withdraw(int withdraw)
        {
            if(withdraw <= this.Balance + this.Overdraft)
            {
                this.Balance = this.Balance - withdraw;
            }
        }

    }
}
