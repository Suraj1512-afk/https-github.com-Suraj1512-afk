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
using System.Windows.Shapes;

namespace UserDataDemo
{
    /// <summary>
    /// Interaction logic for UserDetailPage.xaml
    /// </summary>
    public partial class UserDetailPage : Window
    {
        public UserDetailPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UsersListPage userListPage = new UsersListPage();
            userListPage.Show();
            this.Close();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    UserListPage userListPage = new UserListPage();
        //    this.Content = userListPage;
        //}
    }
}
