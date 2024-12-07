using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Project
{
    public class MS
    {

        public void LoadCategory(CategoryScreen categoryScreen)
        {
            // Binding data to ListView
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    List<Category> categories = new List<Category>();
                    connect.Open();
                    // Truy vấn SQL
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

                    // Gán dữ liệu vào ListView của CategoryScreen
                    categoryScreen.categoryList.ItemsSource = categories;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public void DuplicateProduct(int productCode)
        {
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = "SELECT * FROM products WHERE products_code = @product_code";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@product_code", productCode);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public void AddProduct(int productCode, int categoryProduct, string productName, string productDescription, string productImage, string productUnit)
        {
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = "INSERT INTO products(products_code, category_id, products_name, products_des, products_image,  products_unit)" +
                        " VALUES(@product_code, @category_id, @product_name, @product_description, @product_image, @product_unit)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@product_code", productCode);
                    cmd.Parameters.AddWithValue("@category_id", categoryProduct);
                    cmd.Parameters.AddWithValue("@product_name", productName);
                    cmd.Parameters.AddWithValue("@product_description", productDescription);
                    cmd.Parameters.AddWithValue("@product_image", productImage);
                    cmd.Parameters.AddWithValue("@product_unit", productUnit);
                    //MessageBox.Show($"Product Code: {productCode}, Category ID: {categoryProduct}, Product Name: {productName}, Product Unit: {productUnit}");
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public void CheckCategory(int categoryProduct)
        {
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = "SELECT * FROM category WHERE category_id = @category_id";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@category_id", categoryProduct);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Danh mục không tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public string GetDatabase(string getValue, string table, string keyword, int getValueWithID)
        {
            string value = string.Empty;
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = $"SELECT {getValue} FROM {table} WHERE {keyword} = @{keyword}";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    // Chuyển getValue sang kiểu int thay vì string
                    cmd.Parameters.AddWithValue($"@{keyword}", getValueWithID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm với mã code: " + getValueWithID, "Không tìm thấy", MessageBoxButton.OK, MessageBoxImage.Warning);
                        // Nếu không tìm thấy giá trị, hiển thị màn hình để thêm danh mục
                        if (table == "products")
                        {
                            AddProductScreen addProductScreen = new AddProductScreen();
                            addProductScreen.ShowDialog();
                        }
                        if (table == "category")
                        {
                            AddCategoryScreen addCategoryScreen = new AddCategoryScreen();
                            addCategoryScreen.ShowDialog();
                        }
                    }
                    else
                    {
                        reader.Read();
                        if (!reader.IsDBNull(0))
                        {
                            // Nếu cột là string
                            if (reader.GetFieldType(0) == typeof(string))
                            {
                                value = reader.GetString(0);
                            }
                            // Nếu cột là int
                            else if (reader.GetFieldType(0) == typeof(int))
                            {
                                value = reader.GetInt32(0).ToString();
                            }
                            // Nếu cột là kiểu khác
                            else
                            {
                                value = reader[0].ToString();
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Xử lý các lỗi liên quan đến cơ sở dữ liệu
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + sqlEx.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (Exception ex)
                {
                    // Xử lý các lỗi khác
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            return value;
        }

        public void LoadProducts(ProductsListScreen productsListScreen)
        {
            // Binding data to ListView
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    List<Product> products = new List<Product>();
                    connect.Open();
                    // Truy vấn SQL
                    string query = "SELECT * FROM products";
                    SqlCommand cmd = new SqlCommand(query, connect);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.ProductCode = reader.GetInt32(0);
                        product.CategoryProductId = reader.GetInt32(1);
                        product.ProductName = reader.GetString(2);
                        product.ProductImage = reader.GetString(4);
                        product.ProductDescription = reader.GetString(3);
                        product.ProductUnit = reader.GetString(5);
                        products.Add(product);
                    }

                    // Gán dữ liệu vào ListView của ProductsListScreen
                    productsListScreen.productsList.ItemsSource = products;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public void UpdateProductInDatabase(Product product, string oldProductCode)
        {
            string productCodeOld = oldProductCode;

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = """
                UPDATE products 
                SET
                    products_code = @product_code,
                    products_name = @product_name, 
                    category_id = @category_id,
                    products_des = @product_description,
                    products_image = @product_image,
                    products_unit = @product_unit
                WHERE products_code = @product_codeOld
                """;


                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@product_code", product.ProductCode);
                        cmd.Parameters.AddWithValue("@product_name", product.ProductName);
                        cmd.Parameters.AddWithValue("@category_id", product.CategoryProductId);
                        cmd.Parameters.AddWithValue("@product_description", product.ProductDescription);
                        cmd.Parameters.AddWithValue("@product_image", product.ProductImage);

                        cmd.Parameters.AddWithValue("@product_unit", product.ProductUnit);
                        cmd.Parameters.AddWithValue("@product_codeOld", productCodeOld);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sản phẩm đã được cập nhật thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có dòng nào được cập nhật. Vui lòng kiểm tra dữ liệu.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        //Gọi hàm refreshProductBtn từ ProductsListScreen để cập nhật lại dữ liệu trên ListView


                        LoadProducts(new ProductsListScreen());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void AddPurchaseItem(int id, int quantity, int price, int total, int invoice, string invoiceDate, string productDate, int brand, string description)
        {
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    // Kiểm tra kết nối cơ sở dữ liệu
                    if (connect == null)
                    {
                        MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                        return;
                    }

                    connect.Open();

                    // Kiểm tra câu lệnh SQL
                    string query = "INSERT INTO purchase_item(purchase_id, purchase_quantity, purchase_price, purchase_total_price, purchase_product_id, purchase_invoice_date, purchase_brand, purchase_description, purchase_product_date) " +
                                   "VALUES(@purchase_id, @purchase_quantity, @purchase_price, @purchase_total_price, @purchase_product_id, @purchase_invoice_date, @purchase_brand, @purchase_description, @purchase_product_date)";

                    SqlCommand cmd = new SqlCommand(query, connect);

                    // Thêm tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@purchase_id", invoice);
                    cmd.Parameters.AddWithValue("@purchase_quantity", quantity);
                    cmd.Parameters.AddWithValue("@purchase_price", price);
                    cmd.Parameters.AddWithValue("@purchase_total_price", total);
                    cmd.Parameters.AddWithValue("@purchase_product_id", id);
                    cmd.Parameters.AddWithValue("@purchase_invoice_date", invoiceDate);
                    cmd.Parameters.AddWithValue("@purchase_brand", brand);
                    cmd.Parameters.AddWithValue("@purchase_description", description);
                    cmd.Parameters.AddWithValue("@purchase_product_date", productDate);

                    // Hiển thị thông tin chi tiết để kiểm tra
                    //MessageBox.Show($"ID: {id}, Quantity: {quantity}, Price: {price}, Total: {total}, Invoice: {invoice}, Invoice Date: {invoiceDate}, Product Date: {productDate}, Brand: {brand}, Description: {description}");

                    // Thực thi câu lệnh SQL
                    cmd.ExecuteNonQuery();

                    // Thông báo thành công
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có ngoại lệ
                    MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }


        }

        public void LoadPurchaseList(PurchaseListScreen purchaseListScreen)
        {
            // Binding data to ListView
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    List<PurchaseItemView> purchaseItems = new List<PurchaseItemView>();
                    connect.Open();
                    // Truy vấn SQL
                    string query = @"
                        SELECT 
                            pi.purchase_id AS PurchaseId,
                            pi.purchase_quantity AS Quantity,
                            pi.purchase_price AS Price,
                            pi.purchase_total_price AS Total,
                            pi.purchase_invoice_date AS InvoiceDate,
                            p.products_code AS ProductId,
                            p.products_name AS ProductName,
                            p.products_unit AS Unit,
                            c.category_name AS BrandName
                        FROM 
                            PURCHASE_ITEM pi
                        INNER JOIN 
                            PRODUCTS p ON pi.purchase_product_id = p.products_code
                        INNER JOIN 
                            CATEGORY c ON p.category_id = c.category_id";
                    SqlCommand cmd = new SqlCommand(query, connect);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        PurchaseItemView purchaseItem = new PurchaseItemView();
                        purchaseItem.STT_view += 1;
                        purchaseItem.PurchaseId_view = reader.GetInt32(0);
                        purchaseItem.Quantity_view = reader.GetInt32(1);
                        purchaseItem.Price_view = reader.GetInt32(2);
                        purchaseItem.Total_view = reader.GetInt32(3);
                        purchaseItem.InvoiceDate_view = reader.GetString(4);
                        purchaseItem.ProductId_view = reader.GetInt32(5);
                        purchaseItem.ProductName_view = reader.GetString(6);
                        purchaseItem.Unit_view = reader.GetString(7);
                        purchaseItem.BrandName_view = reader.GetString(8);
                        purchaseItems.Add(purchaseItem);
                    }
                    // Gán dữ liệu vào ListView của PurchaseListScreen
                    purchaseListScreen.purchaseList.ItemsSource = purchaseItems;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public void UpdatePurchaseInDatabase(PurchaseItem purchaseItem, int oldProductId)
        {
          

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"
                UPDATE purchase_item 
                SET
                    purchase_id = @purchase_id,
                    purchase_quantity = @purchase_quantity,
                    purchase_price = @purchase_price,
                    purchase_total_price = @purchase_total_price,
                    purchase_product_id = @purchase_product_id,
                    purchase_invoice_date = @purchase_invoice_date,
                    purchase_brand = @purchase_brand,
                    purchase_description = @purchase_description,
                    purchase_product_date = @purchase_product_date
                WHERE purchase_product_id = @purchase_product_idOld
                ";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@purchase_id", purchaseItem.PurchaseId);
                        cmd.Parameters.AddWithValue("@purchase_quantity", purchaseItem.Quantity);
                        cmd.Parameters.AddWithValue("@purchase_price", purchaseItem.Price);
                        cmd.Parameters.AddWithValue("@purchase_total_price", purchaseItem.Total);
                        cmd.Parameters.AddWithValue("@purchase_product_id", purchaseItem.ProductId);
                        cmd.Parameters.AddWithValue("@purchase_invoice_date", purchaseItem.InvoiceDate);
                        cmd.Parameters.AddWithValue("@purchase_brand", purchaseItem.Brand);
                        cmd.Parameters.AddWithValue("@purchase_description", purchaseItem.Description);
                        cmd.Parameters.AddWithValue("@purchase_product_date", purchaseItem.ProductDate);
                        cmd.Parameters.AddWithValue("@purchase_product_idOld", oldProductId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sản phẩm đã được cập nhật thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có dòng nào được cập nhật. Vui lòng kiểm tra dữ liệu.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        //Gọi hàm refreshProductBtn từ ProductsListScreen để cập nhật lại dữ liệu trên ListView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public PurchaseItem GetPurchaseItem(int selectedPurchaseId)
        {
            PurchaseItem purchaseItem = new PurchaseItem();
            using (SqlConnection connect = DatabaseConnection.GetConnection())
            {
                try
                {
                    connect.Open();
                    string query = "SELECT * FROM purchase_item WHERE purchase_id = @purchase_id";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@purchase_id", selectedPurchaseId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        
                        purchaseItem.ProductId = reader.GetInt32(4);
                        purchaseItem.Quantity = reader.GetInt32(1);
                        purchaseItem.Price = reader.GetInt32(2);
                        purchaseItem.Total = reader.GetInt32(3);
                        purchaseItem.PurchaseId = reader.GetInt32(0);
                        purchaseItem.InvoiceDate = reader.GetString(5);
                        purchaseItem.Description = reader.GetString(7);
                        purchaseItem.Brand = reader.GetInt32(6);
                        purchaseItem.ProductDate = reader.GetString(8);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            return purchaseItem;
        }

        public void SaveSellItemToDatabase(SellItem item, string invoiceDate, int orderID)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                MS getBrandID = new MS();
                connection.Open();
               item.SellId = orderID;
                int brandId =Convert.ToInt32(getBrandID. GetDatabase("category_id", "products", "products_code", item.SellProductId));
                string query = @"
                    INSERT INTO ORDER_ITEM 
                        (order_transaction_id,order_number, order_product_id, order_item_quantity, 
                         order_item_sale_price, order_item_total_price, 
                         order_invoice_date, order_product_date, order_item_brand)
                    VALUES (@order_transaction_id,@OrderItemId, @ProductId, @Quantity, @SalePrice, 
                        @TotalPrice, @InvoiceDate, @ProductDate, @BrandId)";

                SqlCommand cmd = new SqlCommand(query, connection);

                // Sinh khóa chính ngẫu nhiên cho order_item_id
                //order_transaction_id sinh ra ngẫu nhiên từ 1-1000000 khong trùng nhau
                cmd.Parameters.AddWithValue("@order_transaction_id", new Random().Next(1, 1000000));
                cmd.Parameters.AddWithValue("@OrderItemId", item.SellId);
                cmd.Parameters.AddWithValue("@ProductId", item.SellProductId);
                cmd.Parameters.AddWithValue("@Quantity", item.SellQuantity);
                cmd.Parameters.AddWithValue("@SalePrice", item.SellPrice);
                cmd.Parameters.AddWithValue("@TotalPrice", item.SellTotal);
                cmd.Parameters.AddWithValue("@InvoiceDate", invoiceDate);
                cmd.Parameters.AddWithValue("@ProductDate", DateTime.Now.ToString("yyyy-MM-dd")); // Ngày sản xuất hiện tại
                cmd.Parameters.AddWithValue("@BrandId", brandId);

                cmd.ExecuteNonQuery();
            }
        }

        public void LoadSellList(SellProductListScreen sellListScreen)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
            SELECT 
                oi.order_number AS ReceiptCode,
                oi.order_invoice_date AS ExportDate,
                'Khách hàng A' AS CustomerName, -- Tạm dùng khách hàng cố định
                SUM(oi.order_item_quantity) AS TotalQuantity,
                SUM(oi.order_item_total_price) AS TotalAmount
            FROM 
                ORDER_ITEM oi
            INNER JOIN 
                PRODUCTS p ON oi.order_product_id = p.products_code
            GROUP BY 
                oi.order_number, oi.order_invoice_date";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                List<SellItemView> sellItems = new List<SellItemView>();

                while (reader.Read())
                {
                    SellItemView sellItem = new SellItemView();

                    sellItem.STT_view += 1;
                    sellItem.SellId_view = reader.GetInt32(0);
                    sellItem.InvoiceDate_view = reader.GetString(1);
                    sellItem.Quantity_view = reader.GetInt32(3);
                    sellItem.Total_view = reader.GetInt32(4);
                    sellItems.Add(sellItem);

                }

                sellListScreen.productSellList.ItemsSource = null;
                sellListScreen.productSellList.ItemsSource = sellItems;
            }
        }

        public List<SellItem> LoadsellProduct(int orderId)
        {
            List<SellItem> sellItems = new List<SellItem>();
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    oi.order_transaction_id,
                    oi.order_number,
                    oi.order_product_id,
                    oi.order_item_quantity,
                    oi.order_item_sale_price,
                    oi.order_item_total_price,
                    oi.order_invoice_date,
                    oi.order_product_date,
                    oi.order_item_brand,
                    p.products_name -- Thêm cột tên sản phẩm từ bảng PRODUCTS
                FROM ORDER_ITEM oi
                INNER JOIN PRODUCTS p ON oi.order_product_id = p.products_code
                WHERE oi.order_number = @order_number";
                

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@order_number", orderId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        SellItem sellItem = new SellItem
                        {
                            SellId = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0,
                            SellProductId = !reader.IsDBNull(2) ? reader.GetInt32(2) : 0,
                            SellProductName = !reader.IsDBNull(9) ? reader.GetString(9) : string.Empty,
                            SellQuantity = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0,
                            SellPrice = !reader.IsDBNull(4) ? reader.GetInt32(4) : 0,
                            SellTotal = !reader.IsDBNull(5) ? reader.GetInt32(5) : 0,
                            SellInvoiceDate = !reader.IsDBNull(6) ? reader.GetString(6) : string.Empty,
                            SellProductDate = !reader.IsDBNull(7) ? reader.GetString(7) : string.Empty,
                            SellBrand = !reader.IsDBNull(8) ? reader.GetInt32(8) : 0,
                        };

                        sellItems.Add(sellItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong LoadsellProduct: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            return sellItems;
        }
        public void UpdateSellProduct(string oldSellId, string newSellId, string invoiceDate, List<SellItem> sellItems)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                // Cập nhật các thông tin chính của phiếu xuất
                string mainQuery = @"
        UPDATE ORDER_ITEM 
        SET
            order_number = @newSellId,
            order_invoice_date = @invoiceDate
        WHERE order_number = @oldSellId
        ";

                SqlCommand mainCmd = new SqlCommand(mainQuery, connection);
                mainCmd.Parameters.AddWithValue("@newSellId", newSellId);
                mainCmd.Parameters.AddWithValue("@invoiceDate", invoiceDate);
                mainCmd.Parameters.AddWithValue("@oldSellId", oldSellId);
                mainCmd.ExecuteNonQuery();

                // Ghi dữ liệu trên GridView (từng dòng trong `sellItems`) vào cơ sở dữ liệu
                string itemQuery = @"
        UPDATE ORDER_ITEM 
        SET
            order_transaction_id = @order_transaction_id,
            order_number = @order_number,
            order_product_id = @order_product_id,
            order_item_quantity = @order_item_quantity,
            order_item_sale_price = @order_item_sale_price,
            order_item_total_price = @order_item_total_price,
            order_invoice_date = @order_invoice_date,
            order_product_date = @order_product_date,
            order_item_brand = @order_item_brand
        WHERE order_transaction_id = @order_transaction_id
        ";

                foreach (SellItem item in sellItems)
                {
                    SqlCommand itemCmd = new SqlCommand(itemQuery, connection);
                    itemCmd.Parameters.AddWithValue("@order_transaction_id", item.SellId);
                    itemCmd.Parameters.AddWithValue("@order_number", newSellId);
                    itemCmd.Parameters.AddWithValue("@order_product_id", item.SellProductId);
                    itemCmd.Parameters.AddWithValue("@order_item_quantity", item.SellQuantity);
                    itemCmd.Parameters.AddWithValue("@order_item_sale_price", item.SellPrice);
                    itemCmd.Parameters.AddWithValue("@order_item_total_price", item.SellTotal);
                    itemCmd.Parameters.AddWithValue("@order_invoice_date", invoiceDate);
                    itemCmd.Parameters.AddWithValue("@order_product_date", item.SellProductDate);
                    itemCmd.Parameters.AddWithValue("@order_item_brand", item.SellBrand);
                    itemCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật phiếu xuất thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public DataTable ConvertDataGridToDataTable(DataGrid dataGrid)
        {
            DataTable dataTable = new DataTable();

            // Thêm cột
            foreach (DataGridColumn column in dataGrid.Columns)
            {
                dataTable.Columns.Add(column.Header.ToString());
            }

            // Thêm hàng
            foreach (var item in dataGrid.Items)
            {
                DataRow row = dataTable.NewRow();

                for (int i = 0; i < dataGrid.Columns.Count; i++)
                {
                    var cellContent = dataGrid.Columns[i].GetCellContent(item);
                    row[i] = (cellContent as TextBlock)?.Text ?? string.Empty;
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }


        public void ExportToExcel(DataTable dataTable)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            string filePath = string.Empty;
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                filePath = saveFileDialog.FileName;

            }

            

            using (ExcelPackage excel = new ExcelPackage())
            {
                var worksheet = excel.Workbook.Worksheets.Add("Sheet1");

                // Thêm header
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    worksheet.Cells[1, i + 1].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin); // Thêm border cho header
                }

                // Thêm dữ liệu
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataTable.Rows[i][j];
                        worksheet.Cells[i + 2, j + 1].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin); // Thêm border cho dữ liệu
                    }
                }

                // Tự động điều chỉnh độ rộng cột
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Lưu file
                excel.SaveAs(new System.IO.FileInfo(filePath));
            }

            MessageBox.Show($"Xuất file Excel thành công: {filePath}", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }


    }
}


