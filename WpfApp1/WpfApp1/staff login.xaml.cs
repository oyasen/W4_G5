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
    /// Interaction logic for staff_login.xaml
    /// </summary>
    public partial class staff_login : Page
    {

        resturantEntities db = new resturantEntities();
        public staff_login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                C_staff manager = new C_staff();

                manager = db.C_staff.First(x => x.s_name == name_t.Text && x.s_password == password_t.Text);
                staff staff = new staff();
                NavigationService.Navigate(staff);
            }
            catch
            {
                MessageBox.Show("wrong name or password");
            }
        }
    }
}
