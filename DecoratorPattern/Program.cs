using System;

namespace DecoratorPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ICar myCar = new Car();
            Console.WriteLine(myCar.GetCarDetail());
            ICar myTunningCar = new XenonHeadlightDecorator(myCar);
            Console.WriteLine(myTunningCar.GetCarDetail());
    

        }
    }
}