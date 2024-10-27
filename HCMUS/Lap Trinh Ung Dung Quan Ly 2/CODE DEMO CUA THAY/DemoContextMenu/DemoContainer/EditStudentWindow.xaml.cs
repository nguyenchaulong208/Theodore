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
using static DemoContainer.StudentUserControl;

namespace DemoContainer
{
    /// <summary>
    /// Interaction logic for EditStudentWindow.xaml
    /// </summary>
    public partial class EditStudentWindow : Window
    {
        


        public EditStudentWindow(Student oldStudent, NewCreditsUpdated handler)
        {
            InitializeComponent();

            this.DataContext = oldStudent;
            studentUserControl.DataContext = oldStudent;
            studentUserControl.OnNewCreditsHandler += handler;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
