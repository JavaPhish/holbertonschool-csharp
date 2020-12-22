using System;

/// <summary>
/// Rectangle Square : rectangle
/// </summary>
class Square : Rectangle
{
    int size;
    /// <summary>
    /// Getter/Setter for size property (Also sets height/width inherited)
    /// </summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            } 
            size = value; 
            Width = value;
            Height = value;
        }
    }
}

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

    /// <summary>
    /// Override method to display area
    /// </summary>
    public new int Area()
    {
        return (width * height);
    }

   /// <summary>
    /// Override method toString
    /// </summary>
    public override string ToString()
    {
        return ($"[Rectangle] {width} / {height}");
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
