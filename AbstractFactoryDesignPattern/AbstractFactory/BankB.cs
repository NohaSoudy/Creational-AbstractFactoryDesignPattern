using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.AbstractFactory
{
    public class BankB : IBankFactory
    {
        public string Deposit()
        {
            return "Deposit B is done";
        }

        public string Withdraw()
        {
            return "Withdraw B is done";
        }
    }
}
