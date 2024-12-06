using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Project
{
    public class MS
    {

        public void LoadCategory(CategoryScreen categoryScreen)
        {
            // Binding data to ListView
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    List<Category> categories = new List<Category>();
                    connect.Open();
                    // Truy vấn SQL
                    string query = "SELECT * FROM category";
                    SqlCommand cmd = new SqlCommand(query, connect);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Category category = new Category();
                        category.CategoryId = reader.GetInt32(0);
                        category.CategoryName = reader.GetString(1);
                        category.CategoryDescription = reader.GetString(2);
                        categories.Add(category);
                    }

                    // Gán dữ liệu vào ListView của CategoryScreen
                    categoryScreen.categoryList.ItemsSource = categories;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public void DuplicateProduct(int productCode)
        {
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = "SELECT * FROM products WHERE products_code = @product_code";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@products_code", productCode);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public void AddProduct(int productCode, int categoryProduct, string productName, string productDescription, string productImage, DatePicker productYear, int productPrice, int productQuantity)
        {
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = "INSERT INTO products(products_code, category_id, products_name, products_des, products_image, products_year, product_price, products_quantity) VALUES(@products_code, @category_id, @products_name, @products_description, @products_image, @products_year, @products_price, @products_quantity)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@products_code", productCode);
                    cmd.Parameters.AddWithValue("@category_id", int.Parse(categoryProduct.ToString()));
                    cmd.Parameters.AddWithValue("@products_name", productName);
                    cmd.Parameters.AddWithValue("@producst_des", productDescription);
                    cmd.Parameters.AddWithValue("@products_image", productImage);
                    cmd.Parameters.AddWithValue("@products_year", productYear.SelectedDate);
                    cmd.Parameters.AddWithValue("@products_price", productPrice);
                    cmd.Parameters.AddWithValue("@products_quantity", productQuantity);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
