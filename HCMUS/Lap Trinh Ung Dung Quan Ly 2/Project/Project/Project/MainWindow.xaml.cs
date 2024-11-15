using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var loginScreen = new LoginWindow();
            loginScreen.Show();
        }

        private void danhmucBtn(object sender, RoutedEventArgs e)
        {
            //var screen = new ProductCodeWindow();
            //screen.Show();
            var existingTab = mainTabControl.Items
                        .OfType<TabItem>()
                        .FirstOrDefault(t => t.Header.ToString() == "Danh mục hàng hóa");
            if (existingTab == null)
            {
                // Tạo một TabItem mới
                TabItem newTab = new TabItem();
                newTab.Header = "Danh mục hàng hóa";

                // Nhúng ProductCodeWindow (đã chuyển thành UserControl)
                newTab.Content = new test();

                // Thêm TabItem mới vào TabControl
                mainTabControl.Items.Add(newTab);
                mainTabControl.SelectedItem = newTab; // Chuyển đến tab vừa mở
            }
            else
            {
                mainTabControl.SelectedItem = existingTab; // Chuyển đến tab đã tồn tại
            }

        }
    }
}