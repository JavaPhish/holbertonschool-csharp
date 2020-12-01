using System;


class Program
{
    static void Main(string[] args)
    {
        for (int ascii = 97; ascii < 123; ascii++)
            if (ascii != 113 && ascii != 101)
                Console.Write((char)ascii);
    }
}

