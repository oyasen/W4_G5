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
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Page
    {
        resturantEntities db = new resturantEntities();
        public sign_up()
        {
            InitializeComponent();
        }

        private void sign_up_button(object sender, RoutedEventArgs e)
        {
            try
            {
                C_managers manager = new C_managers();
                manager.m_name = name_t.Text;
                manager.m_password = password_t.Text;
                manager.m_salary = int.Parse(salary_t.Text);
                manager.m_phone = phone_t.Text;
                manager.branch_id = int.Parse(branch_t.Text);
                db.C_managers.Add(manager);
                db.SaveChanges();
                manager manager1 = new manager();
                NavigationService.Navigate(manager1);
            }
            catch
            {
                MessageBox.Show("wrong input");
            }
        }
    }
}
