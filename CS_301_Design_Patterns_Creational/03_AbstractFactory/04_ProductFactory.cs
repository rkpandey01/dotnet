using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AbstractFactory
{
    // Concrete Factory for Credit Card
    public class CreditCardPaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new CreditCardPaymentProcessor();
        }
    }

    // Concrete Factory for PayPal
    public class PayPalPaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new PayPalPaymentProcessor();
        }
    }

}
