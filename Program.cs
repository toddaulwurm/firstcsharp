using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            int wee = 1;
            while(wee<256)
            {
                Console.WriteLine(wee);
                wee++;
            }

            for (int i = 1; i <= 100; i++)
            {
                if(i%5==0 && i%3==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Fizz");
                }
            }
            Console.WriteLine("##########################################");
            int start = 1;

            while(start<100)
            {
                if(start%5==0 && start%3==0)
                {
                    Console.WriteLine("FizzBuzz"+ start);
                }
                else if(start%5==0)
                {
                    Console.WriteLine("Buzz"+start);
                }
                else if(start%3==0)
                {
                    Console.WriteLine("Fizz"+start);
                }
                start++;
            }
        }
    }
}
