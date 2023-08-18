using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.AbstractFactory
{
    public class PaymentHandlerrAbstractFactory : IPaymentHandlerAbstractFactory
    {
     

        public IBankFactory GetBank(string bankCode)
        {
            switch (bankCode)
            {
                case "123456":
                    return new BankA();
                case "111111":
                    return new BankB();
            }
            return null;
        }

        public IPaymentCardFactory GetCard(string cardCode)
        {
            switch (cardCode)
            {
                case "4321":
                    return new Visa();
                case "2222":
                    return new CreditCard();
            }
            return null;
        }
    }
}
