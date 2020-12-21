using System;

/// <summary>
/// Throws exception
/// </summary>
class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
