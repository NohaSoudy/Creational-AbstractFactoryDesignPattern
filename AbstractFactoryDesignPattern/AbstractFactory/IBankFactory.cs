using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.AbstractFactory
{
    public interface IBankFactory
    {
        string Withdraw();
        string Deposit();
    }
}
