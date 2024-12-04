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
    /// Interaction logic for CategoryScreen.xaml
    /// </summary>
    public partial class CategoryScreen : Window
    {
        public CategoryScreen()
        {
            InitializeComponent();
        }

        //connect to database
      
        private void addCategoryBtn(object sender, RoutedEventArgs e)
        {
            var screen = new AddCategoryScreen();
            screen.Owner = this;
            screen.ShowDialog();
        }

        private void delCategoryBtn(object sender, RoutedEventArgs e)
        {

        }

        private void editCategoryBtn(object sender, RoutedEventArgs e)
        {

        }

        private void refreshBtn(object sender, RoutedEventArgs e)
        {

            //bing ding data to listview
            using (SqlConnection connect = DatabaseConnection.GetConnection())
             {
                try
                {
                    List<Category> categories = new List<Category>();
                    connect.Open();

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

                    categoryList.ItemsSource = categories;
                }

                catch (Exception ex)
                {

                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }

        }
    }
}
