using System;
using System.Collections.Generic;

/// <summary>
/// Base obj class
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if an object is an array
    /// </summary>
    /// <returns>
    /// True if array, false otherwise
    /// </returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj.GetType().IsArray)
        {
            return true;
        }
        return false;
    }
}
