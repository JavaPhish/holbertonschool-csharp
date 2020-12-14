using System;


class Int
{
    public static void divide(int a, int b)
    {

        int result = 0;
        try
        {
            result = a / b;
        }
        catch (DivideByZeroException)
        {
            result = 0;
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}
