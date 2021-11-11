using System;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            char[,] field = new char[fieldSize, fieldSize];
            string[] attackCommands = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            int playerOneShips = 0;
            int playerTwoShips = 0;
            for (int row = 0; row < field.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = char.Parse(input[col]);
                    if (field[row, col] == '<')
                    {
                        playerOneShips++;
                    }
                    else if (field[row, col] == '>')
                    {
                        playerTwoShips++;
                    }
                }
            }
            int shipsDestroyed = 0;
            for (int i = 0; i < attackCommands.Length; i++)
            {
                string[] splittedCommands = attackCommands[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int attackRow = int.Parse(splittedCommands[0]);
                int attackCol = int.Parse(splittedCommands[1]);

                if (attackRow < 0 || attackRow >= fieldSize)
                {
                    continue;
                }
                if (attackCol < 0 || attackCol >= fieldSize)
                {
                    continue;
                }

                if (field[attackRow, attackCol] == '*')//regular position
                {
                    continue;
                }
                else if (field[attackRow, attackCol] == '<')// first player
                {
                    field[attackRow, attackCol] = 'X';
                    playerOneShips--;
                    shipsDestroyed++;
                }
                else if (field[attackRow, attackCol] == '>')//second player
                {
                    field[attackRow, attackCol] = 'X';
                    playerTwoShips--;
                    shipsDestroyed++;
                }
                else if (field[attackRow, attackCol] == '#')//mine
                {
                    field[attackRow, attackCol] = 'X';
                    if (attackRow - 1 >= 0)
                    {
                        if (field[attackRow - 1, attackCol] == '<')
                        {
                            field[attackRow - 1, attackCol] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (field[attackRow - 1, attackCol] == '>')
                        {
                            field[attackRow - 1, attackCol] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }
                    if (attackRow + 1 < fieldSize)
                    {
                        if (field[attackRow + 1, attackCol] == '<')
                        {
                            field[attackRow + 1, attackCol] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (field[attackRow + 1, attackCol] == '>')
                        {
                            field[attackRow + 1, attackCol] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }
                    if (attackCol - 1 >= 0)
                    {
                        if (field[attackRow, attackCol - 1] == '<')
                        {
                            field[attackRow, attackCol - 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (field[attackRow, attackCol - 1] == '>')
                        {
                            field[attackRow, attackCol - 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }
                    if (attackCol + 1 < fieldSize)
                    {
                        if (field[attackRow, attackCol + 1] == '<')
                        {
                            field[attackRow, attackCol + 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (field[attackRow, attackCol + 1] == '>')
                        {
                            field[attackRow, attackCol + 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }
                    if (attackRow - 1 >= 0 && attackCol - 1 >= 0)
                    {
                        if (field[attackRow - 1, attackCol - 1] == '<')
                        {
                            field[attackRow - 1, attackCol - 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (field[attackRow - 1, attackCol - 1] == '>')
                        {
                            field[attackRow - 1, attackCol - 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }
                    if (attackRow - 1 >= 0 && attackCol + 1 < fieldSize)
                    {
                        if (field[attackRow - 1, attackCol + 1] == '<')
                        {
                            field[attackRow - 1, attackCol + 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (field[attackRow - 1, attackCol + 1] == '>')
                        {
                            field[attackRow - 1, attackCol + 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }
                    if (attackRow + 1 < fieldSize && attackCol - 1 >= 0)
                    {
                        if (field[attackRow + 1, attackCol - 1] == '<')
                        {
                            field[attackRow + 1, attackCol - 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (field[attackRow + 1, attackCol - 1] == '>')
                        {
                            field[attackRow + 1, attackCol - 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }
                    if (attackRow + 1 < fieldSize && attackCol + 1 < fieldSize)
                    {
                        if (field[attackRow + 1, attackCol + 1] == '<')
                        {
                            field[attackRow + 1, attackCol + 1] = 'X';
                            playerOneShips--;
                            shipsDestroyed++;
                        }
                        else if (field[attackRow + 1, attackCol + 1] == '>')
                        {
                            field[attackRow + 1, attackCol + 1] = 'X';
                            playerTwoShips--;
                            shipsDestroyed++;
                        }
                    }
                }

                if (playerOneShips <= 0)
                {
                    break;
                }

                if (playerTwoShips <= 0)
                {
                    break;
                }
            }

            if (playerOneShips <= 0)
            {
                Console.WriteLine($"Player Two has won the game! {shipsDestroyed} ships have been sunk in the battle.");
            }
            else if (playerTwoShips <= 0)
            {
                Console.WriteLine($"Player One has won the game! {shipsDestroyed} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips} ships left. Player Two has {playerTwoShips} ships left.");
            }
        }
    }
}
