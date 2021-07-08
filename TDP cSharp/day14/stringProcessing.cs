using System;


class stringProcessing
{

    public void wordCount(string message)
    {

        int x = 0; //word count
        int y = 0; //to track spaces

        for (int i = 0; i < message.Length; i++) //for loop to run through message
        {

            if (message.Substring(i, 1) == " ")
            {
                if (message.Substring(i, 1) == " " && i == y) //if loop has found space and string location is same as y increase y and loop back (y is ahead of i by 1)
                {
                    y++;
                    continue;
                }
                x++;                            //if not increase word count and set y ahead of i by 1.
                y = i + 1;
            }
        }
        if (message.Substring(message.Length - 1, 1) == " ") //if the string contains spaces after text, this will remove 1 from word count that is not completed by for loop.
        {
            x--;
        }
        Console.WriteLine(x + 1); // print number of words.
    }

    public void printVertical(string message)
    {

        string word = "";

        for (int i = 0; i < message.Length; i++)
        {

            if (message.Substring(i, 1) == " ")
            {
                Console.WriteLine(word);
                word = "";
            }
            else
            {
                word += message.Substring(i, 1);
            }
        }
        Console.WriteLine(word);
    }

    public void printVerticalBackwards(string message)
    {

        string word = "";

        for (int i = message.Length - 1; i >= 0; i--)
        {

            if (message.Substring(i, 1) == " ")
            {
                Console.WriteLine(word);
                word = "";
            }
            else
            {
                word = message.Substring(i, 1) + word;
            }
        }
        Console.WriteLine(word);
    }

    public void find(string message, string find)
    {

        int length = 0;
        int i;
        for (i = 0; i < message.Length; i++)
        {
            if (message.Substring(i, 1) == find.Substring(0, 1))
            {
                if (message.Substring(i, find.Length) == find)
                {
                    length++;
                    i += (find.Length - 1);
                }

            }
        }
        Console.WriteLine(length);

    }

    public void arrayTest()
    {
        /*// ########################## Print Highest Lowest Number  ##########################
        Console.WriteLine("     #############################       ");
        int[] Numbers = { 5502, 804, 1000, 300, 20000};
        int Highest = 0;
        int secHigh = 0;
        int Lowest = 0;
        int secLow = 0;
        int tempNum = 0;

        for (int i = 0; i < Numbers.Length; i++)
        {

            if (Numbers[i] >= Highest || Numbers[i] < 0 && tempNum == 0)
            {
                secHigh = Highest;
                Highest = Numbers[i];
                tempNum = 1;
            }
            else if (Numbers[i] >= secHigh || Numbers[i] < 0 && tempNum == 1)
            {
                secHigh = Numbers[i];
                tempNum = 2;
            }
        }

        tempNum = 0;
        Lowest = Highest;
        secLow = Highest;

        for (int i = 0; i < Numbers.Length; i++)
        {

            if (Numbers[i] <= Lowest || Numbers[i] < 0 && tempNum == 0)
            {
                secLow = Lowest;
                Lowest = Numbers[i];
                tempNum = 1;
            }
            else if (Numbers[i] <= secLow || Numbers[i] < 0 && tempNum == 1)
            {
                secLow = Numbers[i];
                tempNum = 2;
            }
        }
        if (Numbers.Length < 3)
        {
            Console.WriteLine("Array must have at least 3 values");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("High 1st: " + Highest);
            Console.WriteLine("High 2nd: " + secHigh);
            Console.WriteLine("Low 2nd: " + secLow);
            Console.WriteLine("Low 1st: " + Lowest);
            Console.ResetColor();
        }
        
*/
        Console.WriteLine("     #############################       ");

        //  ########################## Print Longest city name  ##########################

        string[] cities = { "Manchester", "London", "Norwich", "Liverpool", "ABCDEFGHIJKLM" };
        string Longest = cities[0];

        for (int i = 1; i < cities.Length; i++)
        {

            if (cities[i].Length > Longest.Length)
            {
                Longest = cities[i];
            }
        }
        Console.WriteLine("Longest city name: " + Longest);
        Console.WriteLine("     #############################       ");

        //  ########################## Print First and second highest number from array  ##########################

        int[] listnums = { -54, 0 };
        int firstno = 0; //largest number in array
        int secondno = 0; //second largest in array
        int tempno = 0; //count for negative numbers

        for (int i = 0; i < listnums.Length; i++)
        {

            if (listnums[i] >= firstno || listnums[i] < 0 && tempno == 0)
            {
                secondno = firstno;
                firstno = listnums[i];
                tempno = 1;
            }
            else if (listnums[i] >= secondno || listnums[i] < 0 && tempno == 1)
            {
                secondno = listnums[i];
                tempno = 2;
            }
        }
        if (listnums.Length < 2)
        {
            Console.WriteLine("Array must have at least 2 values");
        }
        else
        {
            Console.WriteLine("1st: " + firstno);
            Console.WriteLine("2nd: " + secondno);
        }
        Console.WriteLine("     #############################       ");
    }











    public void findLongestWord(string message)
    {
        string word = "";
        string longestWord = "";

        for (int i = 0; i < message.Length; i++)
        {

            if (message.Substring(i, 1) == " ")
            {
                if (longestWord.Length < word.Length)
                {
                    longestWord = word;
                    word = "";
                }
                else
                {
                    word = "";
                }
            }
            else
            {
                word += message.Substring(i, 1);
            }
        }
        if (longestWord.Length < word.Length)
        {
            longestWord = word;
        }
        Console.WriteLine("The longest word is " + longestWord.Length + " characters:");
        Console.WriteLine(longestWord);
    }
}

