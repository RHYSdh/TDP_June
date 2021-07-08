using System;

namespace fore
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;
            for(; a<=20; a++){

                if(a%2 == 0){
                continue;
                }
                if(a >= 15){
                    break;
                }
                Console.WriteLine(a);
                
            }
        }
    }
}
