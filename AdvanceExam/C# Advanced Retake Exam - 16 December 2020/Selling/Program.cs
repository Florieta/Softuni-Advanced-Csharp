using System;
using System.Collections.Generic;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] bakery = new char[n, n];
            int row = 0;
            int col = 0;
            int money = 0;

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < n; cols++)
                {
                    bakery[rows, cols] = input[cols];
                    if (bakery[rows, cols] == 'S')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                bakery[row, col] = '-';
                row = MoveRow(row, input);
                col = MoveCol(col, input);

                if (!IsPositionValid(row, col, n, n))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");

                    break;
                }

                if (char.IsDigit(bakery[row, col]))
                {
                    money += int.Parse(bakery[row, col].ToString());
                }
                else if (bakery[row, col] == 'O') // влиза в BURROW
                {
                    bakery[row, col] = '-';
                    for (int rows = 0; rows < n; rows++)
                    {
                        for (int cols = 0; cols < n; cols++)
                        {
                            if (bakery[rows, cols] == 'O')
                            {
                                bakery[rows, cols] = '-';
                                row = rows;
                                col = cols;
                            }
                        }
                    }
                }

                if (money >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");

                    bakery[row, col] = 'S';
                    break;
                }
            }
            Console.WriteLine($"Money: {money}");
            PrintMatrix(n, bakery);
        }


        private static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }

        private static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
            }

            return col;
        }

        private static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }

            return row;
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
