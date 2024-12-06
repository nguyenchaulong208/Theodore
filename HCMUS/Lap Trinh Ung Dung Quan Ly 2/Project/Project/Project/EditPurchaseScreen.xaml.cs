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
    /// Interaction logic for EditPurchaseScreen.xaml
    /// </summary>
    public partial class EditPurchaseScreen : Window
    {
        private readonly int _purchaseID;
        
        public EditPurchaseScreen(int purchaseItem, int productId, int quantity, int price, int total, string invoiceDate, string productDate, int brand, string description)
        {
            InitializeComponent();
            _purchaseID = purchaseItem;
            editIdPur.Text = productId.ToString();
            editQuantityPur.Text = quantity.ToString();
            editPricePur.Text = price.ToString();
            editTotalPur.Text = total.ToString();
            editInvNumPur.Text = purchaseItem.ToString();
            editInvDatePur.Text = invoiceDate;
            editDesPur.Text = description;
            editCatePur.Text = brand.ToString();
            editProductYearPur.Text = productDate;
        }
        

        private void editPurcBtn_Click(object sender, RoutedEventArgs e)
        {
            // Lấy thông tin từ các textbox
            PurchaseItem _purchaseItem = new PurchaseItem();
            int oldPurchaseId = _purchaseID;
            _purchaseItem.PurchaseId = int.Parse(editInvNumPur.Text);
                
            _purchaseItem.ProductId = int.Parse(editIdPur.Text);
            _purchaseItem.Quantity = int.Parse(editQuantityPur.Text);
            _purchaseItem.Price = int.Parse(editPricePur.Text);
            _purchaseItem.Total = int.Parse(editTotalPur.Text);
            _purchaseItem.InvoiceDate = editInvDatePur.Text;
            _purchaseItem.ProductDate = editProductYearPur.Text;
            _purchaseItem.Brand = int.Parse(editCatePur.Text);
            _purchaseItem.Description = editDesPur.Text;


            //Ghi thông tin vào database
            MS editPurchase = new MS();
            editPurchase.UpdatePurchaseInDatabase(_purchaseItem, oldPurchaseId);




        }

        private void cancleEditPurBtn(object sender, RoutedEventArgs e)
        {

        }

        private void editBrandValue(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(editCatePur.Text, out int brand))
            {
                MS getData = new MS();
                // Gọi hàm để lấy giá trị từ cơ sở dữ liệu
                string brandName = getData.GetDatabase("category_name", "category", "category_id", brand);

                // Nếu tìm thấy giá trị, gán vào brandProduct
                if (!string.IsNullOrEmpty(brandName))
                {
                    editBrandPur.Text = brandName;
                }
                else
                {
                    // Nếu không tìm thấy, thông báo lỗi hoặc để trống
                    editBrandPur.Text = string.Empty;
                }
            }
            else
            {
                // Nếu không phải là số hợp lệ, có thể hiển thị thông báo lỗi
                MessageBox.Show("Mã danh mục không hợp lệ.");
            }
        }

        private void editNameValue(object sender, TextChangedEventArgs e)
        {
            MS getProductName = new MS();
            if (int.TryParse(editIdPur.Text, out int id))
            {

                // Gọi hàm để lấy giá trị từ cơ sở dữ liệu
                string productName = getProductName.GetDatabase("products_name", "products", "products_code", id);

                // Nếu tìm thấy giá trị, gán vào brandProduct
                if (!string.IsNullOrEmpty(productName))
                {
                    editProductPur.Text = productName;
                }
                else
                {
                    // Nếu không tìm thấy, thông báo lỗi hoặc để trống
                    editProductPur.Text = string.Empty;
                }
            }
            else
            {
                // Nếu không phải là số hợp lệ, có thể hiển thị thông báo lỗi
                MessageBox.Show("Mã danh mục không hợp lệ.");
            }
        }
    }
}
