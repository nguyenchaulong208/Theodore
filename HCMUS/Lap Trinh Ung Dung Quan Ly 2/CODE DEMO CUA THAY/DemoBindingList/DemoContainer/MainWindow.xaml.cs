using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Fluent;

namespace DemoContainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Student> _students = null;
        private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _students = new List<Student>()
            {                 
                new Student() {
                    ID = "001",
                    Name="Ngư Thuận Phong",
                    Avatar="Images/avatar01.jpg"
                },
                new Student() {
                    ID = "002",
                    Name="Mai Việt Hùng",
                    Avatar="Images/avatar02.jpg"
                },
                new Student() {
                    ID = "003",
                    Name="Thủy Tất Hiếu",
                    Avatar="Images/avatar03.jpg"
                },
                new Student() {
                    ID = "004",
                    Name="Nguyễn Trí Dũng",
                    Avatar="Images/avatar04.jpg"
                },
                 new Student() {
                    ID = "005",
                    Name="Hồ Hồng Quang",
                    Avatar="Images/avatar05.jpg"
                },
                new Student() {
                    ID = "006",
                    Name="Vũ Tuấn Hùng",
                    Avatar="Images/avatar06.jpg"
                },
                new Student() {
                    ID = "007",
                    Name="Nguyễn Việt Cường",
                    Avatar="Images/avatar07.jpg"
                },
                new Student() {
                    ID = "008",
                    Name="Lâm Thanh Toàn",
                    Avatar="Images/avatar08.jpg"
                },
                new Student() {
                    ID = "009",
                    Name="Trịnh Việt Nhân",
                    Avatar="Images/avatar09.jpg"
                },
                new Student() {
                    ID = "010",
                    Name="Bùi Ðức Cường",
                    Avatar="Images/avatar10.jpg"
                },
                new Student() {
                    ID = "011",
                    Name="Phan Thiện Dũng",
                    Avatar="Images/avatar11.jpg"
                },
                new Student() {
                    ID = "012",
                    Name="Phan Nhật Quân",
                    Avatar="Images/avatar12.jpg"
                },
                 new Student() {
                    ID = "013",
                    Name="Ngô Việt Dũng",
                    Avatar="Images/avatar13.jpg"
                },
                new Student() {
                    ID = "014",
                    Name="Hoàng Vinh Quốc",
                    Avatar="Images/avatar14.jpg"
                },
                new Student() {
                    ID = "015",
                    Name="Đặng Ðức Siêu",
                    Avatar="Images/avatar15.jpg"
                },
                new Student() {
                    ID = "016",
                    Name="Đàm Thanh Thanh",
                    Avatar="Images/avatar16.jpg"
                },
                new Student() {
                    ID = "017",
                    Name="Lục Phương Loan",
                    Avatar="Images/avatar17.jpg"
                },
                new Student() {
                    ID = "018",
                    Name="Uất Như Quỳnh",
                    Avatar="Images/avatar18.jpg"
                },
                new Student() {
                    ID = "019",
                    Name="Lạc Huyền Trân",
                    Avatar="Images/avatar19.jpg"
                },
                new Student() {
                    ID = "020",
                    Name="Nguyễn Băng Băng",
                    Avatar="Images/avatar20.jpg"
                }

            };

            dataListView.ItemsSource = _students;
        }
    }
}