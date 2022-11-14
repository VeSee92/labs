using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("test", 100);

            BankAccount acc2 = new BankAccount("test", 100);

            CurrentAccount acc3 = new CurrentAccount("test", 100, 100);

            SavingsAccount acc4 = new SavingsAccount("test", 200, 5);

            acc1.Withdraw(500);

            acc2.Deposit(200);

            acc3.Withdraw(100);
            acc3.Withdraw(100);
            acc3.Withdraw(100);

            acc4.AddInterest();

            int t = 0;
        }
    }
}
