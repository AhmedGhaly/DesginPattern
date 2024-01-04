using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Payments
{
    public abstract class PaymentConcreate
    {
        public Payment makeOrder(double amount, string name)
        {
            IPayment payment = createPayment();

            return payment.charg(amount, name);
        }

        protected abstract IPayment createPayment();
    }
}
