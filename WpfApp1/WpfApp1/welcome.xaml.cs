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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for welcome.xaml
    /// </summary>
    public partial class welcome : Page
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login login = new login();
            this.NavigationService.Navigate(login);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            staff_login login = new staff_login();
            this.NavigationService.Navigate(login);
        }
    }
}
