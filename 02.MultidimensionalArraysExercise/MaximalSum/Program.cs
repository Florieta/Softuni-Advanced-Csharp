using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = ReadMatrix(rows, cols);
            int bestSum = 0;
            int bestRowIndex = 0;
            int bestColIndex = 0;


            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int firstRowSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                    int secondRowSum = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                    int thirdRowSum = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    int currSum = firstRowSum + secondRowSum + thirdRowSum;

                    if (currSum > bestSum)
                    {
                        bestSum = currSum;
                        bestRowIndex = row;
                        bestColIndex = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {bestSum}");

            for (int row = bestRowIndex; row <= bestRowIndex + 2; row++)
            {
                for (int col = bestColIndex; col <= bestColIndex + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
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
