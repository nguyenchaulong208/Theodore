using Microsoft.Data.SqlClient;
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
    /// Interaction logic for ConfigScreen.xaml
    /// </summary>
    public partial class ConfigScreen : Page
    {
        public ConfigScreen()
        {
            InitializeComponent();
        }

        private void connectsvBtn(object sender, RoutedEventArgs e)
        {
            //Gan gia tri tu textbox vao bien
            string server = serverPort.Text.Trim();
            string database = db.Text.Trim();
            string username = userName.Text.Trim();
            string password = passServer.Password.Trim();

            //Kiem tra loai xac thuc dang nhap vao server la windows hay sql server authentication
            if (windowAuth.IsChecked == true)
            {
                string connectionString = $"""
                        Data Source={server};
                        Initial Catalog={database};
                        Integrated Security=True;
                        TrustServerCertificate=True;
                        """;
                var connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection successful");
                    DatabaseConnection.ConnectionString = connectionString;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {

                string connectionString = $"""
                    Server={server};
                    Database={database};
                    User Id={username};
                    Password ={password};
                    Trusted_Connection=True;
                    """;

                var connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection successful");
                    DatabaseConnection.ConnectionString = connectionString;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

       
    }
}
