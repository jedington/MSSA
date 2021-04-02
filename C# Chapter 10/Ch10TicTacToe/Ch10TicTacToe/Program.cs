using System;
using System.Linq;

namespace Ch10TicTacToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[,] ticTacToeBoard =
            {
                {'-','-','-'},
                {'-','-','-'},
                {'-','-','-'}
            };
            int winX = 0, winO = 0;

            for (int turns = 0; turns < 4; turns++)
            {
                UserInput(ticTacToeBoard, 'X');
                UserInput(ticTacToeBoard, 'O');
                (winX, winO) = CheckWin(ticTacToeBoard);
                if (winX == 1 && winO == 0)
                {
                    Console.Write($"\nPlayer X wins!");
                    return;
                }
                if (winX == 0 && winO == 1)
                {
                    Console.Write($"\nPlayer O wins!");
                    return;
                }
            }
            if (winX == 0 && winO == 0)
            {
                Console.Write($"\nIt's a Draw!");
            }
        } // Main method ends

        static void UserInput(char[,] ticTacToeBoard, char player)
        {
            bool check = false;
            while (check == false)
            {
                try
                {
                    start_of_loop:
                    Console.Write($"\nPlayer {player}, Choose a row: ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"\nPlayer {player}, Choose a column: ");
                    int col = Convert.ToInt32(Console.ReadLine());
                    if (ticTacToeBoard[row, col] == 'X' || ticTacToeBoard[row, col] == 'O')
                    {
                        Console.Write($"\nInvalid... spot is taken. Try Again, Player {player}");
                        goto start_of_loop;
                    }
                    if (player == 'X')
                    {
                        ticTacToeBoard[row, col] = 'X';
                    }
                    else if (player == 'O')
                    {
                        ticTacToeBoard[row, col] = 'O';
                    }
                    UseBoard(ticTacToeBoard);
                    check = true;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine($"{fe.Message}... Try again, Player {player}.");
                }
                catch (SystemException se)
                {
                    Console.WriteLine($"{se.Message}... Try again, Player {player}.");
                }
            }
        } // UserInput method ends

        static void UseBoard(char[,] ticTacToeBoard)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(ticTacToeBoard[row, col]);
                }
                Console.WriteLine();
            }
        } // UseBoard method ends

        static (int winX, int winO) CheckWin(char[,] ticTacToeBoard)
        {
            ILookup<string, string> winnerWinnerChickenDinner 
                = Enumerable.Range(0, 3)
                .SelectMany(n => new[] // check rows & cols //
                {
                    Enumerable.Range(0, 3)
                        .Select(x => ticTacToeBoard[n, x]),
                    Enumerable.Range(0, 3)
                        .Select(x => ticTacToeBoard[x, n]),
                })
                .Concat(new[] // check diagonals //
                {
                    Enumerable.Range(0, 3)
                        .Select(x => ticTacToeBoard[x, x]),
                    Enumerable.Range(0, 3)
                        .Select(x => ticTacToeBoard[x, 2 - x]),
                })
                // chars => string //
                .Select(joinChars => String.Join($"", joinChars)) 
                // returns Lookup //
                .ToLookup(x => x); 

            return (winnerWinnerChickenDinner["XXX"].Count(), winnerWinnerChickenDinner["OOO"].Count());
        } // CheckWin method ends
    } // class ends
} // namespace ends