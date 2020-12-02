using System;


class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        // Create and initialize array
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
           array[i] = i;
        }

        // Print the array
        for (int x = 0; x < size; x++)
        {
            if (x + 1 != size)
                Console.Write($"{x} ");
            else
                Console.Write($"{x}");
        }
        Console.Write("\n");

        return array;
    }
}
