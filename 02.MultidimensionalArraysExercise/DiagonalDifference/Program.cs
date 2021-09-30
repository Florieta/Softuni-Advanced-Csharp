using System;
using System.Linq;

namespace MultidimensionalArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(n, n);

            

            int primaryDiagonal = 0;
            int secondDiagonal = 0;
            for (int row = 0; row < n; row++)
            {
                primaryDiagonal += matrix[row, row];
                secondDiagonal += matrix[row, n - row - 1];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondDiagonal));
        }

        static int[,] ReadMatrix (int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            return matrix;
        }
    }
}
