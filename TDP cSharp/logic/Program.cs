using System;

namespace logic
{
    class Program
    {
        static void Main(string[] args)
        {
            task X = new task();

            //X.BalanceDetails(92,1000);
            //X.swap(10,30);

            //float salary = 2000;
            //Console.WriteLine("Gross salary £" + salary +" tax is: " + X.taxcalc(salary));
            //Console.WriteLine("Net salary £" + (salary-X.taxcalc(salary)));

            task shafeeq;
            shafeeq = new task();

            shafeeq.updateResults(150,10,10);
            shafeeq.showResults();
        }
    }
}
