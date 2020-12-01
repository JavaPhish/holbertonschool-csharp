using System;


class Program
{
    static void Main(string[] args)
    {
        for (int num = 0; num < 99; num++)
            Console.Write($"{num:00}, ");
        Console.Write("99\n");
    }
}
