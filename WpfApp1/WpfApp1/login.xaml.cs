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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        resturantEntities db = new resturantEntities();
        public login()
        {
            InitializeComponent();
        }

        private void signup_button(object sender, RoutedEventArgs e)
        {
            sign_up sign_Up = new sign_up();
            NavigationService.Navigate(sign_Up);  
        }

        private void login_button(object sender, RoutedEventArgs e)
        {
            try
            {
                C_managers manager = new C_managers();
                
                manager = db.C_managers.First(x=> x.m_name == name_t.Text && x.m_password == password_t.Text);
                manager manager1= new manager();
                NavigationService.Navigate(manager1);
            }
            catch
            {
                MessageBox.Show("wrong name or password");
            }
        }
    }
}
