using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("00");
        for (int num = 1; num < 100; num++)
            Console.Write($", {num:00}");
    }
}
