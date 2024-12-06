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
    /// Interaction logic for EditProductScreen.xaml
    /// </summary>
    /// 
    

    public partial class EditProductScreen : Window
    {
        //Tham chieu den ProductScreen de lay du lieu tu ListView
        private readonly Product selectedProduct;
        public EditProductScreen(Product product)
        {
            InitializeComponent();
            selectedProduct = product;
            //Gan du lieu tu ListView vao cac TextBox
            editIdTextbox.Text = selectedProduct.ProductCode.ToString();
            editProductTextbox.Text = selectedProduct.ProductName;
            editCategoryTextBox.Text = selectedProduct.CategoryProductId.ToString();
            editDescriptionTextBox.Text = selectedProduct.ProductDescription;
            editImageTextBox.Text = selectedProduct.ProductImage;
            productYearTextBox.Text = selectedProduct.ProductYear;


        }
       
        private void saveEditProductBtn_Click(object sender, RoutedEventArgs e)
        {
          try
            {
                // Gán thông tin đã chỉnh sửa vào object selectedProduct.
                string oldProductCode = selectedProduct.ProductCode.ToString();
                selectedProduct.ProductName = editProductTextbox.Text;
                selectedProduct.CategoryProductId = int.Parse(editCategoryTextBox.Text);
                selectedProduct.ProductDescription = editDescriptionTextBox.Text;
                selectedProduct.ProductImage = editImageTextBox.Text;
                selectedProduct.ProductYear = productYearTextBox.Text;
                selectedProduct.ProductCode = int.Parse(editIdTextbox.Text);
                MS updateProduct = new MS();
                updateProduct.UpdateProductInDatabase(selectedProduct, oldProductCode);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void cancleEditProduct_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
