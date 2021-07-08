using System;

namespace Obj_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Nationwide x = new Nationwide();
            x.a = 20;
            x.b = 12;
            x.showResults();
        }
    }

    class Nationwide
    {
        public int a, b, c;
        public float d;

        public void showResults()
        {
            c = a + b;
            Console.WriteLine("Result is: " + c);
            Console.WriteLine("Percentage is: " + getPercent());
        }

        public float getPercent()
        {
            d = (float)c / 150 * 100;
            return d;
        }
    }
    class MyMaths
    {
        public void addition(int A, int B)
        {
            int C = A+B;
            Console.WriteLine(C);
        }
    }
}
