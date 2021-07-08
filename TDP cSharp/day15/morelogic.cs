using System;

class morelogic
{

    public void convertToEnglish(int num)
    {
        string english = "";
        int originalnum = num;
        string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tens = { "", "", "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
        if (num > 9999 || num < 1)
        {
            Console.WriteLine("Invalid number, entry must be between 1-9999");
            return;
        }
        if (num >= 1000)
        {
            english += ones[num / 1000] + " Thousand ";
            num %= 1000;
        }
        if (num >= 100)
        {
            english += ones[num / 100] + " Hundred";
            num %= 100;
        }
        if (num > 0 && originalnum > 100)
        {
            english += " and ";
        }
        if (num >= 20)
        {
            english += tens[num / 10];
            num %= 10;
        }
        if (num >= 1)
        {
            english += ones[num];
        }
        Console.WriteLine(english);
    }

    public void ex1()
    {
        string no1, no2;
        no1 = "7";
        no2 = "5";
        int[] number = { 2, 56 };

        try
        {
            int A = Int32.Parse(no1);
            int B = Int32.Parse(no2);

            Console.WriteLine("Line 1");
            Console.WriteLine(number[3]);
            Console.WriteLine("Line 2");
            Console.WriteLine("Result: " + (A + B));
            Console.WriteLine("Line 3");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Exception in array");
        }
        catch (FormatException)
        {
            Console.WriteLine("Exception in format");
        }
        finally {
            Console.WriteLine("Program end, this is a finally block it will always run");
        }
    }
}