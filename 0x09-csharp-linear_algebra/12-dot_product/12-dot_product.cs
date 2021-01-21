using System;

/// <summary>
/// VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// DotProduct of two vectors
    /// </summary>
    /// <returns>
    /// the DotProduct
    /// </returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == vector2.Length)
        {
            if (vector1.Length >= 2)
            {
                double sum = 0;

                for (int i = 0; i < vector1.Length; i++)
                {
                    sum += vector1[i] * vector2[i];
                }

                return sum;
            }
        }
        return -1;
    }
}
