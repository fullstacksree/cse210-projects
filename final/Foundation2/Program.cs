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
        Program trial = new Program();
        trial._connector.Run(); 
    }
}