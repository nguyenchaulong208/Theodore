using Microsoft.Data.SqlClient;
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
    /// Interaction logic for ProductsListScreen.xaml
    /// </summary>
    public partial class ProductsListScreen : Window
    {
        public ProductsListScreen()
        {
            InitializeComponent();
        }

        public void refreshProductBtn(object sender, RoutedEventArgs e)
        {

            MS _loadProducts = new MS();
            _loadProducts.LoadProducts(this);
        }

        private void delProductBtn(object sender, RoutedEventArgs e)
        {
            if (productsList.SelectedItem is Product selectedProduct)
            {

                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    // Tiến hành xóa trong cơ sở dữ liệu
                    using (SqlConnection connect = DatabaseConnection.GetConnection())
                    {
                        try
                        {
                            connect.Open();
                            string query = "DELETE FROM products WHERE products_code = @product_code";
                            SqlCommand cmd = new SqlCommand(query, connect);
                            cmd.Parameters.AddWithValue("@product_code", selectedProduct.ProductCode);

                            cmd.ExecuteNonQuery();

                            refreshProductBtn(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một danh mục để xóa.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void editProductBtn(object sender, RoutedEventArgs e)
        {
            if (productsList.SelectedItem is Product selectedProduct)
            {

                var screen = new EditProductScreen(selectedProduct);
                screen.Owner = this;
                screen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một danh mục để chỉnh sửa.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    

        private void addProductBtn(object sender, RoutedEventArgs e)
        {
            var screen = new AddProductScreen();
            screen.ShowDialog();
        }
    }
}
