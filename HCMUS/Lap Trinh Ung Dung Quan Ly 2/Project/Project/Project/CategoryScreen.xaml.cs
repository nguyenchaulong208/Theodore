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
            if (categoryList.SelectedItem is Category selectedCategory)
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
                            string query = "DELETE FROM category WHERE category_id = @category_id";
                            SqlCommand cmd = new SqlCommand(query, connect);
                            cmd.Parameters.AddWithValue("@category_id", selectedCategory.CategoryId);

                            cmd.ExecuteNonQuery();

                            refreshBtn(sender, e);
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

        private void editCategoryBtn(object sender, RoutedEventArgs e)
        {
            //truyền dữ liệu đã chọn từ listview qua màn hình chỉnh sửa để hiển thị nội dung chỉnh sửa
            if (categoryList.SelectedItem is Category selectedCategory)
            {
               
                var screen = new EditCategoryScreen(selectedCategory);
                screen.Owner = this;
                screen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một danh mục để chỉnh sửa.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void refreshBtn(object sender, RoutedEventArgs e)
        {
            //Load database từ hàm LoadCategory trong LoadDatabase.cs
            MS loadDatabase = new MS();
            loadDatabase.LoadCategory(this);


        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string idFilter = searchCategoryId.Text.ToLower();
            string nameFilter = searchCategoryName.Text.ToLower();
            string descFilter = searchCategoryDescription.Text.ToLower();
            List<Category> filterCategories = new List<Category>();
            //Thêm danh sách vào filterCategories
            foreach (Category category in categoryList.Items)
            {
                filterCategories.Add(category);
            }
            // Lọc danh sách
            var filteredCategories = filterCategories.Where(category =>
                category.CategoryId.ToString().ToLower().Contains(idFilter) &&
                category.CategoryName.ToLower().Contains(nameFilter) &&
                category.CategoryDescription.ToLower().Contains(descFilter)
            );
            // Gán danh sách đã lọc vào ListView
            categoryList.ItemsSource = filteredCategories;
        }
    }
}
