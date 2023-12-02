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
    /// Interaction logic for manger_branch.xaml
    /// </summary>
    public partial class manger_branch : Page
    {
        resturantEntities db = new resturantEntities();
        public manger_branch()
        {
            InitializeComponent();
        }

        private void add_button(object sender, RoutedEventArgs e)
        {
            try
            {
                C_branch branch = new C_branch();
                branch.b_name = name_t.Text;
                branch.b_address = address_t.Text;                                                                       
                db.C_branch.Add(branch);
                db.SaveChanges();
                MessageBox.Show("added succesfully");
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
                C_branch branch = new C_branch();
                int id = int.Parse(id_t.Text);
                branch = db.C_branch.First(x => x.b_id == id);
                db.C_branch.Remove(branch);
                MessageBox.Show("removed succesfully");
            }
            catch
            {
                MessageBox.Show("wrong id");
            }
        }

        private void update_button(object sender, RoutedEventArgs e)
        {
            try
            {
                C_branch branch = new C_branch();
                int id = int.Parse(id_t.Text);
                branch = db.C_branch.First(x => x.b_id == id);
                branch.b_name = name_t.Text;
                branch.b_address = address_t.Text;
                db.C_branch.AddOrUpdate(branch);
                db.SaveChanges();
                MessageBox.Show("updated succesfully");
            }
            catch
            {
                MessageBox.Show("wrong input");
            }
        }

    }
}
