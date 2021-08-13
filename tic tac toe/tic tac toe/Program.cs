using System;

namespace tic_tac_toe
{
    class Program
    {

        static char[,] board = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        static char player1 = 'X';
        static char player2 = 'O';
        static char brikke = player1;
        static sbyte count;
        static bool win = false;
        static char winner;

        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Start();
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        static void Start()
        {
            Console.WriteLine("Tic Tac Toe!");
            count = 1;
            Turn();
        }

        static void Turn()
        {

            if (CheckLine())
            {
                EndGame();
            }
            else
            {
                if (count <= 9)
                {
                    DrawBoard();
                    byte move = Input();
                    CheckTurn(move);
                }
                else
                {
                    EndGame();
                }
            }
        }

        static void EndGame()
        {
            Console.Clear();
            DrawBoard();
            if (win) { if (winner.Equals('X')) { Console.WriteLine($"Player 1 won!"); } else { Console.WriteLine($"Player 2 won!"); } } else { Console.WriteLine("It is a draw!"); }
            ListenEvent();
        }

        static void DrawBoard()
        {
            Console.Clear();

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("     |     |     ");
            Console.WriteLine("\n");
        }

        static byte Input()
        {
            if (brikke == player1) { Console.Write("Player 1: "); } else { Console.Write("Player 2: "); }
            string input = Console.ReadLine();

            try
            {
                byte number = Convert.ToByte(input);
                if (number >= 1 && number <= 9) { return number; } else { return 0; }
            }
            catch (FormatException)
            {
                return 0;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }

        static void CheckTurn(byte move)
        {
            byte row = 0;
            byte col = 0;

            if (move == 1 || move == 2 || move == 3)
            {
                row = 0;
                switch (move)
                {
                    case 1: col = 0; break;
                    case 2: col = 1; break;
                    case 3: col = 2; break;
                    default: break;
                }
            }
            else if (move == 4 || move == 5 || move == 6)
            {
                row = 1;
                switch (move)
                {
                    case 4: col = 0; break;
                    case 5: col = 1; break;
                    case 6: col = 2; break;
                    default: break;
                }
            }
            else if (move == 7 || move == 8 || move == 9)
            {
                row = 2;
                switch (move)
                {
                    case 7: col = 0; break;
                    case 8: col = 1; break;
                    case 9: col = 2; break;
                    default: break;
                }
            }

            if (board[row, col].Equals('X') || board[row, col].Equals('O')) { Turn(); } else { count++; DoTurn(move); Turn(); }
        }

        static void DoTurn(byte move)
        {
            switch (move)
            {
                case 1: board[0, 0] = brikke; break;
                case 2: board[0, 1] = brikke; break;
                case 3: board[0, 2] = brikke; break;
                case 4: board[1, 0] = brikke; break;
                case 5: board[1, 1] = brikke; break;
                case 6: board[1, 2] = brikke; break;
                case 7: board[2, 0] = brikke; break;
                case 8: board[2, 1] = brikke; break;
                case 9: board[2, 2] = brikke; break;
                default: break;
            }

            NextPlayer();
        }

        static void NextPlayer()
        {
            if (brikke.Equals(player2)) { brikke = player1; } else { brikke = player2; }
        }

        static Boolean CheckLine()
        {
            char[] playerChars = { 'X', 'O' };

            foreach (char playerChar in playerChars)
            {
                if (((board[0, 0] == playerChar && board[0, 1] == playerChar && board[0, 2] == playerChar))
                    || ((board[0, 0] == playerChar && board[0, 1] == playerChar && board[0, 2] == playerChar))
                    || ((board[1, 0] == playerChar && board[1, 1] == playerChar && board[1, 2] == playerChar))
                    || ((board[2, 0] == playerChar && board[2, 1] == playerChar && board[2, 2] == playerChar))
                    || ((board[0, 0] == playerChar && board[1, 0] == playerChar && board[2, 0] == playerChar))
                    || ((board[0, 2] == playerChar && board[1, 2] == playerChar && board[2, 2] == playerChar))
                    || ((board[1, 0] == playerChar && board[1, 1] == playerChar && board[1, 2] == playerChar))
                    || ((board[0, 1] == playerChar && board[1, 1] == playerChar && board[2, 1] == playerChar))
                    || ((board[0, 0] == playerChar && board[1, 1] == playerChar && board[2, 2] == playerChar))
                    || ((board[0, 2] == playerChar && board[1, 1] == playerChar && board[2, 0] == playerChar))
                    )
                {
                    if (playerChar.Equals('X'))
                    {
                        win = true;
                        winner = player1;
                    }
                    else
                    {
                        win = true;
                        winner = player2;
                    }
                }
            }

            if (win)
            {
                return true;
            }
            return false;
        }

        static void ListenEvent()
        {

            Console.WriteLine("To reset game press 'backspace'" +
                "\nTo quit game press 'esc' ");

            ConsoleKeyInfo action = Console.ReadKey();
            if (action.Key == ConsoleKey.Escape) { Environment.Exit(0); } else if (action.Key == ConsoleKey.Backspace) { board = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } }; brikke = player1; win = false; winner = ' '; Console.Clear(); Start(); }
        }
    }
}





