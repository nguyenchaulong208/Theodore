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

namespace BTVN08
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string oldData = dataTextBox.Text;

            var page = new Page2(oldData);
            page.Return += Page_Return;

            this.NavigationService.Navigate(page);
        }

        private void Page_Return(object sender, ReturnEventArgs<string> e)
        {
            if (e != null)
            {
                dataTextBox.Text = e.Result;
            }
        }


        public int MaxCredits => 140;


        //class MyInfo
        //{
        //    public int MaxCredits => 140;
        //}


        Student _sv = null;
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _sv = new Student() // Ráp : đọc dữ liệu từ database
            {
                ID = "001",
                Fullname = "Nguyen Minh Tam",
                Credits = 110
            };

            this.DataContext = _sv;

            //var info = new MyInfo();
            //maxCreditsProgresbar.DataContext = this;
            //maxCreditsRun.DataContext = this;
        }
    }
}
