using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    public class Account : IAccountActions
    {
        public string Customer { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }

        public Account(string customer, double balance, double interestRate)
        {
            if (customer != "person" && customer != "company")
            {
                throw new ArgumentException("customer");
            }

            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual void DepositMoney(double sum)
        {
            this.Balance += sum;
        }

        public virtual double CalculateInterest(int months)
        {
            return this.InterestRate * months;
        }
    }
}
