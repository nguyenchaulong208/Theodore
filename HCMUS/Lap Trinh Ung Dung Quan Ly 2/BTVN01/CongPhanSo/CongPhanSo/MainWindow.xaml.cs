using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CongPhanSo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string PhanSoA = phanSoA.Text;
            string[] tokenA = PhanSoA.Split(new string[] { "/" }, StringSplitOptions.None);
            int tuSoA = Convert.ToInt32(tokenA[0]);
            int mauSoA = Convert.ToInt32(tokenA[1]);

            string PhanSoB = phanSoB.Text;
            string[] tokenB = PhanSoB.Split(new string[] { "/" }, StringSplitOptions.None);
            int tuSoB = Convert.ToInt32(tokenB[0]);
            int mauSoB = Convert.ToInt32(tokenB[1]);
            int TuSo;
            int MauSo;
            
            if(mauSoA is not 0 ||  mauSoB is not 0)
            {
                if (mauSoA == mauSoB)
                {
                    TuSo = tuSoA + tuSoB;
                    MauSo = mauSoA;
                }
                else
                {
                    TuSo = tuSoA * mauSoB + mauSoA * tuSoB;
                    MauSo = mauSoA * mauSoB;
                }

                MessageBox.Show($"{TuSo}/{MauSo}");
            }
            else
            {
                MessageBox.Show("Phân số không hợp lệ");
            }
            

        }
    }
}