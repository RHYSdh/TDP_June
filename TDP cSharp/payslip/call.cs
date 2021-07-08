using System;

class call
{
    public call()
    {
        Console.WriteLine("Call started");
    }

    public void message()
    {
        Console.WriteLine("Hello");
        account y = new account();
        y.newSlip("Rhys", 10000);
    }
}