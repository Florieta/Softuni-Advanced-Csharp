using System;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            var rows = int.Parse(Console.ReadLine());

            char[][] maze = new char[rows][];

            var currentRow = 0;
            var currentCol = 0;

            for (int row = 0; row < maze.GetLength(0); row++)
            {
                var mazeRow = Console.ReadLine();
                maze[row] = new char[mazeRow.Length];

                for (int col = 0; col < mazeRow.Length; col++)
                {
                    maze[row][col] = mazeRow[col];
                    if (maze[row][col] == 'M')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }
            bool missionAcomplished = false;

            while (true)
            {
                var moves = Console.ReadLine().Split();
                char direction = char.Parse(moves[0]);
                var spawnRow = int.Parse(moves[1]);
                var spawnCol = int.Parse(moves[2]);

                maze[spawnRow][spawnCol] = 'B';
                lives--;
                switch(direction)
                {
                    case 'W':
                        if (currentRow - 1 < 0)
                            {
                            continue;
                        }
                        maze[currentRow][currentCol] = '-';
                        currentRow--;
                        break;
                    case 'S':
                        if (currentRow + 1 == rows)
                        {
                            continue;
                        }
                        maze[currentRow][currentCol] = '-';
                        currentRow++;
                        break;
                    case 'A':
                        if (currentCol - 1 < 0)
                        {
                            continue;
                        }
                        maze[currentRow][currentCol] = '-';
                        currentCol--;
                        break;
                    case 'D':
                        if (currentCol + 1 == maze[currentRow].Length)
                        {
                            continue;
                        }
                        maze[currentRow][currentCol] = '-';
                        currentCol++;
                        break;
                }
                if (lives <= 0)
                {
                    maze[currentRow][currentCol] = 'X';
                    break;
                }
                if (maze[currentRow][currentCol] == 'B')
                {
                    lives -= 2;
                    if (lives <= 0)
                    {
                        maze[currentRow][currentCol] = 'X';
                        break;
                    }
                }
                else if (maze[currentRow][currentCol] == 'P')
                {
                    missionAcomplished = true;
                    maze[currentRow][currentCol] = '-';
                    break;
                }

                maze[currentRow][currentCol] = 'M';
            }

            if (missionAcomplished)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            else
            {
                Console.WriteLine($"Mario died at {currentRow};{currentCol}.");
            }

            foreach (char[] row in maze)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
