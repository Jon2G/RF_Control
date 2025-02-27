﻿using RFControl;
using System.Windows;
using System.Windows.Input;

namespace RFWin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    RFController.Move(DIRECTIONS.UP);
                    break;
                case Key.Down:
                    RFController.Move(DIRECTIONS.DOWN);
                    break;
                case Key.Right:
                    RFController.Move(DIRECTIONS.RIGHT);
                    break;
                case Key.Left:
                    RFController.Move(DIRECTIONS.LEFT);
                    break;
            }
        }
    }
}
