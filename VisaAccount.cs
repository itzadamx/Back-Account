using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    class VisaAccount : Account
    {
            const double TRANSACTION_FEE = 3.5;
            public double InterestRate { get; set; }

            public VisaAccount(int number, string clientName, double balance, double interestRate) : base(number, clientName, balance)
            {
                InterestRate = interestRate;
            }
            public override void Deposit(double amount)
            {
                Balance += amount;
                Balance -= TRANSACTION_FEE;
            }

            public override void Withdraw(double amount)
            {
                Balance -= amount;
                Balance -= TRANSACTION_FEE;
            }
        
    }
}
