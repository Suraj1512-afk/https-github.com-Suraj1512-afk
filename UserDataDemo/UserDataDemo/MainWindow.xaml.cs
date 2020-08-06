using ModelsAndDTO;
using System.Text.RegularExpressions;
using System.Windows;

namespace UserDataDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserDTO userDTO;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Validate())
            {
                UsersListPage userListPage = new UsersListPage();
                userListPage.TextBlockHeading.Text = textBoxUserName.Text;
                userListPage.Show();
                this.Close();
            }
        }

        private bool Validate()
        {
            if (textBoxUserName.Text.Length == 0 && textBoxPassword.Password.Length == 0)
            {
                usernameErrorMessage.Text = "Please enter valid name";
                passwordErrorMessage.Text = "Please enter valid password";
                textBoxUserName.Focus();
                return false;
            }
            if (textBoxUserName.Text.Length > 20)
            {
                usernameErrorMessage.Text = "Username cannot be greater than 15";
                textBoxUserName.Focus();
                return false;
            }
            if (textBoxPassword.Password.Length == 0)
            {
                passwordErrorMessage.Text = "Please enter valid password";
                textBoxPassword.Focus();
                return false;
            }
            if (!Regex.IsMatch(textBoxPassword.Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$"))
            {
                passwordErrorMessage.Text = "Required one capital letter, a Number and lenght should be 8 to 15";
                textBoxPassword.Focus();
                return false;
            }
            return true;
        }
    }
}
