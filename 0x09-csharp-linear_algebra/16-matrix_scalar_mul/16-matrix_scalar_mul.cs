using System;


class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
 
        if (matrix.Length == 2 || matrix.Length == 3)
        {

            int uBound0 = matrix.GetUpperBound(0);
            int uBound1 = matrix.GetUpperBound(1);
            for (int x = 0; x < uBound0; x++)
            {
                for (int y = 0; y < uBound1; y++)
                {
                    matrix[x, y] = matrix[x, y] * scalar;
                }
            }
            return matrix;    
        }

        double[,] fail_sum = new double[,] {{-1}};

        return fail_sum;   
    }
}
