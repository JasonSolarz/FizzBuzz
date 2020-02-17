using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz Application 2/17/2020\n\n");
            Console.Title = "Fizz Buzz";

            //Gather a number from a user. Then print out the numbers. Replacing any numbers div by 3 with Fizz, and 5 with buzz.

            var userInput = 0;

            Console.Write("Please enter a whole number: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            for(int LCV = 1; LCV <= userInput; LCV++)
            {
                if((LCV % 3) == 0 && ((LCV % 5) == 0))
                {
                    Console.WriteLine("Fizz Buzz ");
                }
                else if((LCV % 3) == 0)
                {
                    Console.WriteLine("Fizz ");
                }
                else if((LCV % 5) == 0)
                {
                    Console.WriteLine("Buzz ");
                }
                else
                {
                    Console.WriteLine(LCV + " ");
                }
            }
        }
    }
}
