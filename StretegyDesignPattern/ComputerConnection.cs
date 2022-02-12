using System;

namespace StretegyDesignPattern
{
    public class ComputerConnection : IConnectStrategy
    {
        public ConnectStrategy Logging(string message)
        {
            ConnectStrategy strategy = new ConnectStrategy();
            strategy.ValidMessage = "Connection with computer";
            Console.WriteLine(strategy.ValidMessage);
            return strategy;
        }
    }
}