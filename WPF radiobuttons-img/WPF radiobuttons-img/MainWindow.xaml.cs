﻿using System;
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

namespace WPF_radiobuttons_img
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbMaybe.IsChecked = true;
        }

        private void Yes_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("yes!");
        }

        private void No_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("no!");
        }

        private void Maybe_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("maybe!");
        }
    }
}
