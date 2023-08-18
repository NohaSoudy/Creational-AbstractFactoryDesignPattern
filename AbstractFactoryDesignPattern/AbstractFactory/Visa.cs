using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.AbstractFactory
{
    public class Visa : IPaymentCardFactory
    {
        public string GetName()
        {
            return "Visa Name";
        }

        public string GetProviderInfo()
        {
            return "Visa Info";
        }
    }
}
