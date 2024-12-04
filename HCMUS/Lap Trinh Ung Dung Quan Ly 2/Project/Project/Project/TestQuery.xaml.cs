using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Project
{
    /// <summary>
    /// Interaction logic for TestQuery.xaml
    /// </summary>
    public partial class TestQuery : Window
    {
        public TestQuery()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string constr = @"Data Source=DESKTOP-V28N1KK\SQLEXPRESS;Initial Catalog=LTUDQL2-22880089;Integrated Security=True;TrustServerCertificate=True";


            List<Product> products = new List<Product>();

            try
            {
                //using (SqlConnection connectServer = new SqlConnection(constr))
                //{
                //    connectServer.Open();
                //    string sql = "SELECT MaHang, TenHang, MoTa FROM SanPham";
                //    SqlCommand cmd = new SqlCommand(sql, connectServer);

                //    using (SqlDataReader reader = cmd.ExecuteReader())
                //    {
                //         // Thứ tự của sản phẩm
                //        while (reader.Read())
                //        {
                //            Product product = new Product
                //            {
                //                ProductCode = reader["MaHang"].ToString(),
                //                ProductName = reader["TenHang"].ToString(),
                //                Description = reader["MoTa"].ToString(),
                             
                //            };
                //            products.Add(product);
                //        }
                //    }
                //}

                // Gán dữ liệu vào ListView
                ProductListView.ItemsSource = products;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi trong quá trình kết nối hoặc truy vấn
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }

}
