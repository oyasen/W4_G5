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
    /// Interaction logic for manage_orders.xaml
    /// </summary>
    public partial class manage_orders : Page
    {
        resturantEntities db = new resturantEntities();
        public manage_orders()
        {
            InitializeComponent();
        }

        private void add_button(object sender, RoutedEventArgs e)
        {
            try
            {
                C_orders order = new C_orders();
                
                order.o_date = DateTime.Parse( date_t.Text);
                order.f_name = food_t.Text;
                order.c_id =int.Parse( c_id_t.Text);
                db.C_orders.Add(order);
                db.SaveChanges();

                MessageBox.Show("added succesfully");
            }
            catch
            {
                MessageBox.Show("wrong input");
            }
        }

        private void update_button(object sender, RoutedEventArgs e)
        {
            try
            {
                C_orders order = new C_orders();
                int id = int.Parse(id_t.Text);
                order = db.C_orders.First(x => x.o_id == id);

                order.o_date = DateTime.Parse(date_t.Text);
                order.f_name = food_t.Text;
                order.c_id = int.Parse(c_id_t.Text);
                db.C_orders.AddOrUpdate(order);
                db.SaveChanges();
                MessageBox.Show("updated succesfully");
            }
            catch
            {
                MessageBox.Show("wrong input");
            }
        }

        private void delete_button(object sender, RoutedEventArgs e)
        {
            try
            {
                C_orders order = new C_orders();
                int id = int.Parse(id_t.Text);
                order = db.C_orders.First(x => x.o_id == id);
                db.C_orders.Remove(order);
                MessageBox.Show("removed succesfully");
            }
            catch
            {
                MessageBox.Show("wrong id");
            }
        }
    }
}
