﻿using Stopwatch.ViewModel;
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

namespace Stopwatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly StopwatchViewModel _stopWatchVM;

        public MainWindow()
        {
            InitializeComponent();
            _stopWatchVM = new StopwatchViewModel();
            DataContext = _stopWatchVM;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            _stopWatchVM.Start();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            _stopWatchVM.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            _stopWatchVM.Stop();
        }
    }
}
