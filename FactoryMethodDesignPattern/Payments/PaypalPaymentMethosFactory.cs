using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Payments
{
    internal class PaypalPaymentMethosFactory : PaymentConcreate
    {
        protected override IPayment createPayment()
        {
            return new PaypalPaymentMethod();
        }
    }
}
