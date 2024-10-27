using Product_Manage_Tool_WF.Data;
using Product_Manage_Tool_WF.Forms.Child_Forms;
using Product_Manage_Tool_WF.IO;
using Product_Manage_Tool_WF.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Product_Manage_Tool_WF.Forms
{
	public class FrmMain : Form
	{
		private Button CurrentButton;
		private static Form ActivatingForm;
		private Random random;
		private static int tempThemeColorIndex;
		private IContainer components = null;
		private Panel pnlMenu;
		private Button btnSearch;
		private Button btnTypeManagement;
		private Button btnProductManagement;
		private Panel pnlLogo;
		private Label lblInfo3;
		private Label lblInfo2;
		private Label lblInfo1;
		private Panel pnlTitle;
		private Label lblTitle;
		private Panel pnlChildForm;
		private Color SelectThemeColor()
		{
			int num = this.random.Next(ThemeStyle.ColorList.Length);
			while (FrmMain.tempThemeColorIndex == num)
			{
				num = this.random.Next(ThemeStyle.ColorList.Length);
			}
			FrmMain.tempThemeColorIndex = num;
			string htmlColor = ThemeStyle.ColorList[num];
			return ColorTranslator.FromHtml(htmlColor);
		}
		private void ActivateButton(object btnSender)
		{
			bool flag = this.CurrentButton != (Button)btnSender;
			if (flag)
			{
				this.DeactivateAllMenuButton();
				Color backColor = this.SelectThemeColor();
				this.CurrentButton = (Button)btnSender;
				this.CurrentButton.BackColor = backColor;
				this.CurrentButton.ForeColor = Color.White;
				this.CurrentButton.Font = ThemeStyle.ACTIVE_BTN_FONT_STYLE;
				this.lblTitle.Text = this.CurrentButton.Text.TrimStart(new char[]
				{
					' '
				});
				this.pnlTitle.BackColor = backColor;
			}
		}
		private void DeactivateAllMenuButton()
		{
			foreach (Control control in this.pnlMenu.Controls)
			{
				bool flag = control.GetType() == typeof(Button);
				if (flag)
				{
					Button button = (Button)control;
					button.BackColor = ThemeStyle.INACTIVE_BTN_BACK_GROUND_COLOR;
					button.ForeColor = ThemeStyle.INACTIVE_BTN_FORE_COLOR;
					button.Font = ThemeStyle.INACTIVE_BTN_FONT_STYLE;
				}
			}
		}
		private void OpenChildForm(Form childForm, object btnSender)
		{
			bool flag = FrmMain.ActivatingForm != null;
			if (flag)
			{
				FrmMain.ActivatingForm.Close();
			}
			this.ActivateButton(btnSender);
			FrmMain.ActivatingForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.pnlChildForm.Controls.Add(childForm);
			this.pnlChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
		public FrmMain()
		{
			this.InitializeComponent();
			this.random = new Random();
			Global.TypeList.Add(new Product_Manage_Tool_WF.Data.Type("NUOCNGOT01", "Coca Cola"));
			Global.TypeList.Add(new Product_Manage_Tool_WF.Data.Type("NUOCNGOT02", "Pepsi"));
			Global.TypeList.Add(new Product_Manage_Tool_WF.Data.Type("BANH01", "Bánh Ngọt"));
			Global.TypeList.Add(new Product_Manage_Tool_WF.Data.Type("BANH02", "Bánh Mặn"));
			Global.TypeList.Add(new Product_Manage_Tool_WF.Data.Type("KEO01", "Kẹo sinh-gum"));
			Global.TypeList.Add(new Product_Manage_Tool_WF.Data.Type("KEO02", "Kẹo ngậm"));
			Global.ProductList.Add(new Product("A4387384", "Coca Cola Light", "29/02/2024", "Công ty Coca-Cola", 2022, new Product_Manage_Tool_WF.Data.Type("NUOCNGOT01", "Coca Cola")));
			Global.ProductList.Add(new Product("A9067860", "Coca Cola Zero", "21/12/2024", "Công ty Coca-Cola", 2022, new Product_Manage_Tool_WF.Data.Type("NUOCNGOT01", "Coca Cola")));
			Global.ProductList.Add(new Product("B4385749", "Pepsi Diet", "12/01/2023", "Công ty PepsiCo", 2020, new Product_Manage_Tool_WF.Data.Type("NUOCNGOT02", "Pepsi")));
			Global.ProductList.Add(new Product("B6378952", "Pepsi Thường", "24/06/2023", "Công ty PepsiCo", 2021, new Product_Manage_Tool_WF.Data.Type("NUOCNGOT02", "Pepsi")));
			Global.ProductList.Add(new Product("C4838219", "Sing-gum Cool Air", "12/03/2025", "Công ty Wrigley", 2021, new Product_Manage_Tool_WF.Data.Type("KEO01", "Kẹo sinh-gum")));
			Global.ProductList.Add(new Product("D5712946", "Bánh Bông Lan", "24/08/2022", "Công ty Kinh Đô", 2022, new Product_Manage_Tool_WF.Data.Type("BANH01", "Bánh Ngọt")));
			this.OpenChildForm(new FrmAddProduct(), this.btnProductManagement);
		}
		private void btnProductManagement_Click(object sender, EventArgs e)
		{
			this.OpenChildForm(new FrmAddProduct(), sender);
		}
		private void btnTypeManagement_Click(object sender, EventArgs e)
		{
			this.OpenChildForm(new FrmAddProductType(), sender);
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.OpenChildForm(new FrmSearch(), sender);
		}
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.pnlMenu = new Panel();
			this.btnSearch = new Button();
			this.btnTypeManagement = new Button();
			this.btnProductManagement = new Button();
			this.pnlLogo = new Panel();
			this.lblInfo3 = new Label();
			this.lblInfo2 = new Label();
			this.lblInfo1 = new Label();
			this.pnlTitle = new Panel();
			this.lblTitle = new Label();
			this.pnlChildForm = new Panel();
			this.pnlMenu.SuspendLayout();
			this.pnlLogo.SuspendLayout();
			this.pnlTitle.SuspendLayout();
			base.SuspendLayout();
			this.pnlMenu.BackColor = Color.FromArgb(31, 30, 68);
			this.pnlMenu.Controls.Add(this.btnSearch);
			this.pnlMenu.Controls.Add(this.btnTypeManagement);
			this.pnlMenu.Controls.Add(this.btnProductManagement);
			this.pnlMenu.Controls.Add(this.pnlLogo);
			this.pnlMenu.Dock = DockStyle.Left;
			this.pnlMenu.Location = new Point(0, 0);
			this.pnlMenu.Name = "pnlMenu";
			this.pnlMenu.Size = new Size(260, 601);
			this.pnlMenu.TabIndex = 0;
			this.btnSearch.BackColor = Color.FromArgb(50, 52, 77);
			this.btnSearch.Dock = DockStyle.Top;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = FlatStyle.Flat;
			this.btnSearch.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnSearch.ForeColor = Color.Gainsboro;
			this.btnSearch.Image = Resources.icons8_search_50;
			this.btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new Point(0, 210);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new Size(260, 60);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "        Tìm Kiếm";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
			this.btnTypeManagement.BackColor = Color.FromArgb(50, 52, 77);
			this.btnTypeManagement.Dock = DockStyle.Top;
			this.btnTypeManagement.FlatAppearance.BorderSize = 0;
			this.btnTypeManagement.FlatStyle = FlatStyle.Flat;
			this.btnTypeManagement.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnTypeManagement.ForeColor = Color.Gainsboro;
			this.btnTypeManagement.Image = Resources.icons8_add_tag_50;
			this.btnTypeManagement.ImageAlign = ContentAlignment.MiddleLeft;
			this.btnTypeManagement.Location = new Point(0, 150);
			this.btnTypeManagement.Name = "btnTypeManagement";
			this.btnTypeManagement.Size = new Size(260, 60);
			this.btnTypeManagement.TabIndex = 2;
			this.btnTypeManagement.Text = "        Quản Lý Loại Hàng";
			this.btnTypeManagement.UseVisualStyleBackColor = false;
			this.btnTypeManagement.Click += new EventHandler(this.btnTypeManagement_Click);
			this.btnProductManagement.BackColor = Color.FromArgb(22, 144, 248);
			this.btnProductManagement.Dock = DockStyle.Top;
			this.btnProductManagement.FlatAppearance.BorderSize = 0;
			this.btnProductManagement.FlatStyle = FlatStyle.Flat;
			this.btnProductManagement.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnProductManagement.ForeColor = Color.Gainsboro;
			this.btnProductManagement.Image = Resources.Storage_50x50;
			this.btnProductManagement.ImageAlign = ContentAlignment.MiddleLeft;
			this.btnProductManagement.Location = new Point(0, 90);
			this.btnProductManagement.Name = "btnProductManagement";
			this.btnProductManagement.Size = new Size(260, 60);
			this.btnProductManagement.TabIndex = 1;
			this.btnProductManagement.Text = "        Quản Lý Mặt Hàng";
			this.btnProductManagement.UseVisualStyleBackColor = false;
			this.btnProductManagement.Click += new EventHandler(this.btnProductManagement_Click);
			this.pnlLogo.BackColor = Color.FromArgb(37, 38, 40);
			this.pnlLogo.Controls.Add(this.lblInfo3);
			this.pnlLogo.Controls.Add(this.lblInfo2);
			this.pnlLogo.Controls.Add(this.lblInfo1);
			this.pnlLogo.Dock = DockStyle.Top;
			this.pnlLogo.Location = new Point(0, 0);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Size = new Size(260, 90);
			this.pnlLogo.TabIndex = 0;
			this.lblInfo3.AutoSize = true;
			this.lblInfo3.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblInfo3.ForeColor = Color.LightGray;
			this.lblInfo3.Location = new Point(55, 56);
			this.lblInfo3.Name = "lblInfo3";
			this.lblInfo3.Size = new Size(131, 21);
			this.lblInfo3.TabIndex = 2;
			this.lblInfo3.Text = "MSSV: 21880213";
			this.lblInfo2.AutoSize = true;
			this.lblInfo2.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblInfo2.ForeColor = Color.LightGray;
			this.lblInfo2.Location = new Point(46, 32);
			this.lblInfo2.Name = "lblInfo2";
			this.lblInfo2.Size = new Size(156, 21);
			this.lblInfo2.TabIndex = 1;
			this.lblInfo2.Text = "Đặng Vũ Ngọc Giang";
			this.lblInfo1.AutoSize = true;
			this.lblInfo1.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblInfo1.ForeColor = Color.LightGray;
			this.lblInfo1.Location = new Point(24, 9);
			this.lblInfo1.Name = "lblInfo1";
			this.lblInfo1.Size = new Size(197, 21);
			this.lblInfo1.TabIndex = 0;
			this.lblInfo1.Text = "Đồ án Nhập Môn Lập Trình";
			this.pnlTitle.BackColor = Color.FromArgb(0, 114, 228);
			this.pnlTitle.Controls.Add(this.lblTitle);
			this.pnlTitle.Dock = DockStyle.Top;
			this.pnlTitle.Location = new Point(260, 0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new Size(769, 90);
			this.pnlTitle.TabIndex = 1;
			this.lblTitle.Dock = DockStyle.Fill;
			this.lblTitle.Font = new Font("Tahoma", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = Color.White;
			this.lblTitle.Location = new Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new Size(769, 90);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Quản Lý Mặt Hàng";
			this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
			this.pnlChildForm.Dock = DockStyle.Fill;
			this.pnlChildForm.Location = new Point(260, 90);
			this.pnlChildForm.Name = "pnlChildForm";
			this.pnlChildForm.Size = new Size(769, 511);
			this.pnlChildForm.TabIndex = 2;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(35, 35, 79);
			base.ClientSize = new Size(1029, 601);
			base.Controls.Add(this.pnlChildForm);
			base.Controls.Add(this.pnlTitle);
			base.Controls.Add(this.pnlMenu);
			this.MinimumSize = new Size(875, 605);
			base.Name = "FrmMain";
			this.Text = "Phần mềm quản lý cửa hàng";
			this.pnlMenu.ResumeLayout(false);
			this.pnlLogo.ResumeLayout(false);
			this.pnlLogo.PerformLayout();
			this.pnlTitle.ResumeLayout(false);
			base.ResumeLayout(false);
		}
	}
}
