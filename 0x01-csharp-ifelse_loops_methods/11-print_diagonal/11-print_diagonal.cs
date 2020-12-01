using System;


class Line
{
    public static void PrintDiagonal(int length)
    {
        for (int x = 0; x < length; x++) {
            for (int y = 0; y < x; y++){
                Console.Write(" ");
            }
            Console.Write("\\\n");
        }
    }
}
