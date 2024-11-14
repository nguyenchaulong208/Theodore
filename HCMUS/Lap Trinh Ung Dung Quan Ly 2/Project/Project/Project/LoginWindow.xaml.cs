using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
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
        private void LoadWindow(object sender, RoutedEventArgs e)
        {
            //Lấy thông tin username và password đã mã hóa từ file config
            string encryptedUsernameString = ConfigurationManager.AppSettings["Username"];
            string encryptedPasswordString = ConfigurationManager.AppSettings["Password"];
            string entropyString = ConfigurationManager.AppSettings["Entropy"];
            //Giải mã thông tin username và password
            var encryptedUsernameInBytes = Convert.FromBase64String(encryptedUsernameString);
            var encryptedPasswordInBytes = Convert.FromBase64String(encryptedPasswordString);
            var entropy = Convert.FromBase64String(entropyString);
            var usernameBytes = ProtectedData.Unprotect(encryptedUsernameInBytes, entropy, DataProtectionScope.CurrentUser);
            var passwordBytes = ProtectedData.Unprotect(encryptedPasswordInBytes, entropy, DataProtectionScope.CurrentUser);
            var username = Encoding.UTF8.GetString(usernameBytes);
            var password = Encoding.UTF8.GetString(passwordBytes);
            //Hiển thị thông tin username và password
            var usernameSave = ConfigurationManager.AppSettings["Username"];
            var passwordSave = ConfigurationManager.AppSettings["Password"];
            //Hiển thị thông tin username và password lên textbox
            usernameTxt.Text = username;
            passwordTxt.Password = password;

        }

        private void loginBtn(object sender, RoutedEventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Password;
          
            if (username == "admin" && password == "admin")
            {
                var mainScreen = new MainWindow();
                MessageBox.Show("Đăng nhập thành công");
                mainScreen.Show();
                this.Close();
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                if (rememberChecked.IsChecked == true)
                {
                    //mã hóa username và password
                    var usernameInBytes = Encoding.UTF8.GetBytes(username);
                    var passwordInBytes = Encoding.UTF8.GetBytes(password);
                    var entropy = new byte[20];
                    using (var randomGenerator =RandomNumberGenerator.Create())
                    {
                        randomGenerator.GetBytes(entropy);
                    }
                    var encryptedUsername = ProtectedData.Protect(Encoding.UTF8.GetBytes(username), entropy, DataProtectionScope.CurrentUser);
                    var encryptedUsernameString = Convert.ToBase64String(encryptedUsername);
                    var encryptedPassword = ProtectedData.Protect(passwordInBytes, entropy, DataProtectionScope.CurrentUser);
                    var encryptedPasswordString = Convert.ToBase64String(encryptedPassword);
                    var entropyString = Convert.ToBase64String(entropy);

                    //ghi thong tin dang nhap sau khi ma hoa vao file config
                    config.AppSettings.Settings["Entropy"].Value = entropyString;
                    config.AppSettings.Settings["Username"].Value = encryptedUsernameString;
                    config.AppSettings.Settings["Password"].Value = encryptedPasswordString;
                    //Luu file config
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                else
                {
                    config.AppSettings.Settings["Username"].Value = "";
                    config.AppSettings.Settings["Password"].Value = "";
                    config.AppSettings.Settings["Entropy"].Value = "";
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác");
            }
                


            
        }

       
    }
}
