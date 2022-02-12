namespace StretegyDesignPattern
{
    public interface IConnectStrategy
    {
        ConnectStrategy Logging(string log);
    }
}