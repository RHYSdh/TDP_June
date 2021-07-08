using System;

class SwitchTest
{
    public void check(int no)
    {

        switch (no)
        {
            case 1: case 3: case 5: Console.WriteLine("Backup"); break;
            case 2: case 4: Console.WriteLine("Report"); break;
        }

    }


    public void convertToEnglish(int num)
    {
        string english = "";
        int originalnum = num;
        if (num > 9999 || num < 1)
        {
            Console.WriteLine("Invalid number, entry must be between 1-9999");
            return;
        }
        if (num >= 1000)
        {
            english += ones(num / 1000) + " Thousand ";
            num %= 1000;
        }
        if (num >= 100)
        {
            english += ones(num / 100) + " Hundred";
            num %= 100;
        }
        if (num > 0 && originalnum > 100)
        {
            english += (" and ");
        }
        if (num >= 20)
        {
            english += tens(num / 10 * 10);
            num %= 10;
        }
        if (num >= 1)
        {
            english += ones(num);
        }
        Console.WriteLine(english);
    }

    private string ones(int no)
    {
        string answer = "";
        switch (no)
        {
            case 1: answer = "One"; break;
            case 2: answer = "Two"; break;
            case 3: answer = "Three"; break;
            case 4: answer = "Four"; break;
            case 5: answer = "Five"; break;
            case 6: answer = "Six"; break;
            case 7: answer = "Seven"; break;
            case 8: answer = "Eight"; break;
            case 9: answer = "Nine"; break;
            case 10: answer = "Ten"; break;
            case 11: answer = "Eleven"; break;
            case 12: answer = "Twelve"; break;
            case 13: answer = "Thirteen"; break;
            case 14: answer = "Fourteen"; break;
            case 15: answer = "Fifteen"; break;
            case 16: answer = "Sixteen"; break;
            case 17: answer = "Seventeen"; break;
            case 18: answer = "Eighteen"; break;
            case 19: answer = "Nineteen"; break;
        }
        return answer;
    }
    private string tens(int no)
    {
        string answer = "";
        switch (no)
        {
            case 20: answer = "Twenty "; break;
            case 30: answer = "Thirty "; break;
            case 40: answer = "Forty "; break;
            case 50: answer = "Fifty "; break;
            case 60: answer = "Sixty "; break;
            case 70: answer = "Seventy "; break;
            case 80: answer = "Eighty "; break;
            case 90: answer = "Ninety "; break;
        }
        return answer;
    }

}