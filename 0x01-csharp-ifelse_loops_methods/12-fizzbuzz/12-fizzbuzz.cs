using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write('1');
            for (int num = 2; num < 101; num++)
            {
                if (num % 15 == 0)
                    Console.Write(" FizzBuzz");
                else if (num % 5 == 0)
                    Console.Write(" Buzz");
                else if (num % 3 == 0)
                    Console.Write(" Fizz");
                else
                    Console.Write($" {num}");
            }
            Console.Write("\n");
        }
    }
}
