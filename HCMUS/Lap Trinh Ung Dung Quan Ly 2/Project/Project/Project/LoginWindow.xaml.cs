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

namespace Project
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

        private void loginBtn(object sender, RoutedEventArgs e)
        {
            
                if(usernameTxt.Text is "admin" && passwordTxt.Password is "admin")
                {
                    var mainScreen = new MainWindow();
                    MessageBox.Show("Đăng nhập thành công");
                    mainScreen.Show();
                
                    this.Close();
                }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác");
            }
            
        }
    }
}
