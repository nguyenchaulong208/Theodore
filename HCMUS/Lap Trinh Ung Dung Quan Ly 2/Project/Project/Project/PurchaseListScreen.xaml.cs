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
    /// Interaction logic for PurchaseListScreen.xaml
    /// </summary>
    public partial class PurchaseListScreen : Window
    {
        public PurchaseListScreen()
        {
            InitializeComponent();
        }

        private void addPurchaseBtn(object sender, RoutedEventArgs e)
        {
            var screen = new PurchaseScreen();
            screen.ShowDialog();
        }

        private void editPurchaseBtn(object sender, RoutedEventArgs e)
        {

            if (purchaseList.SelectedItem is PurchaseItemView selectedPurchaseView)
            {
                int selectedPurchaseId = selectedPurchaseView.PurchaseId_view;
               
                // Truy vấn dữ liệu PurchaseItem từ database
                MS getPurchaseItems= new MS();
                PurchaseItem selectedPurchase = getPurchaseItems.GetPurchaseItem(selectedPurchaseId);
                //Gán thông tin đã truy vấn vào object object PurchaseItem
                int _purchaseId = selectedPurchase.PurchaseId;
                int _productId = selectedPurchase.ProductId;
                int _quantity = selectedPurchase.Quantity;
                int _price = selectedPurchase.Price;
                int _total = selectedPurchase.Total;
                string _invoiceDate = selectedPurchase.InvoiceDate;
                string _productDate = selectedPurchase.ProductDate;
                int _brand = selectedPurchase.Brand;
                string _description = selectedPurchase.Description;
                //Gán thông tin đã truy vấn vào EditPurchaseScreen
                EditPurchaseScreen editPurchaseScreen = new EditPurchaseScreen(_purchaseId, _productId, _quantity, _price, _total, _invoiceDate, _productDate, _brand, _description);
                editPurchaseScreen.ShowDialog();


               


            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để chỉnh sửa", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }




        private void delPurchaseBtn(object sender, RoutedEventArgs e)
        {

        }
    }
}
