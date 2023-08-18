// See https://aka.ms/new-console-template for more information
using AbstractFactoryDesignPattern.AbstractFactory;
using System.Xml;

string cardNumber, bankCode,cardCode;

Console.WriteLine("Enter please Card Number:");
cardNumber = Console.ReadLine();

bankCode = cardNumber.Substring(0, 6);

PaymentHandlerrAbstractFactory payment = new PaymentHandlerrAbstractFactory();
IBankFactory bank =  payment.GetBank(bankCode);
Console.WriteLine(bank.Withdraw());

Console.WriteLine("Enter please Card Code:");
cardCode = Console.ReadLine();

cardCode = cardCode.Substring(0, 4);

IPaymentCardFactory card = payment.GetCard(cardCode);
Console.WriteLine(card.GetName());

Console.ReadKey();