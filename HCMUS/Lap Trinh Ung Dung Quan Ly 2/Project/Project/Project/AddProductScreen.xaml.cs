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
    /// Interaction logic for AddProductScreen.xaml
    /// </summary>
    public partial class AddProductScreen : Window
    {
        public AddProductScreen()
        {
            InitializeComponent();
        }

        private void cancleProduct_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void saveProductBtn_Click(object sender, RoutedEventArgs e)
        {
            if (idTextbox.Text == "" || productTextbox.Text == "" || categoryTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                int productCode = int.Parse(idTextbox.Text);
                string productName = productTextbox.Text;

                string productDescription = descriptionTextBox.Text;
                string productImage = imageTextBox.Text;
                int categoryProduct = int.Parse(categoryTextBox.Text);
                string productYear = productYearTextBox.Text;

                MS ms = new MS();
                ms.DuplicateProduct(productCode);
                ms.CheckCategory(categoryProduct);
                ms.AddProduct(productCode, categoryProduct, productName, productDescription, productImage, productYear);
            }
            this.Close();

        }
    }
}
