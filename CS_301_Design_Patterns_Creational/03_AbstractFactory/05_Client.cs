using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AbstractFactory
{
    // Payment Client
    public class PaymentClient
    {
        private IPaymentProcessor paymentProcessor;

        public PaymentClient(IPaymentProcessorFactory factory)
        {
            paymentProcessor = factory.CreatePaymentProcessor();
        }

        public void MakePayment()
        {
            paymentProcessor.ProcessPayment();
        }
    }
}
