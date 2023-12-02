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
            try
            {
                C_food food = new C_food();
                food.name = name_t.Text;
                food.price =int.Parse(price_t.Text);
                db.C_food.Add(food);
                db.SaveChanges();
                MessageBox.Show("added succesfully");
            }
            catch
            {
                MessageBox.Show("wrong input");
            }
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                C_food food = new C_food();  
                food = db.C_food.First(x => x.name == name_t.Text);
                db.C_food.Remove(food);
                MessageBox.Show("removed succesfully");
            }
            catch
            {
                MessageBox.Show("wrong name");
            }
        }

        private void upd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                C_food food = new C_food();       
                food = db.C_food.First(x => x.name == name_t.Text);
                food.name = name_t.Text;
                food.price =int.Parse( price_t.Text);
                db.C_food.AddOrUpdate(food);
                db.SaveChanges();
                MessageBox.Show("updated succesfully");
            }
            catch
            {
                MessageBox.Show("wrong input");
            }
        }

        private void search_button(object sender, RoutedEventArgs e)
        {
            search search = new search();
            NavigationService.Navigate(search);
        }
    }
}
