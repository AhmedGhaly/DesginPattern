using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Payments
{
    internal class VisaPaymentMethosFactory : PaymentConcreate
    {
        protected override IPayment createPayment()
        {
            return new VisaPaymentMethod();
        }
    }
}
