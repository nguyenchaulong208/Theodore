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
    /// Interaction logic for EditCategoryScreen.xaml
    /// </summary>
    public partial class EditCategoryScreen : Window
    {  
        #region Tham chieu den CategoryScreen de lay du lieu tu ListView
        private readonly Category selectedCategory;
        public EditCategoryScreen(Category category)
        {
            InitializeComponent();
            selectedCategory = category;
            //Gan du lieu tu ListView vao cac TextBox
            txtCategoryID_edit.Text = selectedCategory.CategoryId.ToString();
            txtCategoryName_edit.Text = selectedCategory.CategoryName;
            txtDescription_edit.Text = selectedCategory.CategoryDescription;
        }
        #endregion
        private void btnSaveCategory_Click(object sender, RoutedEventArgs e)
        {

            try
            {
               
                
               
                // Gán thông tin đã chỉnh sửa vào object selectedCategory.
                selectedCategory.CategoryName = txtCategoryName_edit.Text;
                selectedCategory.CategoryDescription = txtDescription_edit.Text;
                selectedCategory.CategoryId = int.Parse(txtCategoryID_edit.Text);

                // Ghi thông tin đã chỉnh sửa vào cơ sở dữ liệu.
                UpdateCategoryInDatabase(selectedCategory);

                // Đóng màn hình chỉnh sửa.
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void btnCancelEditCategory_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #region Cap nhat Category vao Database
        private void UpdateCategoryInDatabase(Category category)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = """
                UPDATE category 
                SET category_name = @category_name, 
                    category_des = @category_description 
                WHERE category_id = @category_id
            """;

                    using (var cmd = new SqlCommand(query, connection))
                    {
                       
                        cmd.Parameters.AddWithValue("@category_id", category.CategoryId);
                        cmd.Parameters.AddWithValue("@category_name", category.CategoryName);
                        cmd.Parameters.AddWithValue("@category_description", category.CategoryDescription);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Danh mục đã được cập nhật thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                            
                            //Gọi hàm refreshBtn từ CategoryScreen để cập nhật lại dữ liệu trên ListView
                            CategoryScreen categoryScreen = (CategoryScreen)this.Owner;
                            categoryScreen.refreshBtn(null,null);
                        }
                        else
                        {
                            MessageBox.Show("Không có dòng nào được cập nhật. Vui lòng kiểm tra dữ liệu.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

    }
}
