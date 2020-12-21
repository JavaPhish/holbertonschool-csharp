using System;

/// <summary>
/// Base obj class
/// </summary>
class Obj
{
        /// <summary>
        /// Checks if an object is an int
        /// </summary>
        /// <returns>
        /// True if int, false otherwise
        /// </returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
        {
            return true;
        }
        return false;
    }
}
