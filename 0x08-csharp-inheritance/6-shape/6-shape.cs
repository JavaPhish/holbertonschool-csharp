using System;

/// <summary>
/// Rectangle class : shape
/// </summary>
class Rectangle : Shape
{
    int width;
    int height;

    /// <summary>
    /// Getter/Setter for width property
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            } 
            width = value; 
        }
    }

    /// <summary>
    /// Getter/Setter for height property
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            } 
            height = value; 
        }
    }
}


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
