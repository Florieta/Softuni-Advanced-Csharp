using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int row = 0;
            int col = 0;
            int food = 0;

            List<int> list = new List<int>();

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'S')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    matrix[row, col] = '.'; // оставя следа '.'
                    row = row - 1; // придвижва се
                    if (row >= 0) // остава вътре
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else // излиза от матрицата и играта приключва
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                }
                else if (command == "down")
                {
                    matrix[row, col] = '.'; // оставя следа '.'
                    row = row + 1; // придвижва се
                    if (row < n) // остава вътре
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else // излиза от матрицата и играта приключва
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                }
                else if (command == "left")
                {
                    matrix[row, col] = '.'; // оставя следа '.'
                    col = col - 1; // придвижва се
                    if (col >= 0) // остава вътре
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else // излиза от матрицата и играта приключва
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                }
                else if (command == "right")
                {
                    matrix[row, col] = '.'; // оставя следа '.'
                    col = col + 1; // придвижва се
                    if (col < n) // остава вътре
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else // излиза от матрицата и играта приключва
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                }

                if (food >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    Console.WriteLine($"Food eaten: {food}");
                    matrix[row, col] = 'S';
                    break;
                }

            }
            PrintMatrix(n, matrix);
        }

        private static void SnakeMoves(int n, char[,] matrix, ref int row, ref int col, ref int food)
        {
            if (matrix[row, col] == '*') //има храна
            {
                food++;
                matrix[row, col] = '.'; // променя настоящата клетка на '.'
            }
            else if (matrix[row, col] == 'B') // влиза в BURROW
            {
                matrix[row, col] = '.';
                for (int rows = 0; rows < n; rows++)
                {
                    for (int cols = 0; cols < n; cols++)
                    {
                        if (matrix[rows, cols] == 'B')
                        {
                            matrix[rows, cols] = '.';
                            row = rows;
                            col = cols;
                        }
                    }
                }
            }
        }

        public static void PrintMatrix(int n, char[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
