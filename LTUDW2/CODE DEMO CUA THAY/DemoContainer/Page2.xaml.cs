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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : PageFunction<String>
    {
        public Page2(string oldData)
        {
            InitializeComponent();

            newDataTextBox.Text = oldData;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            OnReturn(new ReturnEventArgs<String>(newDataTextBox.Text));
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            OnReturn(null);
        }
    }
}
