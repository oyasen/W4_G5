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
    /// Interaction logic for show_customers.xaml
    /// </summary>
    public partial class show_customers : Page
    {
        resturantEntities db = new resturantEntities();
        public show_customers()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
