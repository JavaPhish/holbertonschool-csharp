using System;

/// Base class
public abstract class Base
{
    /// The name
    string name
    {
        set;
        get;
    }

    /// ToString override
    public override string ToString()
    {
        return (name + " is a " + this.GetType());
    }
}
