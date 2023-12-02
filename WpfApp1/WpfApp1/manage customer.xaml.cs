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
    /// Interaction logic for manage_customer.xaml
    /// </summary>
    public partial class manage_customer : Page
    {
        resturantEntities db = new resturantEntities();
        public manage_customer()
        {
            InitializeComponent();
        }

        private void add_button(object sender, RoutedEventArgs e)
        {
            try
            {
                C_customers customer = new C_customers();
                customer.c_name = name_t.Text;
                customer.c_phone = phone_t.Text;
                customer.c_location = address_t.Text;
                db.C_customers.Add(customer);
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
                C_customers customer = new C_customers();
                int id = int.Parse(id_t.Text);
                customer = db.C_customers.First(x => x.c_id == id);
                
                customer.c_name = name_t.Text;
                customer.c_phone = phone_t.Text;
                customer.c_location = address_t.Text;
                db.C_customers.AddOrUpdate(customer);
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
                C_customers customer = new C_customers();
                int id = int.Parse(id_t.Text);
                customer = db.C_customers.First(x => x.c_id == id);
                db.C_customers.Remove(customer);
                MessageBox.Show("removed succesfully");
            }
            catch
            {
                MessageBox.Show("wrong id");
            }
        }
    }
}
