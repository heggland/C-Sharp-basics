using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {


        private static char[,] board = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        private static char Brikke = 'O';
        private static readonly char Player1 = 'X';
        private static readonly char Player2 = 'O';
        private static sbyte Count = 0;
        private static bool Win = false;
        private static bool WinMsg = true;
        private static char Winner = ' ';
        private static string WinnerName = "";



    public MainWindow()
        {
            Console.ReadLine();
            InitializeComponent();

            Grid grid = new Grid();
            this.Content = grid;

            Button btn = new Button();
            btn.Content = "Start";
            btn.Width = 50;
            btn.Height = 50;
            btn.Name = "buttonReset";

            grid.Children.Add(btn);
            btn.PreviewMouseUp += new MouseButtonEventHandler(Start_Game);

            //StartGame();
        }

        public void Start_Game(object sender, MouseButtonEventArgs e)
        {
            DrawBoard();
        }


        public void DrawBoard()
        {

            Grid grid = new Grid();
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            grid.VerticalAlignment = VerticalAlignment.Center;
            this.Content = grid;

            for (int i = 0; i < 5; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                grid.ColumnDefinitions.Add(col);
                RowDefinition row = new RowDefinition();
                grid.RowDefinitions.Add(row);
            }

            for (int i = 1; i < 10; i++)
            {
                Button btn = new Button();
                btn.Content = " ";
                btn.Width = 50;
                btn.Height = 50;
                btn.Name = "button" + i;
                
                switch (i)
                {
                    case 1:
                        Grid.SetRow(btn, 0);
                        Grid.SetColumn(btn, 0);
                        break;
                    case 2:
                        Grid.SetRow(btn, 0);
                        Grid.SetColumn(btn, 1);
                        break;
                    case 3:
                        Grid.SetRow(btn, 0);
                        Grid.SetColumn(btn, 2);
                        break;
                    case 4:
                        Grid.SetRow(btn, 1);
                        Grid.SetColumn(btn, 0);
                        break;
                    case 5:
                        Grid.SetRow(btn, 1);
                        Grid.SetColumn(btn, 1);
                        break;
                    case 6:
                        Grid.SetRow(btn, 1);
                        Grid.SetColumn(btn, 2);
                        break;
                    case 7:
                        Grid.SetRow(btn, 2);
                        Grid.SetColumn(btn, 0);
                        break;
                    case 8:
                        Grid.SetRow(btn, 2);
                        Grid.SetColumn(btn, 1);
                        break;
                    case 9:
                        Grid.SetRow(btn, 2);
                        Grid.SetColumn(btn, 2);
                        break;
                    default:
                        break;
                }

                grid.Children.Add(btn);
                btn.PreviewMouseUp += new MouseButtonEventHandler(Button_Click);

                Button btnReset = new Button();
                btnReset.Content = "Reset";
                btnReset.Width = 50;
                btnReset.Height = 50;
                btnReset.Name = "buttonReset";

                Grid.SetRow(btnReset, 4);
                Grid.SetColumn(btnReset, 1);

                grid.Children.Add(btnReset);
                btnReset.PreviewMouseUp += new MouseButtonEventHandler(Reset_Game);
            }
        }

        public void Reset_Game(object sender, MouseButtonEventArgs e)
        {
            ResetGame();
            DrawBoard();
        }

        public void Button_Click(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            string ContentChar = (string)(sender as Button).Content.ToString();

            if (ContentChar.Equals(" ") && !Win)
            {
                Count++;

                if (Brikke.Equals(Player1))
                {
                    Brikke = Player2;
                    button.Content = Player2;
                }
                else
                {
                    Brikke = Player1;
                    button.Content = Player1;
                } 
                
                DoTurn(sender);
                
            }
            else if (ContentChar.Equals("X") && !Win  || ContentChar.Equals("O") && !Win)
            {
                MessageBox.Show("Illegal move, try again.");
            }

            if (Count >= 5) { 
                CheckWin();
            }
        }

        private void CheckWin()
        {
            CheckLine();
            if (Win)
            {
                if (Winner.Equals('X')) { WinnerName = "Player 1"; } else { WinnerName = "Player 2"; }

                if (WinMsg) { 
                    MessageBox.Show("We have a winner: " + Winner + " " + WinnerName);
                    WinMsg = false;
                } 

            } else if (!Win && Count >= 9)
            {
                MessageBox.Show("It is a tie!");
            }
        }

        private static void DoTurn(object sender)
        {
            string ButtonId = (string)(sender as Button).Name.ToString();
            char[] x = ButtonId.ToCharArray();

            switch (int.Parse(x[6].ToString()))
            {
                case 1: board[0, 0] = Brikke; break;
                case 2: board[0, 1] = Brikke; break;
                case 3: board[0, 2] = Brikke; break;
                case 4: board[1, 0] = Brikke; break;
                case 5: board[1, 1] = Brikke; break;
                case 6: board[1, 2] = Brikke; break;
                case 7: board[2, 0] = Brikke; break;
                case 8: board[2, 1] = Brikke; break;
                case 9: board[2, 2] = Brikke; break;
                default: break;
            }
        }

        private static void CheckLine()
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
                    if (playerChar.Equals(Player1))
                    {
                        Win = true;
                        Winner = Player1;
                    }
                    else
                    {
                        Win = true;
                        Winner = Player2;
                    }
                }
            }
        }

        private void ResetGame()
        {
            board = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            Count = 0;
            Win = false;
            WinMsg = true;
            Brikke = Player2;
            WinnerName = "";

        // TODO: Clear GUI or simply reset it.
        // DrawBoard();
        //System.Windows.Application.Current.Shutdown();
    }
    }
}
