using System;

namespace switchtest
{
    class Program
    {
        static void Main(string[] args)
        {
            NBSAccounts X = new NBSAccounts();

            Console.WriteLine(X.tax(6000));
        }
    }
}
