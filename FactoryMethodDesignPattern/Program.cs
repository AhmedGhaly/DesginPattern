using FactoryPattern.Payments;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("enter the amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("enter your payment method");
            Console.WriteLine("1 : Paypal Method");
            Console.WriteLine("2 : Visa Method");

            int choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                PaypalPaymentMethosFactory paypal = new PaypalPaymentMethosFactory();
                Console.WriteLine(paypal.makeOrder(amount, name));
            }
            else
            {
                VisaPaymentMethosFactory visa = new VisaPaymentMethosFactory();
                Console.WriteLine(visa.makeOrder(amount, name));
            }

        }
    }
}
