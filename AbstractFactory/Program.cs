using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Providers;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> accountNumbers = new List<string>()
            {
                "NATIONAL-567",
                "CITI-302",
                "CHASE-43"
            };

            for(int i = 0; i < accountNumbers.Count; i++)
            {
                ICreditUnionFactory anAbstractFactory =
                    CreditUnionFactoryProvider.GetCreditUnionFactory(accountNumbers[i]);
                if (anAbstractFactory == null)
                {
                    Console.WriteLine($"Sorry this credit union account number {accountNumbers[i]} is invalid");
                }
                else
                {
                    ILoanAccount loan = anAbstractFactory.CreateLoanAccount();
                    ISavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
                }
            }
            Console.ReadLine();
        }
    }
}
