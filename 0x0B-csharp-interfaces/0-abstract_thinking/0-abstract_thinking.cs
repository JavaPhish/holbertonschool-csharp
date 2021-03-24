using System;

/// Base class
abstract class Base
{
    /// The name
    public string name;

    /// ToString override
    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }
}
