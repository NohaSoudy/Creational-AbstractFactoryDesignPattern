using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.AbstractFactory
{
    public class BankA : IBankFactory
    {
        public string Deposit()
        {
            return "Deposit A is done";
        }

        public string Withdraw()
        {
            return "Withdraw A is done";
        }
    }
}
