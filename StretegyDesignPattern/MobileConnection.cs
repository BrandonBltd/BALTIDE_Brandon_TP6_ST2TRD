using System;

namespace StretegyDesignPattern
{
    public class MobileConnection : IConnectStrategy
    {
        public ConnectStrategy Logging(string message)
        {
            ConnectStrategy strategy = new ConnectStrategy();
            strategy.ValidMessage = "Connection with Mobile";
            Console.WriteLine(strategy.ValidMessage);
            return strategy;
        }
    }
}