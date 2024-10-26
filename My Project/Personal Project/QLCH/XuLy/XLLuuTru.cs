using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuaHang;

namespace XuLy
{
    public class XLLuuTru
    {
        //Tao duong dan luu tru
        private string _duongdan;
        public XLLuuTru(string duongdan)
        {
            this._duongdan = duongdan;
        }
        //Ghi du lieu vao file
        public void Ghidulieu(List<Theodore> dl)
        {
            StreamWriter newdl = new StreamWriter(_duongdan);
            newdl.WriteLine();
            newdl.Close();
        }

    }
}
