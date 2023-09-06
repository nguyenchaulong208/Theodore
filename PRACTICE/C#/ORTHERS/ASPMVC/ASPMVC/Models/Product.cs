using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASPMVC.Models
{
    public class Product
    {
        [DisplayName("Mã sản phẩm")]
        public int ProductID { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string NameOfProduct { get; set; }
        [DisplayName("Mã loại sản phẩm")]
        public int CategoryOfProductID { get; set; }
    }
}