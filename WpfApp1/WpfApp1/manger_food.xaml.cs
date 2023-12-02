using System;
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
    /// Interaction logic for manger_food.xaml
    /// </summary>
    public partial class manger_food : Page
    {
        resturantEntities db = new resturantEntities();
        public manger_food()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void del_Click(object sender, RoutedEventArgs e)
        {

        }

        private void upd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void search_button(object sender, RoutedEventArgs e)
        {

        }
    }
}
