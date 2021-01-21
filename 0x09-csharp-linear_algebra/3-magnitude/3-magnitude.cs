using System;

/// <summary>
/// Basic vector practice
/// </summary>
class VectorMath
{
    /// <summary>
    /// Finds the magnitude of a given vector (2d or 3d)
    /// </summary>
    /// <returns>
    /// The magnitude of the given vector
    /// </returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 3)
        {
            return ( Math.Round(Math.Sqrt( (Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)) ), 2 ));
        }
        else if (vector.Length == 2)
        {
            return ( Math.Round(Math.Sqrt( (Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) )), 2));
        }
        return -1;
    }
}
