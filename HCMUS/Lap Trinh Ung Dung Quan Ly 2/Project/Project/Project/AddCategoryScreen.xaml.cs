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
    /// Interaction logic for AddCategoryScreen.xaml
    /// </summary>
    public partial class AddCategoryScreen : Window
    {
        public AddCategoryScreen()
        {
            InitializeComponent();
        }

        private void addCategoryBtn_Click(object sender, RoutedEventArgs e)
        {
            //Gan gia tri tu textbox vao bien
            int category_id = int.Parse(txtCategoryID.Text);
            string category_name = txtCategoryName.Text;
            string category_description = txtDescription.Text;
            //Kiem tra xem ma danh muc da ton tai chua
            int checkID = CheckDuplicate(category_id);
            if ( checkID == category_id)
            {
                MessageBox.Show("Category already exists.");
            }
            else
            {
                AddCategoryToDatabase(category_id, category_name, category_description);
            }
            CategoryScreen _refeshBtn = new CategoryScreen();
            _refeshBtn.refreshBtn(sender, e);


        }
        #region Them danh muc hang hoa vao database
        private void AddCategoryToDatabase(int categoryId, string categoryName, string categoryDescription)
        {
            try
            {
                var connection = DatabaseConnection.GetConnection();
                
                    connection.Open();
                    string query = "INSERT INTO category (category_id, category_name, category_des) VALUES (@category_id, @category_name, @category_description)";
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@category_id", categoryId);
                        cmd.Parameters.AddWithValue("@category_name", categoryName);
                        cmd.Parameters.AddWithValue("@category_description", categoryDescription);
                        int rowsEffected = cmd.ExecuteNonQuery();

                        if (rowsEffected > 0)
                        {
                        //Gọi hàm refreshBtn từ CategoryScreen để cập nhật lại dữ liệu trên ListView
                        CategoryScreen categoryScreen = (CategoryScreen)this.Owner;
                        categoryScreen.refreshBtn(null, null);

                        MessageBox.Show("Category added successfully.");
                                this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Category not added.");
                        }
                        
                    }
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            
        }
        #endregion
        #region Kiem tra ma danh muc hang hoa trong database
        private int CheckDuplicate(int categoryId)
        {
            int result = 0;
            var connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "SELECT * FROM category WHERE category_id = @category_id";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@category_id", categoryId);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                       result = reader.GetInt32(0);
                    }
                }
            }
            return result;
        }
        #endregion
        private void cancelCategoryBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
