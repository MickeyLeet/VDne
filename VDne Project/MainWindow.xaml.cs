﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace VDne_Project
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



        //private void Te_Click(object sender, RoutedEventArgs e)
        //{
        //    //frame1.Source = ssss;
        //    reg_log_frame.Source = new Uri("LoginPage.xaml", UriKind.RelativeOrAbsolute);
        //    main_frame.Opacity = 0.5;
        //}

        private void Label_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Dsa_Click(object sender, RoutedEventArgs e)
        {
                for (int i = 0; i < 500; i++)
                {
                    log.Width = i;
                    Thread.Sleep(1000);
            }
        }
    }
}
