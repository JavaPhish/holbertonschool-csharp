using System;

/// Base class
public abstract class Base
{
    /// The name
    public string name;

    /// ToString override
    public override string ToString()
    {
        return (name + " is a " + this.GetType());
    }
}
