using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Policy
    {
        private int Id { set; get; } = 123;
        private string Insured { get; set; }="John Doe";
        public string GetInsuredName() => Insured;
    }
}
