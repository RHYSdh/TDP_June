using System;

class MyMath {
    public void addition(int A, int B)
    {
        int result = A+B;
        Console.WriteLine("Result: " + result);
    }

    public void subtraction(int A, int B)
    {
        int result = A-B;
        Console.WriteLine("Result: " + result);
    }

    public void multiplication(int A, int B)
    {
        int result = A*B;
        Console.WriteLine("Result: " + result);
    }

    public void division(int A, int B)
    {
        int result = A/B;
        Console.WriteLine("Result: " + result);
    }

    public void nl()
    {
        Console.WriteLine("-------------------------");
    }
}