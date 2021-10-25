using System;

namespace SquareMatrix
{
    public class Kata
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2 }, { 3, 2 } };
            int[,] b = { { 3, 2 }, { 1, 1 } };
            MatrixMultiplication(a, b);
        }

        public static int[,] MatrixMultiplication(int[,] a, int[,] b)
        {
            int rowsA = a.GetLength(0);
            int rowsB = b.GetLength(0);
            int columnsA = a.GetLength(1);
            int columnsB = b.GetLength(1);
            int[,] result = new int[rowsA, columnsB];
            int sum = 0;
            if (columnsA != rowsB)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < columnsB; j++)
                    {
                        sum = 0;
                        for (int z = 0; z < columnsA; z++)
                        {
                            sum += a[i, z] * b[z, j];
                        }
                        result[i, j] = sum;
                    }
                }
            }
            return result;
        }

        public static void ShowArray(int[,] a)
        {
            int rowsNum = a.GetLength(0);
            int columnsNum = a.GetLength(1);

            for (int i = 0; i < rowsNum; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < columnsNum; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
            }
        }
    }
}
