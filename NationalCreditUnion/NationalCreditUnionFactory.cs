﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace NationalCreditUnion
{
    // Product A2
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Console.WriteLine("Returned National Saving Account");
        }
    }
    // Product B2
    public class NationalLoanAccount : ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Returned National Loan Account");
        }
    }
    // Concrete Factory 2
    public class NationalCreditUnionFactory:ICreditUnionFactory
    {
        public override ISavingsAccount CreateSavingsAccount()
        {
            NationalSavingsAccount obj = new NationalSavingsAccount();
            return obj;
        }

        public override ILoanAccount CreateLoanAccount()
        {
            NationalLoanAccount obj = new NationalLoanAccount();
            return obj;
        }
    }
}
