using System;

class Program
{
    static void Main(string[] args)
    {
        for (int num = 0; num <= 98; num++)
            Console.Write("{0} = 0x{1}\n", num, num.ToString("X"));
    }
}
