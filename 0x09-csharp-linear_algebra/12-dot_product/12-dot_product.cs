using System;


class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == vector2.Length)
        {
            if (vector1.Length >= 2)
            {
                double sum = 0;

                for (int i = 0; i < vector1.Length; i++)
                {
                    sum += (vector1[i] + vector2[i]);
                }

                return vector_sum;
            }
        }
        return -1;
    }
}
