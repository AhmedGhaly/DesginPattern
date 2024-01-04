using TemplateMethod;

namespace TemplateMethodDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("prepare the tea");
            tea.prepare();

            Console.WriteLine("prepare the coffee");
            coffee.prepare();
        }
    }
}
