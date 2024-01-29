using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AbstractFactory
{
    // Abstract Product: PaymentProcessor
    public interface IPaymentProcessor
    {
        void ProcessPayment();
    }
}
