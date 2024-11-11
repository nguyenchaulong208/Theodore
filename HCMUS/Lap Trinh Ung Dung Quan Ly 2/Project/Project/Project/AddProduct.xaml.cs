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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Page
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void addProductBtn(object sender, RoutedEventArgs e)
        {
            if(productTextbox.Text == "" || unitPriceTextbox.Text == "" || quantityTextbox.Text == "" || invNumTexbox.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                MessageBox.Show("Product added successfully");
            }
        }
    }
}
