using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Payments
{
    public class Payment
    {
        public string name { get; set; }
        public double amount { get; set; }

        public override string ToString()
        {
            return $"your name is {name} and the net amount that charged is {amount}";
        }
    }
}
