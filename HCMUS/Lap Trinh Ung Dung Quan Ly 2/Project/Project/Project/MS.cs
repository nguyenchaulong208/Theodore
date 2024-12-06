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
                    cmd.Parameters.AddWithValue("@product_code", productCode);
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
        public void AddProduct(int productCode, int categoryProduct, string productName, string productDescription, string productImage, string productYer)
        {
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = "INSERT INTO products(products_code, category_id, products_name, products_des, products_image, products_year)" +
                        " VALUES(@product_code, @categoryProduct_id, @product_name, @product_description, @product_image, @product_year)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@product_code", productCode);
                    cmd.Parameters.AddWithValue("@categoryProduct_id", int.Parse(categoryProduct.ToString()));
                    cmd.Parameters.AddWithValue("@product_name", productName);
                    cmd.Parameters.AddWithValue("product_description", productDescription);
                    cmd.Parameters.AddWithValue("@product_image", productImage);
                    cmd.Parameters.AddWithValue("@product_year", productYer);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public void CheckCategory(int categoryProduct)
        {
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = "SELECT * FROM category WHERE category_id = @category_id";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@category_id", categoryProduct);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Danh mục không tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public void LoadProducts(ProductsListScreen productsListScreen)
        {
            // Binding data to ListView
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    List<Product> products = new List<Product>();
                    connect.Open();
                    // Truy vấn SQL
                    string query = "SELECT * FROM products";
                    SqlCommand cmd = new SqlCommand(query, connect);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.ProductCode = reader.GetInt32(0);
                        product.CategoryProductId = reader.GetInt32(1);
                        product.ProductName = reader.GetString(2);
                        product.ProductDescription = reader.GetString(3);
                        product.ProductImage = reader.GetString(4);
                        product.ProductYear = reader.GetString(5);
                        products.Add(product);
                    }

                    // Gán dữ liệu vào ListView của ProductsListScreen
                    productsListScreen.productsList.ItemsSource = products;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public void UpdateProductInDatabase(Product product, string oldProductCode)
        {
            string productCodeOld = oldProductCode;

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"
                UPDATE products 
                SET
                    products_code = @product_code,
                    products_name = @product_name, 
                    category_id = @category_id,
                    products_des = @product_description,
                    products_image = @product_image,
                    products_year = @product_year
                WHERE products_code = @product_codeOld";
           

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@product_code", product.ProductCode);
                        cmd.Parameters.AddWithValue("@product_name", product.ProductName);
                        cmd.Parameters.AddWithValue("@category_id", product.CategoryProductId);
                        cmd.Parameters.AddWithValue("@product_description", product.ProductDescription);
                        cmd.Parameters.AddWithValue("@product_image", product.ProductImage);
                        cmd.Parameters.AddWithValue("@product_year", product.ProductYear);
                        cmd.Parameters.AddWithValue("@product_codeOld", productCodeOld);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sản phẩm đã được cập nhật thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có dòng nào được cập nhật. Vui lòng kiểm tra dữ liệu.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        //Gọi hàm refreshProductBtn từ ProductsListScreen để cập nhật lại dữ liệu trên ListView


                        LoadProducts(new ProductsListScreen());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



    }
}
