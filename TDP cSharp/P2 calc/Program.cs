using System;

namespace P2_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            
            A = 20;
            B = 20;
            C = A+B;
            D = 30;
            Console.WriteLine(A + " + " + B + " = " + C);
            Console.WriteLine("D = " + D);

            if (C == D) {
                Console.WriteLine("C equals D");
            } else {
                Console.WriteLine("C does not equal D");
            }

            int Phy, Maths, Chem, Total;
            float Percent;
            Phy = 72;
            Maths = 89;
            Chem = 90;
            Total = Phy+Maths+Chem;
            Percent = (float) Total * 100 / 450;
            Console.WriteLine("Score sheet...");
            Console.WriteLine("Physics: " + Phy);
            Console.WriteLine("Maths: " + Maths);
            Console.WriteLine("Chemistry: " + Chem);
            Console.WriteLine("Your total score: " + Total);
            Console.WriteLine("Percentage: " + Percent + "%");

            if (Percent >= 60) {
                Console.WriteLine("Pass");
            } else {
                Console.WriteLine("Fail");
            }

            Console.WriteLine("Enter your name: ");
            string pName = Console.ReadLine();
            Console.WriteLine("Hi " + pName);

            Console.WriteLine("Enter a number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            int sum = numOne+numTwo;
            Console.WriteLine(numOne + " + " + numTwo + " = " + sum);

            int i = 1;
            while (i <= 10) {
                Console.Write(" Count " + i);
                i++;
            }
        
        }
    }
}
