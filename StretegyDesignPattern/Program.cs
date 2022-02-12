using System;

namespace StretegyDesignPattern
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Application app = new Application(ConnectionType.Computer);
            app.LoggingWith("brandonPhone");
        }
    }
}