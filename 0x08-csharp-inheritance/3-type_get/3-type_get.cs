using System;
using System.Collections.Generic;

/// <summary>
/// Base obj class
/// </summary>
class Obj
{

    /// <summary>
    /// Prints all properties and methods of a given object
    /// </summary>
    public static void Print(object myObj)
    {
        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach (var prop in myObj.GetType().GetProperties())
        {
            Console.WriteLine($"{prop.Name}");
        }
        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        foreach (var prop in myObj.GetType().GetMethods())
        {
            Console.WriteLine($"{prop.Name}");
        }
    }
}
