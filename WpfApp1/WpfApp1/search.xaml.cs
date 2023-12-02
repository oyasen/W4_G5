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
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        resturantEntities db = new resturantEntities();
        public search()
        {
            InitializeComponent();
            
            
        }

        private void search_button(object sender, RoutedEventArgs e)
        {

                if (combo.Text == "staff")
                {
                    int id = int.Parse(search_text.Text);
                    data_grid.ItemsSource = db.C_staff.Where(x => x.s_id == id).ToList();
                }
                else if (combo.Text == "order")
                {
                    int id = int.Parse(search_text.Text);
                    data_grid.ItemsSource = db.C_orders.Where(x => x.o_id == id).ToList();
                }
                else if (combo.Text == "food")
                {
                    data_grid.ItemsSource = db.C_food.Where(x => x.name == search_text.Text).ToList();
                }
                else if(combo.Text == "customer")
                {
                    int id = int.Parse(search_text.Text);
                    data_grid.ItemsSource = db.C_customers.Where(x => x.c_id == id).ToList();
                }
                else if(combo.Text == "branch")
                {
                    int id = int.Parse(search_text.Text);
                    data_grid.ItemsSource = db.C_branch.Where(x => x.b_id == id).ToList();
                }
                else
                {
                    MessageBox.Show("select somthing first");
                }
            

        }
    }
}
