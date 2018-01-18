using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingsAccountFactory() as ICreditUnionFactory;
            var citiAccount = factory.GetSavingsAccount("CITI-321");
            var nationalAccount = factory.GetSavingsAccount("NATIONAL-345");
            Console.WriteLine($"My city balance is ${citiAccount.Balance} and national balance is ${nationalAccount.Balance}");
            Console.ReadKey();
        }
    }

    public abstract class ISavingsAccount
    {
        public decimal Balance { get; set; }

    }

    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 5000;
        }
    }

    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Balance = 2000;
        }
    }

    public interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string accountNo);
    }

    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string accountNo)
        {
            if (accountNo.Contains("CITI"))
            {
                return new CitiSavingsAccount();
            }
            else if (accountNo.Contains("NATIONAL"))
            {
                return new NationalSavingsAccount();
            }
            else
                throw new ArgumentException("Invalid Account Number");
        }
    }
}
