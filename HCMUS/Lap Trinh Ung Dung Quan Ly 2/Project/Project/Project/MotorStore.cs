using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Product
    {
        private int _product_code { get; set; }
        private int _categoryProduct_id { get; set; }
        private string _product_name { get; set; }
        private string _product_description { get; set; }
        private string _product_image { get; set; }
        private string _product_unit { get; set; }

        public int ProductCode
        {
            get
            {
                return _product_code;
            }
            set
            {
                _product_code = value;
            }
        }
        public int CategoryProductId
        {
            get
            {
                return _categoryProduct_id;
            }
            set
            {
                _categoryProduct_id = value;
            }
        }
        public string ProductName
        {
            get
            {
                return _product_name;
            }
            set
            {
                _product_name = value;
            }
        }
        public string ProductDescription
        {
            get
            {
                return _product_description;
            }
            set
            {
                _product_description = value;
            }
        }
        public string ProductImage
        {
            get
            {
                return _product_image;
            }
            set
            {
                _product_image = value;
            }
        }
       
        public string ProductUnit
        {
            get
            {
                return _product_unit;
            }
            set
            {
                _product_unit = value;
            }
        }


    }

   
    public class  StoreAccount
    {
        private string _username { get; set; }
        private string _password { get; set; }
        private string _role { get; set; }
        private string _name { get; set; }
        private string _address { get; set; }
        private string _phone { get; set; }
        private string _email { get; set; }
        private string avatar { get; set; }
    }

    public class Category 
    {
        private int _category_id { get; set; }
        private string _category_name { get; set; }
        private string _category_description { get; set; }

        public int CategoryId
        {
            get
            {
                return _category_id;
            }
            set
            {
                _category_id = value;
            }
        }
        public string CategoryName
        {
            get
            {
                return _category_name;
            }
            set
            {
                _category_name = value;
            }
        }
        public string CategoryDescription
        {
            get
            {
                return _category_description;
            }
            set
            {
                _category_description = value;
            }
        }

    }

    public class PurchaseItem
    {
        private int _purchase_id { get; set; }
        private int _product_id { get; set; }
        private int _quantity { get; set; }
        private int _price { get; set; }
        private int _total { get; set; }
        private string _invoiceDate { get; set; }
        private string _productDate { get; set; }
        private int _brand { get; set; }
        private string _description { get; set; }

        public int PurchaseId
        {
            get
            {
                return _purchase_id;
            }
            set
            {
                _purchase_id = value;
            }
        }
        public int ProductId
        {
            get
            {
                return _product_id;
            }
            set
            {
                _product_id = value;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }

        public string InvoiceDate
        {
            get
            {
                return _invoiceDate;
            }
            set
            {
                _invoiceDate = value;
            }
        }
        public string ProductDate
        {
            get
            {
                return _productDate;
            }
            set
            {
                _productDate = value;
            }
        }
        public int Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
    }

    public class PurchaseItemView
    {
        public int STT_view { get; set; }
        public int ProductId_view { get; set; }
        public string ProductName_view { get; set; }
        public string Unit_view { get; set; }
        public int Quantity_view { get; set; }
        public int Price_view { get; set; }
        public int Total_view { get; set; }
        public int PurchaseId_view { get; set; }
        public string InvoiceDate_view { get; set; }
        public string BrandName_view { get; set; }
    }


}
