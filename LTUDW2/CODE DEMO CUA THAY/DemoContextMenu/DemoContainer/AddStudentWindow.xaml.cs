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

namespace DemoContainer
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public Student NewStudent {
            get; set;
        } = new Student();

        public AddStudentWindow()
        {
            InitializeComponent();

            studentUserControl.DataContext = NewStudent;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {            
            DialogResult = true;
        }
    }
}
