using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AbstractFactory
{
    // Concrete Product: CreditCardPaymentProcessor
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing Credit Card Payment");
            // Actual credit card processing logic would be here
        }
    }

    // Concrete Product: PayPalPaymentProcessor
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal Payment");
            // Actual PayPal processing logic would be here
        }
    }
}
