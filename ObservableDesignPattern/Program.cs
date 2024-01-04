
using Observable.obervers;
using System;

namespace Observable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather(30, 25.3);

            Observers listnerOne = new DisplayONeLIstner();
            Observers listnerTwo = new DisplayTwoListner();
            Observers listnerThree = new DisplayThreeListner();

            weather.addListner(listnerOne);
            weather.addListner(listnerTwo);
            weather.addListner(listnerThree);
            weather.onChangeWeather(31.3, 87.3);
            Console.WriteLine("-------------------------------------------------------------");

            weather.removeListner(listnerOne);
            weather.onChangeWeather(30.3, 36.2);
            Console.WriteLine("-------------------------------------------------------------");

        }
    }

}
