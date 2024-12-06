using Microsoft.Data.SqlClient;
using System;

namespace Project
{
    //Luu tru chuoi ket noi toi CSDL de tai su dung trong cac man hinh khac
    //import thu vien Microsoft.Data.SqlClient de su dung SqlConnection
    public static class DatabaseConnection
    {
        //Luu tru chuoi ket noi
        public static string ConnectionString { get; set; }

        // Hàm trả về kết nối mới mỗi lần gọi
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
