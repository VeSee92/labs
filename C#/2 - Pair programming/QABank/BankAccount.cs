using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QABank
{
    public class BankAccount
    {

        /// <summary>
        /// 
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public int Balance { get; set; }

        static int NextAccountNumber = 99999;


        public BankAccount(string customerName, int balance)
        {
            CustomerName = customerName;
            AccountNumber = Interlocked.Increment(ref NextAccountNumber);
            Balance = balance;
        }

        public BankAccount(string customerName, int accountNumber, int balance)
        {
            CustomerName = customerName;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(int deposit)
        {
            this.Balance = this.Balance + deposit;
        }

        public void Withdraw(int withdraw)
        {
            this.Balance = this.Balance - withdraw;
        }

    }
}
