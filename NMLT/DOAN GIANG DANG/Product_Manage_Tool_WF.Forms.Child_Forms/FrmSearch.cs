using Product_Manage_Tool_WF.Data;
using Product_Manage_Tool_WF.IO;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Product_Manage_Tool_WF.Forms.Child_Forms
{
	public class FrmSearch : Form
	{
		private static ListProduct SearchResultProductList;
		private static ListType SearchResultTypeList;
		private IContainer components = null;
		private Button btnClearSearchInfo;
		private Panel pnlInfo;
		private Label lblInfo1;
		private TableLayoutPanel tlpInput;
		private Label lblProductID;
		private TextBox txbProductID;
		private Label lblProductType;
		private ComboBox cbbProductTypeName;
		private Label lblResult;
		private DataGridView dgwProduct;
		private Label lblProductTypeID;
		private TextBox txbProductTypeID;
		private DataGridViewTextBoxColumn ClnProductID;
		private DataGridViewTextBoxColumn ClnProductname;
		private DataGridViewTextBoxColumn ClnExpiryDate;
		private DataGridViewTextBoxColumn ClnProductionCompany;
		private DataGridViewTextBoxColumn ClnManufactureYear;
		private DataGridViewTextBoxColumn clnProductTypeID;
		private DataGridViewTextBoxColumn ClnProductType;
		public FrmSearch()
		{
			this.InitializeComponent();
		}
		private void FrmSearch_Load(object sender, EventArgs e)
		{
			this.cbbProductTypeName.DropDownStyle = ComboBoxStyle.DropDownList;
			bool flag = Global.TypeList.CurrentLength > 0;
			if (flag)
			{
				FormIO.UpdateFromTypeListToComboBox(Global.TypeList, this.cbbProductTypeName);
			}
			bool flag2 = Global.ProductList.CurrentLength > 0;
			if (flag2)
			{
				FormIO.UpdateProductListToTable(Global.ProductList, this.dgwProduct);
			}
			FrmSearch.SearchResultProductList = Global.ProductList;
		}
		private void btnClearSearchInfo_Click(object sender, EventArgs e)
		{
			FormIO.ClearInputBoxes(this.tlpInput);
			this.cbbProductTypeName.SelectedIndex = -1;
			this.lblResult.Text = "KẾT QUẢ:";
			this.dgwProduct.Rows.Clear();
		}
		private void cbbProductType_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.cbbProductTypeName.SelectedIndex == -1;
			if (!flag)
			{
				int num = Global.TypeList.IndexOfTypeName(this.cbbProductTypeName.Text);
				Product_Manage_Tool_WF.Data.Type type = Global.TypeList.List[num];
				bool flag2 = this.txbProductID.Text.Equals(string.Empty);
				if (flag2)
				{
					this.txbProductTypeID.Text = type.TypeID;
				}
				this.txbProductID.Text = string.Empty;
				FrmSearch.SearchResultProductList = Global.ProductList.FindAllProductBelongThisType(type);
				FormIO.UpdateProductListToTable(FrmSearch.SearchResultProductList, this.dgwProduct);
				bool flag3 = FrmSearch.SearchResultProductList.CurrentLength == 0;
				if (flag3)
				{
					this.lblResult.Text = "KẾT QUẢ: KHÔNG TÌM THẤY LÔ HÀNG THỎA ĐIỀU KIỆN TÌM KIẾM";
				}
				else
				{
					this.lblResult.Text = "KẾT QUẢ:";
				}
			}
		}
		private void cbbProductType_Click(object sender, EventArgs e)
		{
			bool flag = this.txbProductTypeID.Text.Equals(string.Empty);
			if (flag)
			{
				FrmSearch.SearchResultTypeList = Global.TypeList;
			}
			FormIO.UpdateFromTypeListToComboBox(FrmSearch.SearchResultTypeList, this.cbbProductTypeName);
		}
		private void cbbProductType_MouseClick(object sender, MouseEventArgs e)
		{
			this.cbbProductType_SelectedIndexChanged(sender, e);
		}
		private void txbProductTypeID_KeyUp(object sender, KeyEventArgs e)
		{
			this.txbProductID.Text = string.Empty;
			this.cbbProductTypeName.SelectedIndex = -1;
			bool flag = this.txbProductTypeID.Text == string.Empty;
			if (flag)
			{
				FrmSearch.SearchResultTypeList = Global.TypeList;
			}
			else
			{
				FrmSearch.SearchResultTypeList = Global.TypeList.FindAllProductHaveThisStringInTypeID(this.txbProductTypeID.Text);
			}
			FormIO.UpdateFromTypeListToComboBox(FrmSearch.SearchResultTypeList, this.cbbProductTypeName);
			FrmSearch.SearchResultProductList.Clear();
			for (int i = 0; i < FrmSearch.SearchResultTypeList.CurrentLength; i++)
			{
				Product_Manage_Tool_WF.Data.Type thisType = FrmSearch.SearchResultTypeList.List[i];
				ListProduct listProduct = Global.ProductList.FindAllProductBelongThisType(thisType);
				for (int j = 0; j < listProduct.CurrentLength; j++)
				{
					FrmSearch.SearchResultProductList.Add(listProduct.List[j]);
				}
			}
			bool flag2 = FrmSearch.SearchResultProductList.CurrentLength == 0;
			if (flag2)
			{
				this.lblResult.Text = "KẾT QUẢ: KHÔNG TÌM THẤY LÔ HÀNG THỎA ĐIỀU KIỆN TÌM KIẾM";
			}
			else
			{
				this.lblResult.Text = "KẾT QUẢ:";
			}
			FormIO.UpdateProductListToTable(FrmSearch.SearchResultProductList, this.dgwProduct);
		}
		private void txbProductID_KeyUp(object sender, KeyEventArgs e)
		{
			ListProduct listProduct = FrmSearch.SearchResultProductList.FindAllProductHaveThisStringInID(this.txbProductID.Text);
			bool flag = listProduct.CurrentLength == 0;
			if (flag)
			{
				this.lblResult.Text = "KẾT QUẢ: KHÔNG TÌM THẤY LÔ HÀNG THỎA ĐIỀU KIỆN TÌM KIẾM";
			}
			else
			{
				this.lblResult.Text = "KẾT QUẢ:";
			}
			FormIO.UpdateProductListToTable(listProduct, this.dgwProduct);
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
			this.btnClearSearchInfo = new Button();
			this.pnlInfo = new Panel();
			this.lblInfo1 = new Label();
			this.tlpInput = new TableLayoutPanel();
			this.cbbProductTypeName = new ComboBox();
			this.lblProductType = new Label();
			this.lblProductID = new Label();
			this.txbProductID = new TextBox();
			this.lblProductTypeID = new Label();
			this.txbProductTypeID = new TextBox();
			this.lblResult = new Label();
			this.dgwProduct = new DataGridView();
			this.ClnProductID = new DataGridViewTextBoxColumn();
			this.ClnProductname = new DataGridViewTextBoxColumn();
			this.ClnExpiryDate = new DataGridViewTextBoxColumn();
			this.ClnProductionCompany = new DataGridViewTextBoxColumn();
			this.ClnManufactureYear = new DataGridViewTextBoxColumn();
			this.clnProductTypeID = new DataGridViewTextBoxColumn();
			this.ClnProductType = new DataGridViewTextBoxColumn();
			this.pnlInfo.SuspendLayout();
			this.tlpInput.SuspendLayout();
			((ISupportInitialize)this.dgwProduct).BeginInit();
			base.SuspendLayout();
			this.btnClearSearchInfo.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.btnClearSearchInfo.BackColor = Color.FromArgb(50, 52, 77);
			this.btnClearSearchInfo.FlatAppearance.BorderSize = 0;
			this.btnClearSearchInfo.FlatStyle = FlatStyle.Flat;
			this.btnClearSearchInfo.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnClearSearchInfo.ForeColor = Color.Gainsboro;
			this.btnClearSearchInfo.Location = new Point(483, 42);
			this.btnClearSearchInfo.Name = "btnClearSearchInfo";
			this.btnClearSearchInfo.Size = new Size(244, 33);
			this.btnClearSearchInfo.TabIndex = 2;
			this.btnClearSearchInfo.Text = "XÓA THÔNG TIN TÌM KIẾM";
			this.btnClearSearchInfo.UseVisualStyleBackColor = false;
			this.btnClearSearchInfo.Click += new EventHandler(this.btnClearSearchInfo_Click);
			this.pnlInfo.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.pnlInfo.AutoSize = true;
			this.pnlInfo.Controls.Add(this.lblInfo1);
			this.pnlInfo.Location = new Point(16, 12);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new Size(730, 35);
			this.pnlInfo.TabIndex = 5;
			this.lblInfo1.Dock = DockStyle.Fill;
			this.lblInfo1.FlatStyle = FlatStyle.Flat;
			this.lblInfo1.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblInfo1.ForeColor = Color.White;
			this.lblInfo1.Location = new Point(0, 0);
			this.lblInfo1.Margin = new Padding(0);
			this.lblInfo1.Name = "lblInfo1";
			this.lblInfo1.Size = new Size(730, 35);
			this.lblInfo1.TabIndex = 0;
			this.lblInfo1.Text = "Nhập mã hàng, mã loại hàng hoặc chọn loại hàng để tìm kiếm";
			this.lblInfo1.TextAlign = ContentAlignment.MiddleCenter;
			this.lblInfo1.UseCompatibleTextRendering = true;
			this.tlpInput.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.tlpInput.ColumnCount = 4;
			this.tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130f));
			this.tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));
			this.tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tlpInput.Controls.Add(this.btnClearSearchInfo, 3, 1);
			this.tlpInput.Controls.Add(this.cbbProductTypeName, 3, 0);
			this.tlpInput.Controls.Add(this.lblProductType, 2, 0);
			this.tlpInput.Controls.Add(this.lblProductID, 0, 1);
			this.tlpInput.Controls.Add(this.txbProductID, 1, 1);
			this.tlpInput.Controls.Add(this.lblProductTypeID, 0, 0);
			this.tlpInput.Controls.Add(this.txbProductTypeID, 1, 0);
			this.tlpInput.Location = new Point(16, 53);
			this.tlpInput.Name = "tlpInput";
			this.tlpInput.RowCount = 2;
			this.tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tlpInput.Size = new Size(730, 78);
			this.tlpInput.TabIndex = 6;
			this.cbbProductTypeName.Dock = DockStyle.Fill;
			this.cbbProductTypeName.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbbProductTypeName.FlatStyle = FlatStyle.Flat;
			this.cbbProductTypeName.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbbProductTypeName.FormattingEnabled = true;
			this.cbbProductTypeName.Location = new Point(483, 3);
			this.cbbProductTypeName.Name = "cbbProductTypeName";
			this.cbbProductTypeName.Size = new Size(244, 28);
			this.cbbProductTypeName.TabIndex = 12;
			this.cbbProductTypeName.SelectedIndexChanged += new EventHandler(this.cbbProductType_SelectedIndexChanged);
			this.cbbProductTypeName.Click += new EventHandler(this.cbbProductType_Click);
			this.cbbProductTypeName.MouseClick += new MouseEventHandler(this.cbbProductType_MouseClick);
			this.lblProductType.AutoSize = true;
			this.lblProductType.Dock = DockStyle.Fill;
			this.lblProductType.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblProductType.ForeColor = Color.WhiteSmoke;
			this.lblProductType.Location = new Point(383, 0);
			this.lblProductType.Name = "lblProductType";
			this.lblProductType.Size = new Size(94, 39);
			this.lblProductType.TabIndex = 8;
			this.lblProductType.Text = "Loại Hàng:";
			this.lblProductType.TextAlign = ContentAlignment.MiddleLeft;
			this.lblProductID.AutoSize = true;
			this.lblProductID.Dock = DockStyle.Fill;
			this.lblProductID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblProductID.ForeColor = Color.WhiteSmoke;
			this.lblProductID.Location = new Point(3, 39);
			this.lblProductID.Name = "lblProductID";
			this.lblProductID.Size = new Size(124, 39);
			this.lblProductID.TabIndex = 1;
			this.lblProductID.Text = "Mã Hàng:";
			this.lblProductID.TextAlign = ContentAlignment.MiddleLeft;
			this.txbProductID.Dock = DockStyle.Fill;
			this.txbProductID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txbProductID.Location = new Point(133, 42);
			this.txbProductID.Name = "txbProductID";
			this.txbProductID.Size = new Size(244, 26);
			this.txbProductID.TabIndex = 7;
			this.txbProductID.TextAlign = HorizontalAlignment.Right;
			this.txbProductID.KeyUp += new KeyEventHandler(this.txbProductID_KeyUp);
			this.lblProductTypeID.AutoSize = true;
			this.lblProductTypeID.Dock = DockStyle.Fill;
			this.lblProductTypeID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblProductTypeID.ForeColor = Color.WhiteSmoke;
			this.lblProductTypeID.Location = new Point(3, 0);
			this.lblProductTypeID.Name = "lblProductTypeID";
			this.lblProductTypeID.Size = new Size(124, 39);
			this.lblProductTypeID.TabIndex = 13;
			this.lblProductTypeID.Text = "Mã Loại Hàng:";
			this.lblProductTypeID.TextAlign = ContentAlignment.MiddleLeft;
			this.txbProductTypeID.Dock = DockStyle.Fill;
			this.txbProductTypeID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txbProductTypeID.Location = new Point(133, 3);
			this.txbProductTypeID.Name = "txbProductTypeID";
			this.txbProductTypeID.Size = new Size(244, 26);
			this.txbProductTypeID.TabIndex = 9;
			this.txbProductTypeID.TextAlign = HorizontalAlignment.Right;
			this.txbProductTypeID.KeyUp += new KeyEventHandler(this.txbProductTypeID_KeyUp);
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblResult.ForeColor = Color.White;
			this.lblResult.Location = new Point(12, 143);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new Size(88, 19);
			this.lblResult.TabIndex = 7;
			this.lblResult.Text = "KẾT QUẢ:";
			this.dgwProduct.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dgwProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwProduct.BackgroundColor = Color.FromArgb(50, 52, 77);
			this.dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProduct.Columns.AddRange(new DataGridViewColumn[]
			{
				this.ClnProductID,
				this.ClnProductname,
				this.ClnExpiryDate,
				this.ClnProductionCompany,
				this.ClnManufactureYear,
				this.clnProductTypeID,
				this.ClnProductType
			});
			this.dgwProduct.Location = new Point(16, 165);
			this.dgwProduct.Name = "dgwProduct";
			this.dgwProduct.ReadOnly = true;
			this.dgwProduct.Size = new Size(730, 354);
			this.dgwProduct.TabIndex = 8;
			this.ClnProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ClnProductID.HeaderText = "Mã";
			this.ClnProductID.Name = "ClnProductID";
			this.ClnProductID.ReadOnly = true;
			this.ClnProductID.Width = 47;
			this.ClnProductname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ClnProductname.HeaderText = "Tên Hàng";
			this.ClnProductname.Name = "ClnProductname";
			this.ClnProductname.ReadOnly = true;
			this.ClnExpiryDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ClnExpiryDate.HeaderText = "Hạn Dùng";
			this.ClnExpiryDate.Name = "ClnExpiryDate";
			this.ClnExpiryDate.ReadOnly = true;
			this.ClnExpiryDate.Width = 75;
			this.ClnProductionCompany.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ClnProductionCompany.HeaderText = "Công Ty Sản Xuất";
			this.ClnProductionCompany.Name = "ClnProductionCompany";
			this.ClnProductionCompany.ReadOnly = true;
			this.ClnManufactureYear.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ClnManufactureYear.HeaderText = "Năm Sản Xuất";
			this.ClnManufactureYear.Name = "ClnManufactureYear";
			this.ClnManufactureYear.ReadOnly = true;
			this.ClnManufactureYear.Width = 93;
			this.clnProductTypeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.clnProductTypeID.HeaderText = "Mã Loại Hàng";
			this.clnProductTypeID.Name = "clnProductTypeID";
			this.clnProductTypeID.ReadOnly = true;
			this.clnProductTypeID.Width = 91;
			this.ClnProductType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ClnProductType.HeaderText = "Loại Hàng";
			this.ClnProductType.Name = "ClnProductType";
			this.ClnProductType.ReadOnly = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(37, 38, 40);
			base.ClientSize = new Size(758, 531);
			base.Controls.Add(this.dgwProduct);
			base.Controls.Add(this.lblResult);
			base.Controls.Add(this.tlpInput);
			base.Controls.Add(this.pnlInfo);
			base.Name = "FrmSearch";
			this.Text = "FrmSearch";
			base.Load += new EventHandler(this.FrmSearch_Load);
			this.pnlInfo.ResumeLayout(false);
			this.tlpInput.ResumeLayout(false);
			this.tlpInput.PerformLayout();
			((ISupportInitialize)this.dgwProduct).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
