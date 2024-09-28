using System.ComponentModel;
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

        BindingList<Student> _students = null;
        private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _students = new BindingList<Student>()
            {                 
                new Student() {
                    ID = "001",
                    Name="Ngư Thuận Phong",
                    Avatar="Images/avatar01.jpg",
                    Credits = 20
                },
                new Student() {
                    ID = "002",
                    Name="Mai Việt Hùng",
                    Avatar="Images/avatar02.jpg",
                    Credits = 100
                },
                new Student() {
                    ID = "003",
                    Name="Thủy Tất Hiếu",
                    Avatar="Images/avatar03.jpg",
                    Credits = 45,
                },
                new Student() {
                    ID = "004",
                    Name="Nguyễn Trí Dũng",
                    Avatar="Images/avatar04.jpg",
                    Credits = 80,
                },
                 new Student() {
                    ID = "005",
                    Name="Hồ Hồng Quang",
                    Avatar="Images/avatar05.jpg",
                    Credits = 112,
                },
                new Student() {
                    ID = "006",
                    Name="Vũ Tuấn Hùng",
                    Avatar="Images/avatar06.jpg",
                    Credits = 77,
                },
                new Student() {
                    ID = "007",
                    Name="Nguyễn Việt Cường",
                    Avatar="Images/avatar07.jpg",
                    Credits = 14,
                },
                new Student() {
                    ID = "008",
                    Name="Lâm Thanh Toàn",
                    Avatar="Images/avatar08.jpg",
                    Credits = 50,
                },
                new Student() {
                    ID = "009",
                    Name="Trịnh Việt Nhân",
                    Avatar="Images/avatar09.jpg",
                    Credits = 45,
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

        private void editProductButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student) dataListView.SelectedItem;
            _backup = (Student)selectedStudent.Clone(); // Cần preview real time 1 số thuộc tính
            var clone = (Student) selectedStudent.Clone();

            if (selectedStudent != null)
            {
                var screen = new EditStudentWindow(clone, OnNewCreditsUpdated);
                
                if (screen.ShowDialog() == true)
                {
                    selectedStudent.Name = clone.Name;
                    selectedStudent.Credits = clone.Credits;
                }
                else
                {
                    selectedStudent.Credits = _backup.Credits;
                }
            }
            else
            {
                MessageBox.Show("No student selected");
            }
        }

        Student _backup;

        private void OnNewCreditsUpdated(int newCredits) {
            var selectedStudent = (Student)dataListView.SelectedItem;
            selectedStudent.Credits = newCredits;
        }

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            //_students.Add(new Student()
            //{
            //    ID = "021",
            //    Name = "New Student",
            //    Avatar = "Images/avatar14.jpg",
            //    Credits = 140
            //});

            var screen = new AddStudentWindow();

            if (screen.ShowDialog() == true)
            {
                _students.Add(screen.NewStudent);
            }
        }

        private void deleteProductButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student) dataListView.SelectedItem;

            if (selectedStudent != null)
            {
                _students.Remove(selectedStudent);
            }
            else
            {
                MessageBox.Show("No student selected");
            }
        }

        private void deleteProductMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student)dataListView.SelectedItem;

            if (selectedStudent != null)
            {
                _students.Remove(selectedStudent);
            }
        }

        private void editProductMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedStudent = (Student)dataListView.SelectedItem;

            if (selectedStudent != null)
            {
                MessageBox.Show($"{selectedStudent.ID} - {selectedStudent.Name}");
            }
        }

        private void viewProductMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}