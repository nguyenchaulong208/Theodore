using Product_Manage_Tool_WF.Data;
using Product_Manage_Tool_WF.IO;
using Product_Manage_Tool_WF.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Product_Manage_Tool_WF.Forms.Child_Forms
{
	public class FrmAddProductType : Form
	{
		private static int TypeTableNewRowIndex;
		private static int TypeTableCurrentRowIndex;
		private static Button PreviousButton;
		private static Product_Manage_Tool_WF.Data.Type EditingType;
		private static ListType SelectingTypeList;
		private IContainer components = null;
		private Panel pnlSecondaryControls;
		private Button btnCancel;
		private Button btnConfirm;
		private Panel pnlPrimaryControls;
		private Button btnRemove;
		private Button btnEdit;
		private Button btnAddNew;
		private TableLayoutPanel tlpInput;
		private DataGridView dgwProduct;
		private Label lblProductType;
		private Label lblProductTypeID;
		private TextBox txbProductTypeID;
		private DataGridViewTextBoxColumn ClnProductID;
		private DataGridViewTextBoxColumn ClnProductname;
		private DataGridViewTextBoxColumn ClnExpiryDate;
		private DataGridViewTextBoxColumn ClnProductionCompany;
		private DataGridViewTextBoxColumn ClnManufactureYear;
		private DataGridViewTextBoxColumn clnProductTypeID;
		private DataGridViewTextBoxColumn ClnProductType;
		private DataGridView dgwType;
		private Panel pnlInfoProductTable;
		private Label lblInfoProductTable;
		private Panel pnlInfoInput;
		private Label lblInfoInput;
		private TextBox txbProductTypeName;
		private DataGridViewTextBoxColumn ClnTypeID;
		private DataGridViewTextBoxColumn ClnTypeName;
		private Button btnRefreshTypeTable;
		public void UpdateFromTypeTableToInputBoxes(DataGridView dataGridView)
		{
			bool flag = dataGridView.SelectedCells.Count > 0;
			if (flag)
			{
				DataGridViewRow dataGridViewRow = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
				bool flag2 = !dataGridViewRow.IsNewRow;
				if (flag2)
				{
					this.txbProductTypeID.Text = dataGridViewRow.Cells[0].Value.ToString();
					this.txbProductTypeName.Text = dataGridViewRow.Cells[1].Value.ToString();
				}
			}
		}
		public void CheckAndEdit(Product_Manage_Tool_WF.Data.Type newType)
		{
			bool flag = false;
			bool flag2 = newType.Equals(FrmAddProductType.EditingType);
			if (flag2)
			{
				MessageBox.Show(this, "Chưa có thay đổi gì trong loại hàng này. Xin chỉnh sửa trước khi ấn xác nhận hoặc ấn hủy để giữ nguyên loại hàng.", "Loại Hàng Chưa Được Chỉnh Sửa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				bool flag3 = newType.TypeID == FrmAddProductType.EditingType.TypeID && !flag;
				if (flag3)
				{
					DialogResult dialogResult = MessageBox.Show(this, string.Concat(new string[]
					{
						"Bạn có chắc chắn muốn sửa tên loại hàng của Mã: ",
						FrmAddProductType.EditingType.TypeID,
						" thành ",
						newType.TypeName,
						" không?"
					}), "Sửa Tên Loại Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					bool flag4 = dialogResult == DialogResult.Yes;
					if (!flag4)
					{
						return;
					}
					Global.TypeList.Edit(FrmAddProductType.EditingType, newType);
					flag = true;
				}
				bool flag5 = Global.TypeList.IsContains(newType) && !flag;
				if (flag5)
				{
					DialogResult dialogResult2 = MessageBox.Show(this, string.Concat(new string[]
					{
						"Bạn có chắc chắn muốn sửa loại hàng ",
						FrmAddProductType.EditingType.TypeName,
						" (Mã: ",
						FrmAddProductType.EditingType.TypeID,
						") thành loại hàng ",
						newType.TypeName,
						" (Mã: ",
						newType.TypeID,
						") không?"
					}), "Sửa Loại Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					bool flag6 = dialogResult2 == DialogResult.Yes;
					if (!flag6)
					{
						return;
					}
					flag = true;
				}
				bool flag7 = !Global.TypeList.IsContains(newType) && !flag;
				if (flag7)
				{
					DialogResult dialogResult3 = MessageBox.Show(this, string.Concat(new string[]
					{
						"Loại hàng ",
						newType.TypeName,
						" (Mã: ",
						newType.TypeID,
						") chưa có trong dữ liệu. Bạn có chắc chắn muốn thêm mới loại hàng ",
						newType.TypeName,
						" (Mã: ",
						newType.TypeID,
						") và thay thế toàn bộ lô hàng có loại hàng ",
						FrmAddProductType.EditingType.TypeName,
						" (Mã: ",
						FrmAddProductType.EditingType.TypeID,
						") bằng loại hàng ",
						newType.TypeName,
						" (Mã: ",
						newType.TypeID,
						") không?"
					}), "Loại Hàng Được Sửa Thành Loại Hàng Chưa Có Trong Danh Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					bool flag8 = dialogResult3 == DialogResult.Yes;
					if (!flag8)
					{
						return;
					}
					Global.TypeList.Add(newType);
					FrmAddProductType.TypeTableCurrentRowIndex = FrmAddProductType.TypeTableNewRowIndex;
				}
				bool flag9 = Global.ProductList.FindAllProductBelongThisType(FrmAddProductType.EditingType).CurrentLength > 0;
				if (flag9)
				{
					Global.ProductList.EditTypeForAllProductsHaveType(FrmAddProductType.EditingType, newType);
				}
			}
		}
		public void AddNew()
		{
			bool flag = Global.TypeList.IsContainsTypeID(this.txbProductTypeID.Text);
			if (flag)
			{
				MessageBox.Show(this, "Mã loại hàng này đã có trong danh sách. Xin nhập mã loại hàng khác!", "Mã Loại Hàng Đã Tồn Tại", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				bool flag2 = Global.TypeList.IsContainsTypeName(this.txbProductTypeName.Text);
				if (flag2)
				{
					MessageBox.Show(this, "Tên loại hàng này đã có trong danh sách. Xin nhập tên khác!", "Tên loại Hàng Đã Tồn Tại", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					Product_Manage_Tool_WF.Data.Type newType = new Product_Manage_Tool_WF.Data.Type(this.txbProductTypeID.Text, this.txbProductTypeName.Text);
					Global.TypeList.Add(newType);
					FrmAddProductType.TypeTableCurrentRowIndex = FrmAddProductType.TypeTableNewRowIndex;
				}
			}
		}
		public FrmAddProductType()
		{
			this.InitializeComponent();
		}
		private void FrmAddProductType_Load(object sender, EventArgs e)
		{
			bool flag = Global.TypeList.CurrentLength > 0;
			if (flag)
			{
				FormIO.UpdateTypeListToTable(Global.TypeList, this.dgwType);
			}
			FormIO.EnableControls(this.pnlPrimaryControls);
			FormIO.DisableControls(this.pnlSecondaryControls);
		}
		private void btnAddNew_Click(object sender, EventArgs e)
		{
			FrmAddProductType.PreviousButton = (Button)sender;
			FormIO.DisableControls(this.pnlPrimaryControls);
			FormIO.EnableControls(this.pnlSecondaryControls);
			FormIO.ClearInputBoxes(this.tlpInput);
			this.txbProductTypeID.Focus();
			FormIO.DisableTables(this);
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			FrmAddProductType.PreviousButton = (Button)sender;
			bool flag = FormIO.IsAllInputBoxEmpty(this.tlpInput);
			if (flag)
			{
				MessageBox.Show(this, "Bạn chưa chọn loại hàng. Xin chọn loại hàng trước khi thực hiện sửa.", "Chưa Chọn Loại Hàng", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				Product_Manage_Tool_WF.Data.Type type = new Product_Manage_Tool_WF.Data.Type(this.txbProductTypeID.Text, this.txbProductTypeName.Text);
				bool flag2 = !Global.TypeList.IsContains(type);
				if (flag2)
				{
					MessageBox.Show(this, string.Concat(new string[]
					{
						"Loại hàng ",
						this.txbProductTypeName.Text,
						" (Mã: ",
						this.txbProductTypeID.Text,
						") không có trong có trong danh sách các loại hàng. Xin chọn lại ở bảng."
					}), "Loại Hàng Không Tồn Tại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					FrmAddProductType.EditingType = type;
					FormIO.DisableControls(this.pnlPrimaryControls);
					FormIO.EnableControls(this.pnlSecondaryControls);
					FormIO.DisableTables(this);
					this.dgwType.ClearSelection();
					this.dgwType.Rows[FrmAddProductType.TypeTableCurrentRowIndex].Selected = true;
					this.txbProductTypeID.Text = FrmAddProductType.EditingType.TypeID;
					this.txbProductTypeID.SelectAll();
					this.txbProductTypeID.Focus();
					this.txbProductTypeName.Text = FrmAddProductType.EditingType.TypeName;
				}
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			bool flag = FormIO.IsAnyInputBoxEmpty(this.tlpInput);
			if (flag)
			{
				MessageBox.Show(this, "Bạn chưa chọn loại hàng để xóa. Xin chọn lại!", "Chưa chọn loại hàng", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				Product_Manage_Tool_WF.Data.Type type = new Product_Manage_Tool_WF.Data.Type(this.txbProductTypeID.Text, this.txbProductTypeName.Text);
				bool flag2 = !Global.TypeList.IsContains(type);
				if (flag2)
				{
					MessageBox.Show(this, string.Concat(new string[]
					{
						"Loại hàng ",
						this.txbProductTypeName.Text,
						" (Mã: ",
						this.txbProductTypeID.Text,
						") không có trong có trong danh sách các loại hàng. Xin chọn lại ở bảng."
					}), "Loại Hàng Không Tồn Tại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					this.dgwType.ClearSelection();
					this.dgwType.Rows[FrmAddProductType.TypeTableCurrentRowIndex].Selected = true;
					DialogResult dialogResult = MessageBox.Show(this, string.Concat(new string[]
					{
						"Bạn có chắc chắn xóa loại hàng ",
						this.txbProductTypeName.Text,
						" (Mã: ",
						this.txbProductTypeID.Text,
						") và tất cả các lô hàng thuộc loại hàng này không?"
					}), "Xác Nhận Xóa Loại Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
					bool flag3 = dialogResult == DialogResult.Yes;
					if (flag3)
					{
						Global.ProductList.RemoveAllProductInType(type);
						Global.TypeList.Remove(type);
						FormIO.UpdateTypeListToTable(Global.TypeList, this.dgwType);
						this.dgwProduct.Rows.Clear();
					}
					FrmAddProductType.PreviousButton = (Button)sender;
				}
			}
		}
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			bool flag = FrmAddProductType.PreviousButton == this.btnAddNew;
			if (flag)
			{
				this.AddNew();
			}
			bool flag2 = FrmAddProductType.PreviousButton == this.btnEdit;
			if (flag2)
			{
				Product_Manage_Tool_WF.Data.Type type = new Product_Manage_Tool_WF.Data.Type(this.txbProductTypeID.Text, this.txbProductTypeName.Text);
				this.CheckAndEdit(type);
				FormIO.UpdateProductListToTable(Global.ProductList.FindAllProductBelongThisType(type), this.dgwProduct);
			}
			FormIO.DisableControls(this.pnlSecondaryControls);
			FormIO.EnableControls(this.pnlPrimaryControls);
			FormIO.EnableTables(this);
			FormIO.UpdateTypeListToTable(Global.TypeList, this.dgwType);
			this.dgwType.ClearSelection();
			this.dgwType.Rows[FrmAddProductType.TypeTableCurrentRowIndex].Selected = true;
			this.UpdateFromTypeTableToInputBoxes(this.dgwType);
			FrmAddProductType.PreviousButton = (Button)sender;
		}
		private void dgwType_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			FrmAddProductType.TypeTableNewRowIndex = e.RowIndex + 1;
		}
		private void dgwType_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			FrmAddProductType.TypeTableCurrentRowIndex = e.RowIndex;
			bool flag = e.RowIndex != FrmAddProductType.TypeTableNewRowIndex;
			if (flag)
			{
				FrmAddProductType.TypeTableCurrentRowIndex = e.RowIndex;
				this.UpdateFromTypeTableToInputBoxes((DataGridView)sender);
				Product_Manage_Tool_WF.Data.Type thisType = new Product_Manage_Tool_WF.Data.Type(this.txbProductTypeID.Text, this.txbProductTypeName.Text);
				ListProduct productList = Global.ProductList.FindAllProductBelongThisType(thisType);
				FormIO.UpdateProductListToTable(productList, this.dgwProduct);
			}
			else
			{
				FormIO.ClearInputBoxes(this.tlpInput);
				this.dgwProduct.Rows.Clear();
			}
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			FormIO.DisableControls(this.pnlSecondaryControls);
			FormIO.EnableControls(this.pnlPrimaryControls);
			FormIO.EnableTables(this);
			FormIO.UpdateTypeListToTable(Global.TypeList, this.dgwType);
			this.UpdateFromTypeTableToInputBoxes(this.dgwType);
			FrmAddProductType.PreviousButton = (Button)sender;
		}
		private void txbProductTypeID_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = !this.dgwType.Enabled;
			if (!flag)
			{
				FrmAddProductType.SelectingTypeList = Global.TypeList.FindAllProductHaveThisStringInTypeName(this.txbProductTypeName.Text);
				FrmAddProductType.SelectingTypeList = FrmAddProductType.SelectingTypeList.FindAllProductHaveThisStringInTypeID(this.txbProductTypeID.Text);
				FormIO.UpdateTypeListToTable(FrmAddProductType.SelectingTypeList, this.dgwType);
			}
		}
		private void txbProductTypeName_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = !this.dgwType.Enabled;
			if (!flag)
			{
				FrmAddProductType.SelectingTypeList = Global.TypeList.FindAllProductHaveThisStringInTypeName(this.txbProductTypeName.Text);
				FrmAddProductType.SelectingTypeList = FrmAddProductType.SelectingTypeList.FindAllProductHaveThisStringInTypeID(this.txbProductTypeID.Text);
				FormIO.UpdateTypeListToTable(FrmAddProductType.SelectingTypeList, this.dgwType);
			}
		}
		private void btnRefreshTypeTable_Click(object sender, EventArgs e)
		{
			FormIO.ClearInputBoxes(this.tlpInput);
			FormIO.UpdateTypeListToTable(Global.TypeList, this.dgwType);
			FormIO.EnableControls(this.pnlPrimaryControls);
			FormIO.DisableControls(this.pnlSecondaryControls);
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
			this.pnlSecondaryControls = new Panel();
			this.btnCancel = new Button();
			this.btnConfirm = new Button();
			this.pnlPrimaryControls = new Panel();
			this.btnRemove = new Button();
			this.btnEdit = new Button();
			this.btnAddNew = new Button();
			this.tlpInput = new TableLayoutPanel();
			this.btnRefreshTypeTable = new Button();
			this.txbProductTypeName = new TextBox();
			this.lblProductTypeID = new Label();
			this.txbProductTypeID = new TextBox();
			this.lblProductType = new Label();
			this.dgwProduct = new DataGridView();
			this.ClnProductID = new DataGridViewTextBoxColumn();
			this.ClnProductname = new DataGridViewTextBoxColumn();
			this.ClnExpiryDate = new DataGridViewTextBoxColumn();
			this.ClnProductionCompany = new DataGridViewTextBoxColumn();
			this.ClnManufactureYear = new DataGridViewTextBoxColumn();
			this.clnProductTypeID = new DataGridViewTextBoxColumn();
			this.ClnProductType = new DataGridViewTextBoxColumn();
			this.dgwType = new DataGridView();
			this.ClnTypeID = new DataGridViewTextBoxColumn();
			this.ClnTypeName = new DataGridViewTextBoxColumn();
			this.pnlInfoProductTable = new Panel();
			this.lblInfoProductTable = new Label();
			this.pnlInfoInput = new Panel();
			this.lblInfoInput = new Label();
			this.pnlSecondaryControls.SuspendLayout();
			this.pnlPrimaryControls.SuspendLayout();
			this.tlpInput.SuspendLayout();
			((ISupportInitialize)this.dgwProduct).BeginInit();
			((ISupportInitialize)this.dgwType).BeginInit();
			this.pnlInfoProductTable.SuspendLayout();
			this.pnlInfoInput.SuspendLayout();
			base.SuspendLayout();
			this.pnlSecondaryControls.AutoSize = true;
			this.pnlSecondaryControls.Controls.Add(this.btnCancel);
			this.pnlSecondaryControls.Controls.Add(this.btnConfirm);
			this.pnlSecondaryControls.Location = new Point(14, 196);
			this.pnlSecondaryControls.Name = "pnlSecondaryControls";
			this.pnlSecondaryControls.Size = new Size(362, 45);
			this.pnlSecondaryControls.TabIndex = 4;
			this.btnCancel.BackColor = Color.FromArgb(50, 52, 77);
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = Color.Gainsboro;
			this.btnCancel.Location = new Point(247, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(112, 38);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "HỦY";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.btnConfirm.BackColor = Color.FromArgb(50, 52, 77);
			this.btnConfirm.FlatAppearance.BorderSize = 0;
			this.btnConfirm.FlatStyle = FlatStyle.Flat;
			this.btnConfirm.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnConfirm.ForeColor = Color.Gainsboro;
			this.btnConfirm.Location = new Point(129, 4);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new Size(112, 38);
			this.btnConfirm.TabIndex = 3;
			this.btnConfirm.Text = "XÁC NHẬN";
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnConfirm.Click += new EventHandler(this.btnConfirm_Click);
			this.pnlPrimaryControls.AutoSize = true;
			this.pnlPrimaryControls.Controls.Add(this.btnRemove);
			this.pnlPrimaryControls.Controls.Add(this.btnEdit);
			this.pnlPrimaryControls.Controls.Add(this.btnAddNew);
			this.pnlPrimaryControls.Location = new Point(14, 150);
			this.pnlPrimaryControls.Name = "pnlPrimaryControls";
			this.pnlPrimaryControls.Size = new Size(362, 44);
			this.pnlPrimaryControls.TabIndex = 3;
			this.btnRemove.BackColor = Color.FromArgb(50, 52, 77);
			this.btnRemove.FlatAppearance.BorderSize = 0;
			this.btnRemove.FlatStyle = FlatStyle.Flat;
			this.btnRemove.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnRemove.ForeColor = Color.Gainsboro;
			this.btnRemove.Location = new Point(247, 3);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new Size(112, 38);
			this.btnRemove.TabIndex = 2;
			this.btnRemove.Text = "XÓA";
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnRemove.Click += new EventHandler(this.btnRemove_Click);
			this.btnEdit.BackColor = Color.FromArgb(50, 52, 77);
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = FlatStyle.Flat;
			this.btnEdit.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnEdit.ForeColor = Color.Gainsboro;
			this.btnEdit.Location = new Point(129, 3);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new Size(112, 38);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "SỬA";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
			this.btnAddNew.BackColor = Color.FromArgb(50, 52, 77);
			this.btnAddNew.FlatAppearance.BorderSize = 0;
			this.btnAddNew.FlatStyle = FlatStyle.Flat;
			this.btnAddNew.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnAddNew.ForeColor = Color.Gainsboro;
			this.btnAddNew.Location = new Point(11, 3);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new Size(112, 38);
			this.btnAddNew.TabIndex = 0;
			this.btnAddNew.Text = "THÊM MỚI";
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new EventHandler(this.btnAddNew_Click);
			this.tlpInput.ColumnCount = 3;
			this.tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130f));
			this.tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42f));
			this.tlpInput.Controls.Add(this.btnRefreshTypeTable, 2, 0);
			this.tlpInput.Controls.Add(this.txbProductTypeName, 0, 1);
			this.tlpInput.Controls.Add(this.lblProductTypeID, 0, 0);
			this.tlpInput.Controls.Add(this.txbProductTypeID, 1, 0);
			this.tlpInput.Controls.Add(this.lblProductType, 0, 1);
			this.tlpInput.Location = new Point(14, 62);
			this.tlpInput.Name = "tlpInput";
			this.tlpInput.RowCount = 2;
			this.tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tlpInput.Size = new Size(362, 81);
			this.tlpInput.TabIndex = 5;
			this.btnRefreshTypeTable.BackColor = Color.FromArgb(37, 38, 40);
			this.btnRefreshTypeTable.Dock = DockStyle.Fill;
			this.btnRefreshTypeTable.FlatAppearance.BorderSize = 0;
			this.btnRefreshTypeTable.FlatStyle = FlatStyle.Flat;
			this.btnRefreshTypeTable.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnRefreshTypeTable.ForeColor = Color.Gainsboro;
			this.btnRefreshTypeTable.Image = Resources.icons8_synchronize_30;
			this.btnRefreshTypeTable.Location = new Point(323, 3);
			this.btnRefreshTypeTable.Name = "btnRefreshTypeTable";
			this.btnRefreshTypeTable.Size = new Size(36, 34);
			this.btnRefreshTypeTable.TabIndex = 11;
			this.btnRefreshTypeTable.UseVisualStyleBackColor = false;
			this.btnRefreshTypeTable.Click += new EventHandler(this.btnRefreshTypeTable_Click);
			this.tlpInput.SetColumnSpan(this.txbProductTypeName, 2);
			this.txbProductTypeName.Dock = DockStyle.Fill;
			this.txbProductTypeName.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txbProductTypeName.Location = new Point(133, 43);
			this.txbProductTypeName.Name = "txbProductTypeName";
			this.txbProductTypeName.Size = new Size(226, 26);
			this.txbProductTypeName.TabIndex = 14;
			this.txbProductTypeName.KeyUp += new KeyEventHandler(this.txbProductTypeName_KeyUp);
			this.lblProductTypeID.AutoSize = true;
			this.lblProductTypeID.Dock = DockStyle.Fill;
			this.lblProductTypeID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblProductTypeID.ForeColor = Color.WhiteSmoke;
			this.lblProductTypeID.Location = new Point(3, 0);
			this.lblProductTypeID.Name = "lblProductTypeID";
			this.lblProductTypeID.Size = new Size(124, 40);
			this.lblProductTypeID.TabIndex = 7;
			this.lblProductTypeID.Text = "Mã Loại Hàng:";
			this.txbProductTypeID.Dock = DockStyle.Fill;
			this.txbProductTypeID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txbProductTypeID.Location = new Point(133, 3);
			this.txbProductTypeID.Name = "txbProductTypeID";
			this.txbProductTypeID.Size = new Size(184, 26);
			this.txbProductTypeID.TabIndex = 13;
			this.txbProductTypeID.KeyUp += new KeyEventHandler(this.txbProductTypeID_KeyUp);
			this.lblProductType.AutoSize = true;
			this.lblProductType.Dock = DockStyle.Fill;
			this.lblProductType.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblProductType.ForeColor = Color.WhiteSmoke;
			this.lblProductType.Location = new Point(3, 40);
			this.lblProductType.Name = "lblProductType";
			this.lblProductType.Size = new Size(124, 41);
			this.lblProductType.TabIndex = 6;
			this.lblProductType.Text = "Tên Loại Hàng:";
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
			this.dgwProduct.Location = new Point(14, 291);
			this.dgwProduct.Name = "dgwProduct";
			this.dgwProduct.ReadOnly = true;
			this.dgwProduct.Size = new Size(625, 271);
			this.dgwProduct.TabIndex = 6;
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
			this.dgwType.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.dgwType.BackgroundColor = Color.FromArgb(50, 52, 77);
			this.dgwType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwType.Columns.AddRange(new DataGridViewColumn[]
			{
				this.ClnTypeID,
				this.ClnTypeName
			});
			this.dgwType.Location = new Point(382, 62);
			this.dgwType.Name = "dgwType";
			this.dgwType.ReadOnly = true;
			this.dgwType.Size = new Size(257, 180);
			this.dgwType.TabIndex = 7;
			this.dgwType.CellMouseUp += new DataGridViewCellMouseEventHandler(this.dgwType_CellMouseUp);
			this.dgwType.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgwType_RowsAdded);
			this.ClnTypeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ClnTypeID.HeaderText = "Mã Loại Hàng";
			this.ClnTypeID.Name = "ClnTypeID";
			this.ClnTypeID.ReadOnly = true;
			this.ClnTypeID.Width = 91;
			this.ClnTypeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ClnTypeName.HeaderText = "Tên Loại Hàng";
			this.ClnTypeName.Name = "ClnTypeName";
			this.ClnTypeName.ReadOnly = true;
			this.pnlInfoProductTable.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.pnlInfoProductTable.AutoSize = true;
			this.pnlInfoProductTable.Controls.Add(this.lblInfoProductTable);
			this.pnlInfoProductTable.Location = new Point(16, 254);
			this.pnlInfoProductTable.Name = "pnlInfoProductTable";
			this.pnlInfoProductTable.Size = new Size(357, 35);
			this.pnlInfoProductTable.TabIndex = 8;
			this.lblInfoProductTable.Dock = DockStyle.Fill;
			this.lblInfoProductTable.FlatStyle = FlatStyle.Flat;
			this.lblInfoProductTable.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblInfoProductTable.ForeColor = Color.White;
			this.lblInfoProductTable.Location = new Point(0, 0);
			this.lblInfoProductTable.Margin = new Padding(0);
			this.lblInfoProductTable.Name = "lblInfoProductTable";
			this.lblInfoProductTable.Size = new Size(357, 35);
			this.lblInfoProductTable.TabIndex = 0;
			this.lblInfoProductTable.Text = "Danh sách các mặt hàng";
			this.lblInfoProductTable.TextAlign = ContentAlignment.MiddleLeft;
			this.lblInfoProductTable.UseCompatibleTextRendering = true;
			this.pnlInfoInput.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.pnlInfoInput.AutoSize = true;
			this.pnlInfoInput.Controls.Add(this.lblInfoInput);
			this.pnlInfoInput.Location = new Point(14, 7);
			this.pnlInfoInput.Name = "pnlInfoInput";
			this.pnlInfoInput.Size = new Size(625, 49);
			this.pnlInfoInput.TabIndex = 10;
			this.lblInfoInput.Dock = DockStyle.Fill;
			this.lblInfoInput.FlatStyle = FlatStyle.Flat;
			this.lblInfoInput.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblInfoInput.ForeColor = Color.White;
			this.lblInfoInput.Location = new Point(0, 0);
			this.lblInfoInput.Margin = new Padding(0);
			this.lblInfoInput.Name = "lblInfoInput";
			this.lblInfoInput.Size = new Size(625, 49);
			this.lblInfoInput.TabIndex = 0;
			this.lblInfoInput.Text = "Nhấn thêm mới để thêm loại hàng mới. Nhập vào ô mã hoặc tên loại hàng để tìm kiếm. Chọn loại hàng ở bảng để thao tác.";
			this.lblInfoInput.TextAlign = ContentAlignment.MiddleCenter;
			this.lblInfoInput.UseCompatibleTextRendering = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(37, 38, 40);
			base.ClientSize = new Size(653, 574);
			base.Controls.Add(this.pnlInfoInput);
			base.Controls.Add(this.pnlInfoProductTable);
			base.Controls.Add(this.dgwType);
			base.Controls.Add(this.dgwProduct);
			base.Controls.Add(this.tlpInput);
			base.Controls.Add(this.pnlSecondaryControls);
			base.Controls.Add(this.pnlPrimaryControls);
			base.Name = "FrmAddProductType";
			this.Text = "FrmAddProductType";
			base.Load += new EventHandler(this.FrmAddProductType_Load);
			this.pnlSecondaryControls.ResumeLayout(false);
			this.pnlPrimaryControls.ResumeLayout(false);
			this.tlpInput.ResumeLayout(false);
			this.tlpInput.PerformLayout();
			((ISupportInitialize)this.dgwProduct).EndInit();
			((ISupportInitialize)this.dgwType).EndInit();
			this.pnlInfoProductTable.ResumeLayout(false);
			this.pnlInfoInput.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
