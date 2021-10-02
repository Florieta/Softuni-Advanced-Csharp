using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];

            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();

            }
            int removedKnights = 0;

            while (true)
            {
                int khnightRow = -1;
                int khnigthtCol = -1;
                int maxAttacked = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row][col] == 'K')
                        {
                            int tempAttack = CountAttacks(matrix, row, col);
                            if (tempAttack > maxAttacked)
                            {
                                maxAttacked = tempAttack;
                                khnightRow = row;
                                khnigthtCol = col;

                            }
                        }
                }
                }
                if (maxAttacked > 0)
                {
                    matrix[khnightRow][khnigthtCol] = '0';
                    removedKnights++;

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(removedKnights);
        }

        static int CountAttacks(char[][] matrix, int row, int col)
        {
            int attacks = 0;
            if (IsInMatrix(row + 1, col - 2, matrix.Length) && matrix[row + 1][col - 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row - 1, col - 2, matrix.Length) && matrix[row - 1][col - 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row - 1, col + 2, matrix.Length) && matrix[row - 1][col + 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row + 1, col + 2, matrix.Length) && matrix[row + 1][col + 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row - 2, col - 1, matrix.Length) && matrix[row -2][col - 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row - 2, col + 1, matrix.Length) && matrix[row - 2][col + 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row + 2, col - 1, matrix.Length) && matrix[row + 2][col - 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row + 2, col + 1, matrix.Length) && matrix[row + 2][col + 1] == 'K')
            {
                attacks++;
            }
            return attacks;
        }

        private static bool IsInMatrix(int row, int col, int length)
        {
            return row >= 0 && row < length && col >= 0 && col < length;
        }
    }
}
