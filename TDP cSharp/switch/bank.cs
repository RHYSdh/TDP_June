using System;

class bank
{
    static public int dollar;

    public void setDollar(int amo)
    {
        dollar = amo;
    }

    public void convertCurrency(int num)
    {
        Console.WriteLine("The value " + (num * dollar));
    }
}

class a
{
    public int num1 = 10;
    public int num2 = 5;

    public void sum(){
        Console.WriteLine(num1 + " & " + num2);
    }

}

class b:a {
    public void add(){
        Console.WriteLine(num1 + " + " + num2 + " = " + (num1+num2));
    }

    public void add(string z){
        Console.WriteLine(z+" "+(num1+num2));
    }
}

class c:b {
    public void multiplication(int x, int y){
        Console.WriteLine(x + " x " + y + " = " + (x*y));
    }
}