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
        private string _product_year { get; set; }

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
        public string ProductYear
        {
            get
            {
                return _product_year;
            }
            set
            {
                _product_year = value;
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


        //public Category(int category_id, string category_name, string category_description)
        //{
        //    _category_id = category_id;
        //    this._category_name = category_name;
        //    this._category_description = category_description;
        //}
        //public int CategoryId => _category_id;
        //public string CategoryName => _category_name;
        //public string CategoryDescription => _category_description;
    }


}
