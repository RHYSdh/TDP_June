using System;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            Console.WriteLine("Number one:");
            int targetx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number two");
            int targety = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication table " + targetx + " x " + targety);

            if (targetx > 50 || targety > 50)
            {

                Console.WriteLine("Number cannot be greater than 50.");
            }
            else
            {
                while (y <= targety)
                {

                    while (x <= targetx)
                    {

                        Console.Write(x * y);
                        Console.Write(" ");
                        x++;
                    }

                    Console.WriteLine("");
                    x = 1;
                    y++;
                }
            }
        }
    }
}
