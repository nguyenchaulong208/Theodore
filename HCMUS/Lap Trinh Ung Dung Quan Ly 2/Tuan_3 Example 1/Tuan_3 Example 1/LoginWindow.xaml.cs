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

namespace Tuan_3_Example_1
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButton(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            if(username is "admin")
            {
                var screen = new MainWindow();
                screen.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username");
            }
        }
    }
}
