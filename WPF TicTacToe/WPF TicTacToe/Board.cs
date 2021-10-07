using System;
using System.Collections.Generic;
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
    class Board : MainWindow
    {
        public void Draw()
        {

            Grid grid = new Grid();
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            grid.VerticalAlignment = VerticalAlignment.Center;
            this.Content = grid;

            ColumnDefinition col1 = new ColumnDefinition();
            ColumnDefinition col2 = new ColumnDefinition();
            ColumnDefinition col3 = new ColumnDefinition();
            grid.ColumnDefinitions.Add(col1);
            grid.ColumnDefinitions.Add(col2);
            grid.ColumnDefinitions.Add(col3);


            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();
            RowDefinition row3 = new RowDefinition();
            grid.RowDefinitions.Add(row1);
            grid.RowDefinitions.Add(row2);
            grid.RowDefinitions.Add(row3);


            Button btn1 = new Button();
            btn1.Content = '1';
            btn1.Width = 50;
            btn1.Height = 50;
            btn1.PreviewMouseUp += new MouseButtonEventHandler(Button_Click);
            Grid.SetRow(btn1, 0);
            Grid.SetColumn(btn1, 0);


            Button btn2 = new Button();
            btn2.Content = '2';
            btn2.Width = 50;
            btn2.Height = 50;
            btn2.PreviewMouseUp += new MouseButtonEventHandler(Button_Click);
            Grid.SetRow(btn2, 0);
            Grid.SetColumn(btn2, 1);

            Button btn3 = new Button();
            btn3.Content = '3';
            btn3.Width = 50;
            btn3.Height = 50;
            btn3.PreviewMouseUp += new MouseButtonEventHandler(Button_Click);
            Grid.SetRow(btn3, 0);
            Grid.SetColumn(btn3, 2);

            Button btn4 = new Button();
            btn4.Content = '4';
            btn4.Width = 50;
            btn4.Height = 50;
            btn4.PreviewMouseUp += new MouseButtonEventHandler(Button_Click);
            Grid.SetRow(btn4, 1);
            Grid.SetColumn(btn4, 0);

            Button btn5 = new Button();
            btn5.Content = '5';
            btn5.Width = 50;
            btn5.Height = 50;
            btn5.PreviewMouseUp += new MouseButtonEventHandler(Button_Click);
            Grid.SetRow(btn5, 1);
            Grid.SetColumn(btn5, 1);

            Button btn6 = new Button();
            btn6.Content = '6';
            btn6.Width = 50;
            btn6.Height = 50;
            btn6.PreviewMouseUp += new MouseButtonEventHandler(Button_Click);
            Grid.SetRow(btn6, 1);
            Grid.SetColumn(btn6, 3);


            Button btn7 = new Button();
            btn7.Content = '7';
            btn7.Width = 50;
            btn7.Height = 50;
            btn7.PreviewMouseUp += new MouseButtonEventHandler(Button_Click);
            Grid.SetRow(btn7, 2);
            Grid.SetColumn(btn7, 0);


            Button btn8 = new Button();
            btn8.Content = '8';
            btn8.Width = 50;
            btn8.Height = 50;
            btn8.PreviewMouseUp += new MouseButtonEventHandler(Button_Click);
            Grid.SetRow(btn8, 2);
            Grid.SetColumn(btn8, 1);


            Button btn9 = new Button();
            btn9.Content = '9';
            btn9.Width = 50;
            btn9.Height = 50;
            btn9.PreviewMouseUp += new MouseButtonEventHandler(Button_Click);
            Grid.SetRow(btn9, 2);
            Grid.SetColumn(btn9, 2);

            grid.Children.Add(btn1);
            grid.Children.Add(btn2);
            grid.Children.Add(btn3);
            grid.Children.Add(btn4);
            grid.Children.Add(btn5);
            grid.Children.Add(btn6);
            grid.Children.Add(btn7);
            grid.Children.Add(btn8);
            grid.Children.Add(btn9);
        }
    }
}
