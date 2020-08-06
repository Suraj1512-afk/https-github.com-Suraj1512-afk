using ModelsAndDTO;
using System.Windows;
using System.Windows.Controls;

namespace UserDataDemo
{
    /// <summary>
    /// Interaction logic for UsersListPage.xaml
    /// </summary>
    public partial class UsersListPage : Window
    {
        UserDTO userDTO;
        public UsersListPage()
        {
            InitializeComponent();
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            userDTO = service.GetUsersData(userDTO);
            userDataGrid.ItemsSource = userDTO.UserData;
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            userDTO.UserModel = userDataGrid.SelectedItem as UserModel;
            if (userDTO.UserModel != null)
            {
                UserDetailPage userDetailsPage = new UserDetailPage();
                userDetailsPage.userId.Text = userDTO.UserModel.userId.ToString();
                userDetailsPage.Id.Text = userDTO.UserModel.id.ToString();
                userDetailsPage.title.Text = userDTO.UserModel.title;
                userDetailsPage.completed.Text = userDTO.UserModel.completed == true ? "True" : "False";
                userDetailsPage.Show();
                this.Close();
            }
        }
    }
}
