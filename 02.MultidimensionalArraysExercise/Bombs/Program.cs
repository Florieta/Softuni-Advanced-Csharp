using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(n, n);

            int sum = 0;
            int count = 0;

            string[] coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var coordinate in coordinates)
            {
                int[] bombIndexes = coordinate.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = bombIndexes[0];
                int col = bombIndexes[1];
                if (matrix[row, col] > 0)
                {
                    if (IsValid(row - 1, col - 1, matrix))
                    {
                        matrix[row - 1, col - 1] -= matrix[row, col];
                    }

                    if (IsValid(row - 1, col, matrix))
                    {
                        matrix[row - 1, col] -= matrix[row, col];
                    }

                    if (IsValid(row - 1, col + 1, matrix))
                    {
                        matrix[row - 1, col + 1] -= matrix[row, col];
                    }

                    if (IsValid(row, col - 1, matrix))
                    {
                        matrix[row, col - 1] -= matrix[row, col];
                    }

                    if (IsValid(row, col + 1, matrix))
                    {
                        matrix[row, col + 1] -= matrix[row, col];
                    }

                    if (IsValid(row + 1, col - 1, matrix))
                    {
                        matrix[row + 1, col - 1] -= matrix[row, col];
                    }

                    if (IsValid(row + 1, col, matrix))
                    {
                        matrix[row + 1, col] -= matrix[row, col];
                    }

                    if (IsValid(row + 1, col + 1, matrix))
                    {
                        matrix[row + 1, col + 1] -= matrix[row, col];
                    }

                    matrix[row, col] = 0;

                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        sum += matrix[row, col];
                        count++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
        private static bool IsValid(int row, int col, int[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1)
                && matrix[row, col] > 0;
        }

        static int[,] ReadMatrix(int rows, int cols)
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
