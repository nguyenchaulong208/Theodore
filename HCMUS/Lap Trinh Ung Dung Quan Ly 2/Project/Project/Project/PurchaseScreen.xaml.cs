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
    /// Interaction logic for PurchaseScreen.xaml
    /// </summary>
    public partial class PurchaseScreen : Window
    {
        public PurchaseScreen()
        {
            InitializeComponent();
        }

        private void canclePurBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void savePurcBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
