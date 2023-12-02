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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for staff.xaml
    /// </summary>
    public partial class staff : Page
    {
        public staff()
        {
            InitializeComponent();
        }

        private void add_customer(object sender, RoutedEventArgs e)
        {
            manage_customer customer = new manage_customer();
            NavigationService.Navigate(customer);
        }

        private void add_order(object sender, RoutedEventArgs e)
        {
            manage_orders order = new manage_orders();
            NavigationService.Navigate(order);
        }

        private void view_food(object sender, RoutedEventArgs e)
        {
            showfood food = new showfood();
            NavigationService.Navigate(food);
        }

        private void view_customer(object sender, RoutedEventArgs e)
        {
            show_customers customer = new show_customers();
            NavigationService.Navigate(customer);
        }
    }
}
