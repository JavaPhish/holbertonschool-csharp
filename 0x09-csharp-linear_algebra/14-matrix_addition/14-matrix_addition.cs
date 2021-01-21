using System;


class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Length == matrix2.Length)
        {
            if (matrix1.Length >= 2)
            {

                int uBound0 = matrix1.GetUpperBound(0);
                int uBound1 = matrix1.GetUpperBound(1);
                for (int x = 0; x < uBound0; x++)
                {
                    for (int y = 0; y < uBound1; y++)
                    {
                        matrix1[x, y] = matrix1[x, y] + matrix2[x, y];
                    }
                }
                return matrix1;    
            }

        }

        double[,] fail_sum = new double[,] {{-1}};

        return fail_sum;
    }
}
