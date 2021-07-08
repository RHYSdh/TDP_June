using System;

namespace Object_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            London T = new London();
            T.A = 90;
            T.B = 78;

            Console.WriteLine("A=" + T.A);
            Console.WriteLine("B=" + T.B);
            Console.WriteLine(T.A + T.B);

            Console.WriteLine("-----------------------");

            First X = new First();
            X.A = 10;
            X.message();
            X.m2();
        }
    }

    class London
    {
        public int A,B;
    }

    class First
    {
        public int A;

        public void message()
        {
            Console.WriteLine("Hello ");
            Console.WriteLine("there");
            Console.WriteLine(A);
        }
        public void m2()
        {
            Console.WriteLine("2nd message");
        }
    }
}
