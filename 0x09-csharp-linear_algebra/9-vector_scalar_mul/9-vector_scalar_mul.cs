using System;


class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {

        if (vector.Length == 2)
        {
            double[] vector_mul = new double[2];

            for (int i = 0; i < vector.Length; i++)
            {
                vector_mul[i] = (vector[i] * scalar);
            }

            return vector_mul;
        }

        if (vector.Length == 3)
        {
            double[] vector_mul = new double[3];

            for (int i = 0; i < vector.Length; i++)
            {
                vector_mul[i] = (vector[i] * scalar);
            }

            return vector_mul;
        }

        double[] fail_mul = new double[] {-1};

        return fail_mul;
    }
}
