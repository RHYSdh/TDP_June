using System;

class account
{
    public void newSlip(string name, int salary)
    {
        float tax = 0, net;

        if (salary >= 2000)
        {
            tax = salary * 25 / 100;
        }
        else
        {
            tax = salary * 15 / 100;
        }

        net = salary - tax;
        Console.WriteLine("Salary Slip for: " + name);
        Console.WriteLine("Your Gross salary: " + salary);
        Console.WriteLine("Your Tax is: " + tax);
        Console.WriteLine("Your Net salary: " + net);

    }

    public void nl()
    {
        Console.WriteLine("-----------------");
    }
}