using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Payments
{
    public interface IPayment
    {
        Payment charg(double amount, string name);
    }
}
