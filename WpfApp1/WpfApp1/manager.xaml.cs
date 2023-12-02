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
    /// Interaction logic for manager.xaml
    /// </summary>
    public partial class manager : Page
    {
        public manager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            manager_staff manager = new manager_staff();
            this.NavigationService.Navigate(manager);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            search search = new search();
            NavigationService.Navigate(search);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            manger_branch manage = new manger_branch();
            this.NavigationService.Navigate(manage);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            manger_food manage = new manger_food();
            this.NavigationService.Navigate(manage);
        }
    }
}
