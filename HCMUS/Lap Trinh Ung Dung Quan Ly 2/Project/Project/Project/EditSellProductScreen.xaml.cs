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
    /// Interaction logic for EditSellProductScreen.xaml
    /// </summary>
    public partial class EditSellProductScreen : Window
    {
        private readonly int selectedSellItem;
        public EditSellProductScreen(int _sellItem)
        {
            InitializeComponent();
            selectedSellItem = _sellItem;
            MS getSellItems = new MS();

            // Gán dữ liệu từ SellItem vào các control
            InvoiceDatePicker.Text = getSellItems.GetDatabase("order_invoice_date", "order_item", "order_number", selectedSellItem);
            editSellId.Text = getSellItems.GetDatabase("order_number", "order_item", "order_number", selectedSellItem);
            List<SellItem> sellItems = getSellItems.LoadsellProduct(selectedSellItem);
            if (sellItems != null && sellItems.Count > 0)
            {
                editProductSell.ItemsSource = sellItems;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào trong phiếu xuất.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void SaveEditSell_Click(object sender, RoutedEventArgs e)
        {
            string oldSellId = editSellId.Text;
            string newSellId = editSellId.Text; // Cập nhật nếu cần thiết
            string invoiceDate = InvoiceDatePicker.Text;

            // Lấy dữ liệu từ DataGrid
            List<SellItem> sellItems = editProductSell.ItemsSource as List<SellItem>;

            MS saveData = new MS();
            saveData.UpdateSellProduct(oldSellId, newSellId, invoiceDate, sellItems);

            this.Close();
        }


        private void CancelEditSell_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void searchProduct(object sender, KeyEventArgs e)
        {

        }
    }
}
