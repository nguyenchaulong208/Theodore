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
using System.Windows.Forms;

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
            loginScreen.ShowDialog();
        }

        private void danhmucBtn(object sender, RoutedEventArgs e)
        {
            var screen = new CategoryScreen();
            //Load data from database lên ListView của CategoryScreen khi mở CategoryScreen lên
            LoadDatabase loadDatabase = new LoadDatabase();
            loadDatabase.LoadCategory(screen);
            screen.ShowDialog();
           





        }

        private void sellScreen(object sender, RoutedEventArgs e)
        {
            var sellScreen = new SellScreen();
            sellScreen.ShowDialog();
        }

        private void purchaseScreen(object sender, RoutedEventArgs e)
        {
            var prurchaseScreen = new PurchaseScreen();
            prurchaseScreen.ShowDialog();
            
        }

        private void TonghopBtn(object sender, RoutedEventArgs e)
        {
            var screen = new TestQuery();
            screen.Owner = this;
            screen.ShowDialog();
        }

        private void purchaseListBtn(object sender, RoutedEventArgs e)
        {
            var screen = new PurchaseListScreen();
            screen.Owner = this;
            screen.ShowDialog();
        }
    }
}