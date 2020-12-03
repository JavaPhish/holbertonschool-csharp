using System;


class Program
{
    static void Main(string[] args)
    {
        int [,] array = new int[5, 5];
        for (int x = 0; x < 5; x++)
        {
            Console.Write("0");
            for (int y = 0; y < 5; y++)
            {
                if (x == 2 && y == 2)
                    array[x, y] = 1;
                else
                    array[x, y] = 0;
                if (y > 0)
                    Console.Write($" {array[x, y]}");
            }

            Console.WriteLine("");
        }
    }
}
