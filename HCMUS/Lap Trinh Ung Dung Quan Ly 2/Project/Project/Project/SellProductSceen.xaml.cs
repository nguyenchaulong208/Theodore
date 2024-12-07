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
    /// Interaction logic for SellProductSceen.xaml
    /// </summary>
    public partial class SellProductSceen : Window
    {
        private List<SellItem> items = new List<SellItem>();
        public SellProductSceen()
        {
            InitializeComponent();
            InitializeBrandComboBox();
            ProductDataGrid.ItemsSource = items;

        }
        private void InitializeBrandComboBox()
        {
            //Lấy dữ liệu từ category trong database
            MS getCategory = new MS();
            //Lấy dữ liệu từ database
            List<Category> categories = GetCategories();
            //Thêm dữ liệu vào combobox
           




        }
        public List<Category> GetCategories()
        {
            List<Category> categoriesComboBox = new List<Category>();
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = "SELECT * FROM category";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int category_id = reader.GetInt32(0);
                        string category_name = reader.GetString(1);
                        string category_description = reader.GetString(2);
                        //Thêm dữ liệu vào list
                        categoriesComboBox.Add(new Category { CategoryId = category_id, CategoryName = category_name, CategoryDescription = category_description });


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            return categoriesComboBox;
        }

        private void SaveSell_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrWhiteSpace(InvoiceDatePicker.Text))
                {
                    MessageBox.Show("Vui lòng nhập ngày xuất!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }


                // Lấy thông tin thương hiệu và ngày hóa đơn
               
                string invoiceDate = InvoiceDatePicker.Text;
                int orderID = int.Parse(orderId.Text);

                // Lưu từng sản phẩm
                foreach (var item in items)
                {
                    MS saveSellItem = new MS();
                    saveSellItem.SaveSellItemToDatabase(item, invoiceDate, orderID);
                }

                MessageBox.Show("Lưu phiếu xuất thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close(); // Đóng cửa sổ sau khi lưu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        




        private void CancelSell_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Đóng màn hình
        }

        private void searchProduct(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Tab)
            {
                // Lấy TextBox hiện tại trong DataGrid
                if (sender is TextBox textBox)
                {
                    int productCode;
                    if (int.TryParse(textBox.Text, out productCode))
                    {
                        MS getProduct = new MS();
                        // Gọi phương thức tìm kiếm tên sản phẩm
                        string productName = getProduct.GetDatabase("products_name", "products", "products_code", productCode);
                        //MessageBox.Show(productName);

                        // Kiểm tra xem có dòng nào được chọn không
                        var currentRow = ProductDataGrid.SelectedItem as SellItem;
                        currentRow.SellProductName = productName;

                        //MessageBox.Show(string.IsNullOrEmpty(currentRow.SellProductName) ? "Không có giá trị" : currentRow.SellProductName, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        // Nếu mã sản phẩm không hợp lệ (không phải số)
                        MessageBox.Show("Mã sản phẩm không hợp lệ.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }

        
    }
}
