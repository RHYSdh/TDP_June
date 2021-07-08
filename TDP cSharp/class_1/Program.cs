using System;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath M;
            M = new MyMath();

            M.addition(1,1);
            M.addition(12,12);
            M.nl();
            M.subtraction(100,50);
            M.subtraction(20,10);
            M.nl();
            M.division(100,10);
            M.division(25,5);
            M.nl();
            M.multiplication(3,3);
            M.multiplication(10,10);
        }
    }
}
