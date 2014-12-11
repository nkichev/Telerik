using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class MortgageAccount : Account
    {
        public MortgageAccount(string customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public override double CalculateInterest(int months)
        {
            if (Customer == "person")
            {
                if (months > 6)
                {
                    return (months - 6) * InterestRate;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (months > 12)
                {
                    return (12 * InterestRate) / 2 + (12 - months) * InterestRate;
                }
                else
                {
                    return months * InterestRate / 2;
                }
            }
        }
    }
}
