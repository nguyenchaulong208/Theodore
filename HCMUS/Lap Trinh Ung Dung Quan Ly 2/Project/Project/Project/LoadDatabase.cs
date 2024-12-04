using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project
{
    public class LoadDatabase
    {
        // Thêm tham số CategoryScreen để truy cập vào ListView của CategoryScreen
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
    }
}
