namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Expresso();

            beverage = new DarkChoclate(beverage);
            beverage = new Moca(beverage);


            Console.WriteLine(beverage.cost());
        }
    }
}
