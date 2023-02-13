using System;

class Program
{
    private Connector _connector;

    public Program()
    {
        _connector = new Connector();
    }
    static void Main(string[] args)
    {
        Program demo = new Program();
        demo._connector.Run(); 
    }
}