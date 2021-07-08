using System;

namespace payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath X = new MyMath();
            X.timestable(3);

            Console.WriteLine("************************");

            Cube Y = new Cube();
            Y.makecube();
        }

    }
}
