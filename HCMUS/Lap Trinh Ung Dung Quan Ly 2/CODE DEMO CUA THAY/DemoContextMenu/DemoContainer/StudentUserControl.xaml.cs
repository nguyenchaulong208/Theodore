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

namespace DemoContainer
{
    /// <summary>
    /// Interaction logic for StudentUserControl.xaml
    /// </summary>
    public partial class StudentUserControl : UserControl
    {

        public delegate void NewCreditsUpdated(int newCredits); // Kiểu
        public event NewCreditsUpdated OnNewCreditsHandler;    // con trỏ hàm

        public StudentUserControl()
        {
            InitializeComponent();
        }

        private void creditsSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            OnNewCreditsHandler?.Invoke((int)e.NewValue);
        }
    }
}
