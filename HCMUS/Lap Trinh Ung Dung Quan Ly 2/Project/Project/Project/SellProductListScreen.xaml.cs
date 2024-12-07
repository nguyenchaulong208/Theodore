using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for SellProductListScreen.xaml
    /// </summary>
    public partial class SellProductListScreen : Window
    {
        public SellProductListScreen()
        {
            InitializeComponent();
        }

        private void addSellPr_Click(object sender, RoutedEventArgs e)
        {
            var sellScreen = new SellProductSceen();
            sellScreen.ShowDialog();
        }

        private void delSellPr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editSellPr_Click(object sender, RoutedEventArgs e)
        {
            // Lấy mục được chọn từ DataGrid
            if(productSellList.SelectedItem is SellItemView selectedSellItem)
            {
                int selectedSellId = selectedSellItem.SellId_view;
                // Truy vấn dữ liệu SellItem từ database
               var editScreen = new EditSellProductScreen(selectedSellId);
                editScreen.ShowDialog();


            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để chỉnh sửa", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
            //if (selectedSellItem == null)
            //{
            //    MessageBox.Show("Vui lòng chọn một mục để chỉnh sửa.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            //    return;
            //}
            


            // Mở màn hình chỉnh sửa
            //var editScreen = new EditSellProductScreen(selectedSellItem);
            //if (editScreen.ShowDialog() == true)
            //{
            //    // Nếu chỉnh sửa thành công, làm mới lại danh sách
            //    productSellList.Items.Refresh();
            //}
        }


        private void refreshSellPr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExportTable_Click(object sender, RoutedEventArgs e)
        {
            MS exportExcel = new MS();
            // Chuyển DataGrid thành DataTable
            DataTable table = exportExcel.ConvertDataGridToDataTable(productSellList); // Hoặc lấy dữ liệu từ SQL

          
           

            // Gọi hàm xuất Excel
            exportExcel.ExportToExcel(table);


        }
    }
}
