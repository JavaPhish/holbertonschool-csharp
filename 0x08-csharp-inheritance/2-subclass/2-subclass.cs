using System;
using System.Collections.Generic;

/// <summary>
/// Base obj class
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if an object is a sublass of basetype
    /// </summary>
    /// <returns>
    /// True if subclass, false otherwise
    /// </returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (baseType.IsSubclassOf(derivedType))
        {
            return true;
        }
        return false;
    }
}
