using System;
using System.Collections.Generic;


class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> narray = new List<int>();
        for (int i = 0; i < size; i++)
           narray.Add(i);

        // Print the array
        for (int x = 0; x < size; x++)
            if (x + 1 != size)
                Console.Write($"{x} ");
            else
                Console.Write($"{x}");

        Console.Write("\n");

        return narray;
    }
}
