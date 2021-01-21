using System;

class Program
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == vector2.Length)
        {
            if (vector1.Length == 2)
            {
                double[] vector_sum = new double[2];

                for (int i = 0; i < vector1.Length; i++)
                {
                    vector_sum[i] = (vector1[i] + vector2[i]);
                }

                return vector_sum;
            }

            if (vector1.Length == 3)
            {
                double[] vector_sum = new double[3];

                for (int i = 0; i < vector1.Length; i++)
                {
                    vector_sum[i] = (vector1[i] + vector2[i]);
                }

                return vector_sum;
            }
        }

        double[] fail_sum = new double[] {-1};

        return fail_sum;
    }
}
