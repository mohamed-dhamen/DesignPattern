namespace DesignPatterns;

public  interface ILogisticsFactory
{
    public  ITransport CreateTransport();
    public IDriver CreateDriver();

}