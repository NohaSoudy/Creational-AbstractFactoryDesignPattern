using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.AbstractFactory
{
    public class CreditCard : IPaymentCardFactory
    {
        public string GetName()
        {
            return "CreditCard Name";
        }

        public string GetProviderInfo()
        {
            return "CreditCard Info";
        }
    }
}
