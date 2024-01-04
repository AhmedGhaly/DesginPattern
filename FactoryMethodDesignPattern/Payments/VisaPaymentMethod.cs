using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Payments
{
    internal class VisaPaymentMethod : IPayment
    {
        public Payment charg(double amount, string name)
        {
            Payment payment = new Payment()
            {
                amount = amount + amount * .2,
                name = name,
            };
            return payment;
        }
    }
}
