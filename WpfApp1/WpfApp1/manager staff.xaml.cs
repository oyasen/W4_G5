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
    /// Interaction logic for manager_staff.xaml
    /// </summary>
    public partial class manager_staff : Page
    {
        resturantEntities db = new resturantEntities();
        public manager_staff()
        {
            InitializeComponent();
        }

        private void add_button(object sender, RoutedEventArgs e)
        {
            try
            {
                C_staff staff = new C_staff();
                staff.s_name = name_t.Text;
                staff.s_password = password_t.Text;
                staff.s_salary = int.Parse(salary_t.Text);
                staff.s_age = int.Parse(age_t.Text);
                staff.s_phone = phone_t.Text;
                staff.s_specialty = spec_t.Text;
                staff.b_id = int.Parse(branch_t.Text);
                db.C_staff.Add(staff);
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
                C_staff staff = new C_staff();
                int id = int.Parse(id_t.Text);
                staff = db.C_staff.First(x => x.s_id == id);
                db.C_staff.Remove(staff);
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
                C_staff staff = new C_staff();
                int id = int.Parse(id_t.Text);
                staff = db.C_staff.First(x => x.s_id == id);
                staff.s_name = name_t.Text;
                staff.s_password = password_t.Text;
                staff.s_salary = int.Parse(salary_t.Text);
                staff.s_age = int.Parse(age_t.Text);
                staff.s_phone = phone_t.Text;
                staff.s_specialty = spec_t.Text;
                staff.b_id = int.Parse(branch_t.Text);
                db.C_staff.AddOrUpdate(staff);
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
