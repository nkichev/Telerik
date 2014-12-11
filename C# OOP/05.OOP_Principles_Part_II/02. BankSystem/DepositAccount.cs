using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class DepositAccount : Account
    {
        public DepositAccount(string customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public void WithdrawMoney(double withdrawMoney)
        {
            this.Balance -= withdrawMoney;
        }

        public override double CalculateInterest(int months)
        {
            if (Balance > 0 && Balance < 1000)
            {
                return 0;
            }
            else
            {
                return months * InterestRate;
            }
        }
    }
}
