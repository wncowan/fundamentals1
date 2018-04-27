using System;

namespace loop_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // for (int i = 1; i <= 255; i++)
            // {
            //     Console.WriteLine(i);
            // }
            Random rand = new Random();

            for (int i = 1; i <= 10; i++)
            {
                int rando = rand.Next(1,100);
                
                if(rando % 3 == 0 && rando % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz" + rando);
                }
                else if(rando % 3 == 0)
                {
                    Console.WriteLine("Fizz" + rando);
                }
                else if(rando % 5 == 0)
                {
                    Console.WriteLine("Buzz" + rando);
                }
                else{
                    Console.WriteLine(rando);
                }
            }
        }
    }
}
