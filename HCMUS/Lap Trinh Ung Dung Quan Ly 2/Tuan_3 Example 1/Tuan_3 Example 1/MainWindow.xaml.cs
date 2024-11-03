using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tuan_3_Example_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    

        private void configButton(object sender, RoutedEventArgs e)
        {
            var screen = new ConfigWindow(); //Var sẽ tự nhận diện kiểu dữ liệu theo đối tượng bên trái
            screen.Owner = this;
            var result = screen.ShowDialog();
            if (result == true)
            {
                MessageBox.Show($"da co du lieu moi {screen.NewData}");

            }
            else
            {
                MessageBox.Show("Khong can thay doi gi het");
            }
        }

        private void logoutButton(object sender, RoutedEventArgs e)
        {
            var screen = new LoginWindow();
            screen.Show();
            this.Close();
        }
    }
}