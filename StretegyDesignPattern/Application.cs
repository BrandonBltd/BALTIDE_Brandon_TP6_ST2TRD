using System.Runtime.InteropServices.ComTypes;

namespace StretegyDesignPattern
{
    public enum ConnectionType : int
    {
        Mobile = 1,
        Computer = 2,

    }
    public class Application
    {
        private ConnectionType _connectionType;

        public Application(ConnectionType connectionType)
        {
            _connectionType = connectionType;
        }

        public ConnectStrategy LoggingWith(string log)
        {
            IConnectStrategy connectStrategy;
            ConnectStrategy connection = null;
            switch (_connectionType)
            {
                case ConnectionType.Computer:
                    connectStrategy = new ComputerConnection();
                    return connectStrategy.Logging(log);
                    
                case ConnectionType.Mobile:
                    connectStrategy = new MobileConnection();
                    return connectStrategy.Logging(log);

                   
            }
            
            return connection;
        }
        

    }
}