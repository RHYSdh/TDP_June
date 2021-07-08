using System;

class task
{
    public void check(int Num)
    {
        if (Num > 1000)
        {
            Console.WriteLine("A");

            if (Num > 2000)
            {
                Console.WriteLine("C");

                if (Num > 4000)
                {
                    Console.WriteLine("E");
                }
                else
                {
                    Console.WriteLine("F");
                }
                Console.WriteLine("J");
            }
            else
            {
                Console.WriteLine("D");
            }
        }
        else
        {
            Console.WriteLine("B");

            if (Num > 500)
            {
                Console.WriteLine("K");
                Console.WriteLine("M");

                if (Num > 700)
                {
                    Console.WriteLine("O");
                }
                else
                {
                    Console.WriteLine("N");
                }
                Console.WriteLine("P");
            }
            else
            {
                Console.WriteLine("L");
            }
        }
    }

    public void BalanceDetails(int bill, int paid)
    {
        int balance = paid - bill;
        int fifty = 0, twenty = 0, ten = 0, five = 0, two = 0, one = 0;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Customers total change: " + balance);
        Console.ResetColor();

        if (balance >= 50)
        {
            fifty = balance / 50;
            balance -= fifty * 50; // balance %= 50
            Console.WriteLine("£50 x " + fifty);
        }
        if (balance >= 20)
        {
            twenty = balance / 20;
            balance -= twenty * 20;
            Console.WriteLine("£20 x " + twenty);
        }
        if (balance >= 10)
        {
            ten = balance / 10;
            balance -= ten * 10;
            Console.WriteLine("£10 x " + ten);
        }
        if (balance >= 5)
        {
            five = balance / 5;
            balance -= five * 5;
            Console.WriteLine("£5 x " + five);
        }
        if (balance >= 2)
        {
            two = balance / 2;
            balance -= two * 2;
            Console.WriteLine("£2 x " + two);
        }
        if (balance >= 1)
        {
            one = balance / 1;
            balance -= one * 1;
            Console.WriteLine("£1 x " + one);
        }
    }

    public void seperate(int numin)
    {

        Console.WriteLine(numin / 100);
        Console.WriteLine(numin / 10 % 10);
        Console.WriteLine(numin % 10);
        Console.WriteLine((numin / 100) + (numin / 10 % 10) + (numin % 10));
    }

    public void swap(int x, int y)
    {
        int A = x;
        int B = y;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("With 3rd variable");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Swap A:" + A + " and B: " + B);
        Console.ResetColor();

        int C = A;
        A = B;
        B = C;
        Console.WriteLine("A: " + A + " B: " + B);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Without using 3rd variable");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Swap A:" + A + " and B: " + B);
        Console.ResetColor();

        A = A + B;
        B = A - B;
        A = A - B;

        Console.WriteLine("A: " + A + " B: " + B);
    }

    public float taxcalc(float salary)
    {
        return salary / 21 * 100;
    }

    private int che, phy, mat;
    private float total, percentage;
    public void updateResults(int chemistry, int physics, int maths)
    {

        if (chemistry >= 0 && chemistry <= 150 && physics >= 0 && physics <= 150 && maths >= 0 && maths <= 150)
        {
            che = chemistry;
            phy = physics;
            mat = maths;
        }
        else
        {
            Console.WriteLine("Invalid entry, results must be between 0-150");
            Console.Write("Input: ");
            
            if (chemistry < 0 || chemistry > 150)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(chemistry + " ");
                Console.ResetColor();
            }
            else
            {
                Console.Write(chemistry + " ");
            }
            if (physics < 0 || physics > 150)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(physics + " ");
                Console.ResetColor();
            }
            else
            {
                Console.Write(physics + " ");
            }
            if (maths < 0 || maths > 150)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(maths + " ");
                Console.ResetColor();
            }
            else
            {
                Console.Write(maths + " ");
            }
        }
    }

    public void showResults()
    {
        total = che + phy + mat;
        percentage = total / 450 * 100;
        Console.WriteLine("Total marks for " + total);
        Console.WriteLine("Percentage: " + percentage + "%");
    }
}
