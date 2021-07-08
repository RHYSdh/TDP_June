using System;

class MyMath
{
    public void addition(int A, int B)
    {
        int result = A + B;
        Console.WriteLine("Result: " + result);
    }

    public void subtraction(int A, int B)
    {
        int result = A - B;
        Console.WriteLine("Result: " + result);
    }

    public void multiplication(int A, int B)
    {
        int result = A * B;
        Console.WriteLine("Result: " + result);
    }

    public void division(int A, int B)
    {
        int result = A / B;
        Console.WriteLine("Result: " + result);
    }

    public void nl()
    {
        Console.WriteLine("-------------------------");
    }

    public void timestable(int num)
    {
        int z = 1;

        for (; z<=10; z++)
        {

            Console.WriteLine(z + "x" + num + "= " + (z * num));
            
        }
    }

}