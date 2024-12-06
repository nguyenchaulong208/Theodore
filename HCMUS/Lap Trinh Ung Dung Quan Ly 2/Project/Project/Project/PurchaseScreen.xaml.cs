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
            try
            {
                int id = int.Parse(idTextboxPur.Text);
                int quantity = int.Parse(quantityTextboxPur.Text);
                int price = int.Parse(unitPriceTextboxPur.Text);
                int total = int.Parse(totalAmountTextboxPur.Text);
                int invoice = int.Parse(invNumTexboxPur.Text);
                string invoiceDate = invDateTextboxPur.Text;
                string productDate = productYearPur.Text;
                string description = descriptionTextboxPur.Text;
                int brand = int.Parse(categoryProductPur.Text);

                MS purchaseItem = new MS();
                //purchaseItem.CheckCategory(brand);
                //purchaseItem.DuplicateProduct(id);
                purchaseItem.AddPurchaseItem(id, quantity, price, total, invoice, invoiceDate, productDate, brand, description);
                this.Close();

                //MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void brandValue(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(categoryProductPur.Text, out int brand))
            {
                MS getData = new MS();
                // Gọi hàm để lấy giá trị từ cơ sở dữ liệu
                string brandName = getData.GetDatabase("category_name","category","category_id",brand);

                // Nếu tìm thấy giá trị, gán vào brandProduct
                if (!string.IsNullOrEmpty(brandName))
                {
                    brandProduct.Text = brandName;
                }
                else
                {
                    // Nếu không tìm thấy, thông báo lỗi hoặc để trống
                    brandProduct.Text = string.Empty;
                }
            }
            else
            {
                // Nếu không phải là số hợp lệ, có thể hiển thị thông báo lỗi
                MessageBox.Show("Mã danh mục không hợp lệ.");
            }
        }

        private void nameChanged(object sender, TextChangedEventArgs e)
        {
            MS getProductName = new MS();
            if (int.TryParse(idTextboxPur.Text, out int id))
            {
                
                // Gọi hàm để lấy giá trị từ cơ sở dữ liệu
                string productName = getProductName.GetDatabase("products_name", "products", "products_code", id);

                // Nếu tìm thấy giá trị, gán vào brandProduct
                if (!string.IsNullOrEmpty(productName))
                {
                    productTextboxPur.Text = productName;
                }
                else
                {
                    // Nếu không tìm thấy, thông báo lỗi hoặc để trống
                    productTextboxPur.Text = string.Empty;
                }
            }
            else
            {
                // Nếu không phải là số hợp lệ, có thể hiển thị thông báo lỗi
                MessageBox.Show("Mã danh mục không hợp lệ.");
            }
        }

        //private string GetBrandFromDatabase(int categoryId)
        //{
        //    string brand = string.Empty;
        //    using (SqlConnection connect = DatabaseConnection.GetConnection())
        //    {
        //        try
        //        {
        //            connect.Open();
        //            string query = "SELECT category_name FROM category WHERE category_id = @category_id";
        //            SqlCommand cmd = new SqlCommand(query, connect);
        //            cmd.Parameters.AddWithValue("@category_id", categoryId);
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            if (reader.Read())
        //            {
        //                brand = reader.GetString(0); // Lấy giá trị thương hiệu từ cột đầu tiên
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message);
        //        }
        //    }
        //    return brand;
        //}




    }
}
