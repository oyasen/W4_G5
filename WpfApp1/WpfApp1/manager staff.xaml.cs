﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for manager_staff.xaml
    /// </summary>
    public partial class manager_staff : Page
    {
        resturantEntities db = new resturantEntities();
        public manager_staff()
        {
            InitializeComponent();
        }

        private void add_button(object sender, RoutedEventArgs e)
        {

        }

        private void delete_button(object sender, RoutedEventArgs e)
        {

        }

        private void update_button(object sender, RoutedEventArgs e)
        {

        }
    }
}
