using System;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            float salary, RangeOne, RangeTwo, tax, finalsal, taxrate;

            salary = 3000;
            RangeOne = 1000; //Tax <= 1000 = 0%
            RangeTwo = 2000; //Tax >1000 <=2000 = 15% else 25%

            if (salary <= RangeOne)
            {
                tax = 0;
                taxrate = 0;
                finalsal = (float) salary - tax;
                
            }
            else if(salary <= RangeTwo)
            {
                tax = (float)salary * 15 / 100;
                taxrate = 15;
                finalsal = (float) salary - tax;
            }
            else
            {
                tax = (float)salary * 25 / 100;
                taxrate = 25;
                finalsal = (float) salary - tax;
            }
            Console.WriteLine("Gross salary is: " + salary + "\nTax is " + tax + " @ "+ taxrate +"%\nNet pay: " + finalsal);
        }
    }
}
