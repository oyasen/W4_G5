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
    /// Interaction logic for showfood.xaml
    /// </summary>
    public partial class showfood : Page
    {
        resturantEntities db = new resturantEntities();
        public showfood()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                data_grid.ItemsSource = db.C_food.Where(x => x.name == search_t.Text).ToList();
            }
            catch
            {
                MessageBox.Show("wrong input");
            }
        }
    }
}
