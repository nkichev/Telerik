using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class BankSystem
    {
        static void Main(string[] args)
        {
            Account[] accounts = {
                                     new DepositAccount("company", 800.0, 0.7),
                                     new DepositAccount("person", 200.0, 0.1),
                                     new LoanAccount("company",4000.0, 0.4),
                                     new LoanAccount("person",401.0, 0.5),
                                     new LoanAccount("company", 10281.0, 1.9),
                                     new DepositAccount("person", 1800.0, 1.5)
                                 };
            foreach (var account in accounts)
            {
                Console.WriteLine(account.CalculateInterest(14));
            }
        }
    }
}
