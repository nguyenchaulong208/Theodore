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
            string server = serverPort.Text;
            string database = db.Text;
            string username = userName.Text;
            string password = passServer.Password;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            

        }
    }
}
