using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PHAN_MEM_QUAN_LY_CUA_HANG
{
    public partial class quanlycuahang : Form
    {
        public quanlycuahang()
        {
            InitializeComponent();
        }
       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            //khai báo thêm các trường của listview1
            ListViewItem newdata = new ListViewItem(nhapmaHH.Text);

            newdata.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = nhaptenHH.Text});
            newdata.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = nhapHSD.Text});
            newdata.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = nhapCTY.Text});
            newdata.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = nhapnamSX.Text});
            newdata.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = nhapLH.Text});


            //Kiểm tra và thông báo khi chưa nhập đủ thông tin

            if (nhapmaHH.Text == "" || nhaptenHH.Text == "" || nhapHSD.Text == "" || nhapCTY.Text == "" || nhapnamSX.Text == ""|| nhapLH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //Thêm dữ liệu vào listview1
            if (nhapmaHH.Text != "" && nhaptenHH.Text != "" && nhapHSD.Text != "" && nhapCTY.Text != "" && nhapnamSX.Text != "" && nhapLH.Text != "")
            {

                listView1.Items.Add(newdata);
                nhapmaHH.Clear();
                nhaptenHH.Clear();
                nhapHSD.Clear();
                nhapCTY.Clear();
                nhapnamSX.Clear();
                nhapLH.Clear();
              

               MessageBox.Show("Đã thêm mặt hàng thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }
        //Chỉnh sửa
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem newlistview1 = listView1.SelectedItems[0];
                nhapmaHH.Text = newlistview1.SubItems[0].Text;
                nhaptenHH.Text = newlistview1.SubItems[1].Text;
                nhapHSD.Text = newlistview1.SubItems[2].Text;
                nhapCTY.Text = newlistview1.SubItems[3].Text;
                nhapnamSX.Text = newlistview1.SubItems[4].Text;
                nhapLH.Text = newlistview1.SubItems[5].Text;

                
            }

        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
               
            }    
        }
            private void button2_Click(object sender, EventArgs e)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem editlistView1 = listView1.SelectedItems[0];
                    editlistView1.SubItems[0].Text = nhapmaHH.Text;
                    editlistView1.SubItems[1].Text = nhaptenHH.Text;
                    editlistView1.SubItems[2].Text = nhapHSD.Text;
                    editlistView1.SubItems[3].Text = nhapCTY.Text;
                    editlistView1.SubItems[4].Text = nhapnamSX.Text;
                    editlistView1.SubItems[5].Text = nhapLH.Text;

                }

            }

        //Xóa
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn chắn chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
        }
        //Tìm kiếm
        private void search_Click(object sender, EventArgs e)
        {



            listView2.FullRowSelect = true;
            listView2.MultiSelect = true;
            listView2.GridLines = true;
            if (searchMaHH.Text != "" || searchTenHH.Text != "" || searchTenHH.Text !=" "|| searchDanhmuc.Text != "")
                {
                for (int i = 0; i < listView1.Items.Count; i++)
                {

                    if (listView1.Items[i].SubItems[0].Text.ToString() == searchMaHH.Text.ToString() || listView1.Items[i].SubItems[1].Text.ToString() == searchTenHH.Text.ToString() || listView1.Items[i].SubItems[5].Text.ToString() == searchDanhmuc.Text.ToString())
                    {

                        //gán biến phụ
                        string result1 = listView1.Items[i].SubItems[0].Text;
                        string result2 = listView1.Items[i].SubItems[1].Text;
                        string result3 = listView1.Items[i].SubItems[2].Text;
                        string result4 = listView1.Items[i].SubItems[3].Text;
                        string result5 = listView1.Items[i].SubItems[4].Text;
                        string result6 = listView1.Items[i].SubItems[5].Text;

                        //Thêm kết quả vào listView2
                        ListViewItem newdata2 = new ListViewItem(result1);
                        newdata2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result2 });
                        newdata2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result3 });
                        newdata2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result4 });
                        newdata2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result5 });
                        newdata2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result6 });
                        listView2.Items.Add(newdata2);

                    }


                }
                

            }
        }
            //Xóa kết quả tìm kiếm
        private void clear_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
        }
        
        private void ThemDanhMuc_Click(object sender, EventArgs e)
        {





           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}