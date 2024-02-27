using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace HttpRequest_Bai1_GetDataFrom_HowKteam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crawl
            /*
             HttpClient
             HttpWebClient
             WebClient
             HttpWebRequest
             HttpRequest
             */
            //Lấy dữ liệu từ trang web HowKteam: soucre code của trang web
            var html = GetData("https://www.howkteam.com/"); //GetData là hàm tự định nghĩa
            TestData(html);//TestData là hàm tự định nghĩa
        }

        void TestData(string html)
        {
            File.WriteAllText("res.html", html);//Lưu source code của trang web vào file res.html
            Process.Start("res.html");//Mở file res.html
        }

        void AddCookie(HttpRequest http, string cookie)//Thêm cookie vào HttpRequest
        {
            var temp = cookie.Split(';');//Tách chuỗi cookie thành các phần tử con
            //Lặp qua từng phần tử con và thêm vào HttpRequest dưới dạng key-value
            foreach (var item in temp)
            {
                var temp2 = item.Split('=');
                if (temp2.Count() > 1)
                {
                    http.Cookies.Add(temp2[0], temp2[1]);
                }
            }
        }

        string GetData(string url, string cookie = null)//Lấy dữ liệu trang web
        {
            HttpRequest http = new HttpRequest();//Khởi tạo HttpRequest để request về trang web HowKteam
            http.Cookies = new CookieDictionary();//Khởi tạo CookieDictionary để lưu cookie của trang web sau khi request về thành công

            
            if (!string.IsNullOrEmpty(cookie))//Nếu cookie không rỗng thì thêm cookie vào HttpRequest để request về trang web
            {
                AddCookie(http, cookie);
            }
            //Thiết lập UserAgent để request về trang web
            http.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
            
            string html = http.Get(url).ToString();//Request về trang web và lấy source code của trang web
            return html;//Trả về source code của trang web
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cookie = "";
            var html = GetData("https://www.howkteam.com/", cookie);
            TestData(html);
        }
    }
}
