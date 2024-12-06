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
            if(idTextboxPur.Text == "" || productTextboxPur.Text == "" || unitPriceTextboxPur.Text == "" || quantityTextboxPur.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                int productCode = int.Parse(idTextboxPur.Text);
                string productName = productTextboxPur.Text;
                int productPrice = int.Parse(unitPriceTextboxPur.Text);
                int productQuantity = int.Parse(unitPriceTextboxPur.Text);
                string productDescription = descriptionTextboxPur.Text;
                string productImage = "Test";
                DatePicker productYear = productYearPur;
                int categoryProduct = int.Parse(categoryProductPur.Text);

                MS ms = new MS();
                ms.DuplicateProduct(productCode);
                ms.AddProduct(productCode, categoryProduct, productName, productDescription, productImage, productYear, productPrice, productQuantity);
            }
        }
    }
}
