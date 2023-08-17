using Product_Manage_Tool_WF.Data;
using Product_Manage_Tool_WF.IO;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
namespace Product_Manage_Tool_WF.Forms.Child_Forms
{
	public class FrmAddProduct : Form
	{
		private static int TableNewRowIndex;
		private static int TableCurrentRowIndex;
		private static Button PreviousButton;
		private IContainer components = null;
		private TableLayoutPanel tlpInput;
		private Panel pnlPrimaryControls;
		private Panel pnlSecondaryControls;
		private DataGridView dgwProduct;
		private Label lblProductName;
		private Label lblExpiryDate;
		private Label lblManufactureYear;
		private Label lblProductType;
		private Label lblProductID;
		private Label lblProductionCompany;
		private TextBox txbProductID;
		private TextBox txbProductName;
		private TextBox txbProductionCompany;
		private MaskedTextBox mtbManufactureYear;
		private MaskedTextBox mtbExpiryDate;
		private ComboBox cbbProductTypeName;
		private Button btnRemove;
		private Button btnEdit;
		private Button btnAddNew;
		private Button btnCancel;
		private Button btnConfirm;
		private TextBox txbProductTypeID;
		private Label lblProductTypeID;
		private DataGridViewTextBoxColumn ClnProductID;
		private DataGridViewTextBoxColumn ClnProductname;
		private DataGridViewTextBoxColumn ClnExpiryDate;
		private DataGridViewTextBoxColumn ClnProductionCompany;
		private DataGridViewTextBoxColumn ClnManufactureYear;
		private DataGridViewTextBoxColumn clnProductTypeID;
		private DataGridViewTextBoxColumn ClnProductType;
		private bool IsAllTextBoxValidInput()
		{
			bool flag = FormIO.IsAnyInputBoxEmpty(this.tlpInput);
			bool result;
			if (flag)
			{
				MessageBox.Show(this, "Có trường dữ liệu trống. Xin nhập lại!", "Lỗi Nhập Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			else
			{
				DateTime dateTime;
				try
				{
					dateTime = DateTime.ParseExact(this.mtbExpiryDate.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
				}
				catch (Exception)
				{
					MessageBox.Show(this, "Dữ liệu Hạn Dùng nhập sai kiểu dữ liệu. Xin nhập lại! (dd/MM/yyyy)", "Lỗi Nhập Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = false;
					return result;
				}
				int num;
				bool flag2 = !int.TryParse(this.mtbManufactureYear.Text, out num);
				if (flag2)
				{
					MessageBox.Show(this, "Dữ liệu Năm Sản Xuất nhập sai kiểu dữ liệu. Xin nhập lại!", "Lỗi Nhập Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = false;
				}
				else
				{
					bool flag3 = dateTime.Year < num;
					if (flag3)
					{
						MessageBox.Show(this, "Năm của hạn dùng sản phẩm phải lớn hơn năm sản xuất. Xin nhập lại!", "Lỗi Nhập Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			return result;
		}
		private void UpdateFromTableToInputBoxes(DataGridView dataGridView)
		{
			bool flag = dataGridView.SelectedCells.Count > 0;
			if (flag)
			{
				DataGridViewRow dataGridViewRow = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
				bool flag2 = !dataGridViewRow.IsNewRow;
				if (flag2)
				{
					this.txbProductID.Text = dataGridViewRow.Cells[0].Value.ToString();
					this.txbProductName.Text = dataGridViewRow.Cells[1].Value.ToString();
					this.mtbExpiryDate.Text = dataGridViewRow.Cells[2].Value.ToString();
					this.txbProductionCompany.Text = dataGridViewRow.Cells[3].Value.ToString();
					this.mtbManufactureYear.Text = dataGridViewRow.Cells[4].Value.ToString();
					this.txbProductTypeID.Text = dataGridViewRow.Cells[5].Value.ToString();
					this.cbbProductTypeName.Text = dataGridViewRow.Cells[6].Value.ToString();
				}
			}
		}
		private void AddNew(Product product)
		{
			bool flag = !Global.TypeList.IsContains(product.ProductType);
			if (flag)
			{
				Global.TypeList.Add(product.ProductType);
			}
			Global.ProductList.Add(product);
			FormIO.UpdateProductListToTable(Global.ProductList, this.dgwProduct);
			this.dgwProduct.Rows[FrmAddProduct.TableNewRowIndex - 1].Selected = true;
			this.dgwProduct.CurrentCell = this.dgwProduct.Rows[FrmAddProduct.TableNewRowIndex - 1].Cells[0];
		}
		private void Edit(Product product)
		{
			Global.ProductList.EditAt(FrmAddProduct.TableCurrentRowIndex, product);
			FormIO.UpdateProductListToTable(Global.ProductList, this.dgwProduct);
			this.dgwProduct.Rows[FrmAddProduct.TableCurrentRowIndex].Selected = true;
			this.dgwProduct.CurrentCell = this.dgwProduct.Rows[FrmAddProduct.TableCurrentRowIndex].Cells[0];
		}
		public FrmAddProduct()
		{
			this.InitializeComponent();
		}
		private void FrmAddProduct_Load(object sender, EventArgs e)
		{
			this.cbbProductTypeName.DropDownStyle = ComboBoxStyle.DropDown;
			FormIO.DisableInputBoxes(this.tlpInput);
			FormIO.EnableControls(this.pnlPrimaryControls);
			FormIO.DisableControls(this.pnlSecondaryControls);
			bool flag = Global.ProductList.CurrentLength > 0;
			if (flag)
			{
				FormIO.UpdateProductListToTable(Global.ProductList, this.dgwProduct);
			}
			bool flag2 = Global.TypeList.CurrentLength > 0;
			if (flag2)
			{
				FormIO.UpdateFromTypeListToComboBox(Global.TypeList, this.cbbProductTypeName);
			}
			bool flag3 = this.dgwProduct != null;
			if (flag3)
			{
				this.UpdateFromTableToInputBoxes(this.dgwProduct);
			}
		}
		private void txbProductID_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txbProductName.Focus();
			}
		}
		private void txbProductName_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.mtbExpiryDate.Focus();
			}
		}
		private void mtbExpiryDate_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txbProductionCompany.Focus();
			}
		}
		private void txbProductionCompany_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.mtbManufactureYear.Focus();
			}
		}
		private void mtbManufactureYear_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.cbbProductTypeName.Focus();
			}
		}
		private void cbbProductType_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.btnConfirm.Focus();
			}
		}
		private void btnAddNew_Click(object sender, EventArgs e)
		{
			bool flag = Global.TypeList.CurrentLength == 0;
			if (flag)
			{
				MessageBox.Show(this, "Danh sách loại hàng đang trống. Xin nhấn thẻ Quản Lý Loại Hàng để nhập loại hàng trước khi nhập mặt hàng.", "Danh Sách Loại Hàng Trống", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				FrmAddProduct.PreviousButton = (Button)sender;
				bool flag2 = Global.TypeList.CurrentLength == 0;
				if (flag2)
				{
					MessageBox.Show(this, "Danh sách loại hàng hiện đang trống. Xin chọn thẻ Quản Lý Loại Hàng để nhập loại hàng trước khi nhập mặt hàng.", "Danh Sách Loại Hàng Trống", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					FormIO.EnableInputBoxes(this.tlpInput);
					FormIO.ClearInputBoxes(this.tlpInput);
					this.cbbProductTypeName.DropDownStyle = ComboBoxStyle.DropDownList;
					this.txbProductID.Focus();
					FormIO.DisableControls(this.pnlPrimaryControls);
					FormIO.EnableControls(this.pnlSecondaryControls);
				}
			}
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			FrmAddProduct.PreviousButton = (Button)sender;
			bool flag = FormIO.IsAllInputBoxEmpty(this.tlpInput);
			if (flag)
			{
				MessageBox.Show(this, "Bạn chưa chọn dữ liệu từ bảng hoặc bạn đã chọn dữ liệu trống. Xin chọn lại!", "Lỗi Dữ Liệu Trống", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				FormIO.EnableInputBoxes(this.tlpInput);
				this.cbbProductTypeName.DropDownStyle = ComboBoxStyle.DropDownList;
				FormIO.DisableControls(this.pnlPrimaryControls);
				FormIO.EnableControls(this.pnlSecondaryControls);
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			FrmAddProduct.PreviousButton = (Button)sender;
			bool flag = FormIO.IsAllInputBoxEmpty(this.tlpInput);
			if (flag)
			{
				MessageBox.Show(this, "Bạn chưa chọn dữ liệu từ bảng hoặc bạn đã chọn dữ liệu trống. Xin chọn lại!", "Lỗi Dữ Liệu Trống", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				bool flag2 = Global.ProductList.CurrentLength == 0;
				if (flag2)
				{
					MessageBox.Show(this, "Không có dữ liệu để xóa. Xin nhập dữ liệu!", "Lỗi Không Có Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					DialogResult dialogResult = MessageBox.Show(this, string.Concat(new string[]
					{
						"Bạn có chắc chắn muốn xóa dữ liệu sau:\nMã Hàng : ",
						this.dgwProduct.Rows[FrmAddProduct.TableCurrentRowIndex].Cells[0].Value.ToString(),
						"\nTên Hàng: ",
						this.dgwProduct.Rows[FrmAddProduct.TableCurrentRowIndex].Cells[1].Value.ToString(),
						"\nHạn Dùng: ",
						this.dgwProduct.Rows[FrmAddProduct.TableCurrentRowIndex].Cells[2].Value.ToString(),
						"\nCông Ty Sản Xuất: ",
						this.dgwProduct.Rows[FrmAddProduct.TableCurrentRowIndex].Cells[3].Value.ToString(),
						"\nNăm Sản Xuất: ",
						this.dgwProduct.Rows[FrmAddProduct.TableCurrentRowIndex].Cells[4].Value.ToString(),
						"\nLoại Hàng: ",
						this.dgwProduct.Rows[FrmAddProduct.TableCurrentRowIndex].Cells[5].Value.ToString()
					}), "Xác nhận xóa lô hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
					bool flag3 = dialogResult == DialogResult.Yes;
					if (flag3)
					{
						Global.ProductList.RemoveAt(FrmAddProduct.TableCurrentRowIndex);
						FormIO.UpdateProductListToTable(Global.ProductList, this.dgwProduct);
					}
				}
			}
		}
		private void btnConfirm_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.btnConfirm_Click(this, new EventArgs());
			}
		}
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			bool flag = this.IsAllTextBoxValidInput();
			if (flag)
			{
				Product product = new Product(this.txbProductID.Text, this.txbProductName.Text, this.mtbExpiryDate.Text, this.txbProductionCompany.Text, int.Parse(this.mtbManufactureYear.Text), new Product_Manage_Tool_WF.Data.Type(this.txbProductTypeID.Text, this.cbbProductTypeName.Text));
				bool flag2 = Global.ProductList.IsContain(product);
				if (flag2)
				{
					MessageBox.Show(this, "Lô hàng này đã tồn tại", "Lô hàng đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					bool flag3 = FrmAddProduct.PreviousButton == this.btnAddNew;
					if (flag3)
					{
						this.AddNew(product);
					}
					else
					{
						bool flag4 = FrmAddProduct.PreviousButton == this.btnEdit;
						if (flag4)
						{
							this.Edit(product);
						}
					}
					this.cbbProductTypeName.DropDownStyle = ComboBoxStyle.DropDownList;
					FormIO.DisableInputBoxes(this.tlpInput);
					FormIO.EnableControls(this.pnlPrimaryControls);
					FormIO.DisableControls(this.pnlSecondaryControls);
				}
			}
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			FormIO.UpdateProductListToTable(Global.ProductList, this.dgwProduct);
			this.cbbProductTypeName.DropDownStyle = ComboBoxStyle.DropDown;
			FormIO.DisableInputBoxes(this.tlpInput);
			FormIO.EnableControls(this.pnlPrimaryControls);
			FormIO.DisableControls(this.pnlSecondaryControls);
		}
		private void cbbProductType_Click(object sender, EventArgs e)
		{
			FormIO.UpdateFromTypeListToComboBox(Global.TypeList, this.cbbProductTypeName);
		}
		private void dgwProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			FrmAddProduct.TableNewRowIndex = e.RowIndex + 1;
		}
		private void cbbProductType_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.cbbProductTypeName.SelectedIndex != -1;
			if (flag)
			{
				int num = Global.TypeList.IndexOfTypeName(this.cbbProductTypeName.Text);
				this.txbProductTypeID.Text = Global.TypeList.List[num].TypeID;
			}
		}
		private void dgwProduct_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = e.RowIndex != FrmAddProduct.TableNewRowIndex;
			if (flag)
			{
				FrmAddProduct.TableCurrentRowIndex = e.RowIndex;
				this.UpdateFromTableToInputBoxes((DataGridView)sender);
			}
			else
			{
				FormIO.ClearInputBoxes(this.tlpInput);
			}
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
			this.tlpInput = new TableLayoutPanel();
			this.txbProductTypeID = new TextBox();
			this.lblProductTypeID = new Label();
			this.lblProductName = new Label();
			this.lblExpiryDate = new Label();
			this.lblManufactureYear = new Label();
			this.lblProductType = new Label();
			this.lblProductID = new Label();
			this.lblProductionCompany = new Label();
			this.txbProductID = new TextBox();
			this.txbProductName = new TextBox();
			this.txbProductionCompany = new TextBox();
			this.mtbManufactureYear = new MaskedTextBox();
			this.mtbExpiryDate = new MaskedTextBox();
			this.cbbProductTypeName = new ComboBox();
			this.pnlPrimaryControls = new Panel();
			this.btnRemove = new Button();
			this.btnEdit = new Button();
			this.btnAddNew = new Button();
			this.pnlSecondaryControls = new Panel();
			this.btnCancel = new Button();
			this.btnConfirm = new Button();
			this.dgwProduct = new DataGridView();
			this.ClnProductID = new DataGridViewTextBoxColumn();
			this.ClnProductname = new DataGridViewTextBoxColumn();
			this.ClnExpiryDate = new DataGridViewTextBoxColumn();
			this.ClnProductionCompany = new DataGridViewTextBoxColumn();
			this.ClnManufactureYear = new DataGridViewTextBoxColumn();
			this.clnProductTypeID = new DataGridViewTextBoxColumn();
			this.ClnProductType = new DataGridViewTextBoxColumn();
			this.tlpInput.SuspendLayout();
			this.pnlPrimaryControls.SuspendLayout();
			this.pnlSecondaryControls.SuspendLayout();
			((ISupportInitialize)this.dgwProduct).BeginInit();
			base.SuspendLayout();
			this.tlpInput.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.tlpInput.ColumnCount = 4;
			this.tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95f));
			this.tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150f));
			this.tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tlpInput.Controls.Add(this.txbProductTypeID, 3, 5);
			this.tlpInput.Controls.Add(this.lblProductTypeID, 2, 5);
			this.tlpInput.Controls.Add(this.lblProductName, 0, 2);
			this.tlpInput.Controls.Add(this.lblExpiryDate, 0, 3);
			this.tlpInput.Controls.Add(this.lblManufactureYear, 2, 2);
			this.tlpInput.Controls.Add(this.lblProductType, 2, 3);
			this.tlpInput.Controls.Add(this.lblProductID, 0, 1);
			this.tlpInput.Controls.Add(this.lblProductionCompany, 2, 1);
			this.tlpInput.Controls.Add(this.txbProductID, 1, 1);
			this.tlpInput.Controls.Add(this.txbProductName, 1, 2);
			this.tlpInput.Controls.Add(this.txbProductionCompany, 3, 1);
			this.tlpInput.Controls.Add(this.mtbManufactureYear, 3, 2);
			this.tlpInput.Controls.Add(this.mtbExpiryDate, 1, 3);
			this.tlpInput.Controls.Add(this.cbbProductTypeName, 3, 3);
			this.tlpInput.Location = new Point(16, 9);
			this.tlpInput.Name = "tlpInput";
			this.tlpInput.RowCount = 6;
			this.tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 2f));
			this.tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 24f));
			this.tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 24f));
			this.tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 24f));
			this.tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 2f));
			this.tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 24f));
			this.tlpInput.Size = new Size(730, 148);
			this.tlpInput.TabIndex = 0;
			this.txbProductTypeID.Dock = DockStyle.Fill;
			this.txbProductTypeID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txbProductTypeID.Location = new Point(490, 112);
			this.txbProductTypeID.Name = "txbProductTypeID";
			this.txbProductTypeID.ReadOnly = true;
			this.txbProductTypeID.Size = new Size(237, 26);
			this.txbProductTypeID.TabIndex = 9;
			this.txbProductTypeID.TextAlign = HorizontalAlignment.Right;
			this.lblProductTypeID.AutoSize = true;
			this.lblProductTypeID.Dock = DockStyle.Fill;
			this.lblProductTypeID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblProductTypeID.ForeColor = Color.WhiteSmoke;
			this.lblProductTypeID.Location = new Point(340, 109);
			this.lblProductTypeID.Name = "lblProductTypeID";
			this.lblProductTypeID.Size = new Size(144, 39);
			this.lblProductTypeID.TabIndex = 6;
			this.lblProductTypeID.Text = "Mã Loại Hàng:";
			this.lblProductTypeID.TextAlign = ContentAlignment.MiddleLeft;
			this.lblProductName.AutoSize = true;
			this.lblProductName.Dock = DockStyle.Fill;
			this.lblProductName.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblProductName.ForeColor = Color.WhiteSmoke;
			this.lblProductName.Location = new Point(3, 37);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new Size(89, 35);
			this.lblProductName.TabIndex = 1;
			this.lblProductName.Text = "Tên Hàng:";
			this.lblProductName.TextAlign = ContentAlignment.MiddleLeft;
			this.lblExpiryDate.AutoSize = true;
			this.lblExpiryDate.Dock = DockStyle.Fill;
			this.lblExpiryDate.Enabled = false;
			this.lblExpiryDate.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblExpiryDate.ForeColor = Color.WhiteSmoke;
			this.lblExpiryDate.Location = new Point(3, 72);
			this.lblExpiryDate.Name = "lblExpiryDate";
			this.lblExpiryDate.Size = new Size(89, 35);
			this.lblExpiryDate.TabIndex = 2;
			this.lblExpiryDate.Text = "Hạn Dùng";
			this.lblExpiryDate.TextAlign = ContentAlignment.MiddleLeft;
			this.lblManufactureYear.AutoSize = true;
			this.lblManufactureYear.Dock = DockStyle.Fill;
			this.lblManufactureYear.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblManufactureYear.ForeColor = Color.WhiteSmoke;
			this.lblManufactureYear.Location = new Point(340, 37);
			this.lblManufactureYear.Name = "lblManufactureYear";
			this.lblManufactureYear.Size = new Size(144, 35);
			this.lblManufactureYear.TabIndex = 4;
			this.lblManufactureYear.Text = "Năm Sản Xuất:";
			this.lblManufactureYear.TextAlign = ContentAlignment.MiddleLeft;
			this.lblProductType.AutoSize = true;
			this.lblProductType.Dock = DockStyle.Fill;
			this.lblProductType.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblProductType.ForeColor = Color.WhiteSmoke;
			this.lblProductType.Location = new Point(340, 72);
			this.lblProductType.Name = "lblProductType";
			this.lblProductType.Size = new Size(144, 35);
			this.lblProductType.TabIndex = 5;
			this.lblProductType.Text = "Loại Hàng:";
			this.lblProductType.TextAlign = ContentAlignment.MiddleLeft;
			this.lblProductID.AutoSize = true;
			this.lblProductID.Dock = DockStyle.Fill;
			this.lblProductID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblProductID.ForeColor = Color.WhiteSmoke;
			this.lblProductID.Location = new Point(3, 2);
			this.lblProductID.Name = "lblProductID";
			this.lblProductID.Size = new Size(89, 35);
			this.lblProductID.TabIndex = 0;
			this.lblProductID.Text = "Mã Hàng:";
			this.lblProductID.TextAlign = ContentAlignment.MiddleLeft;
			this.lblProductionCompany.AutoSize = true;
			this.lblProductionCompany.Dock = DockStyle.Fill;
			this.lblProductionCompany.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblProductionCompany.ForeColor = Color.WhiteSmoke;
			this.lblProductionCompany.Location = new Point(340, 2);
			this.lblProductionCompany.Name = "lblProductionCompany";
			this.lblProductionCompany.Size = new Size(144, 35);
			this.lblProductionCompany.TabIndex = 3;
			this.lblProductionCompany.Text = "Công Ty Sản Xuất:";
			this.lblProductionCompany.TextAlign = ContentAlignment.MiddleLeft;
			this.txbProductID.Dock = DockStyle.Fill;
			this.txbProductID.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txbProductID.Location = new Point(98, 5);
			this.txbProductID.Name = "txbProductID";
			this.txbProductID.Size = new Size(236, 26);
			this.txbProductID.TabIndex = 6;
			this.txbProductID.TextAlign = HorizontalAlignment.Right;
			this.txbProductID.KeyDown += new KeyEventHandler(this.txbProductID_KeyDown);
			this.txbProductName.Dock = DockStyle.Fill;
			this.txbProductName.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txbProductName.Location = new Point(98, 40);
			this.txbProductName.Name = "txbProductName";
			this.txbProductName.Size = new Size(236, 26);
			this.txbProductName.TabIndex = 7;
			this.txbProductName.TextAlign = HorizontalAlignment.Right;
			this.txbProductName.KeyDown += new KeyEventHandler(this.txbProductName_KeyDown);
			this.txbProductionCompany.Dock = DockStyle.Fill;
			this.txbProductionCompany.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txbProductionCompany.Location = new Point(490, 5);
			this.txbProductionCompany.Name = "txbProductionCompany";
			this.txbProductionCompany.Size = new Size(237, 26);
			this.txbProductionCompany.TabIndex = 8;
			this.txbProductionCompany.TextAlign = HorizontalAlignment.Right;
			this.txbProductionCompany.KeyDown += new KeyEventHandler(this.txbProductionCompany_KeyDown);
			this.mtbManufactureYear.Dock = DockStyle.Fill;
			this.mtbManufactureYear.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.mtbManufactureYear.Location = new Point(490, 40);
			this.mtbManufactureYear.Mask = "0000";
			this.mtbManufactureYear.Name = "mtbManufactureYear";
			this.mtbManufactureYear.Size = new Size(237, 26);
			this.mtbManufactureYear.TabIndex = 9;
			this.mtbManufactureYear.TextAlign = HorizontalAlignment.Right;
			this.mtbManufactureYear.ValidatingType = typeof(int);
			this.mtbManufactureYear.KeyDown += new KeyEventHandler(this.mtbManufactureYear_KeyDown);
			this.mtbExpiryDate.Dock = DockStyle.Fill;
			this.mtbExpiryDate.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.mtbExpiryDate.Location = new Point(98, 75);
			this.mtbExpiryDate.Mask = "00/00/0000";
			this.mtbExpiryDate.Name = "mtbExpiryDate";
			this.mtbExpiryDate.Size = new Size(236, 26);
			this.mtbExpiryDate.TabIndex = 10;
			this.mtbExpiryDate.TextAlign = HorizontalAlignment.Right;
			this.mtbExpiryDate.ValidatingType = typeof(DateTime);
			this.mtbExpiryDate.KeyDown += new KeyEventHandler(this.mtbExpiryDate_KeyDown);
			this.cbbProductTypeName.Dock = DockStyle.Fill;
			this.cbbProductTypeName.FlatStyle = FlatStyle.Flat;
			this.cbbProductTypeName.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbbProductTypeName.FormattingEnabled = true;
			this.cbbProductTypeName.Location = new Point(490, 75);
			this.cbbProductTypeName.Name = "cbbProductTypeName";
			this.cbbProductTypeName.Size = new Size(237, 28);
			this.cbbProductTypeName.TabIndex = 11;
			this.cbbProductTypeName.SelectedIndexChanged += new EventHandler(this.cbbProductType_SelectedIndexChanged);
			this.cbbProductTypeName.Click += new EventHandler(this.cbbProductType_Click);
			this.cbbProductTypeName.KeyDown += new KeyEventHandler(this.cbbProductType_KeyDown);
			this.pnlPrimaryControls.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pnlPrimaryControls.AutoSize = true;
			this.pnlPrimaryControls.Controls.Add(this.btnRemove);
			this.pnlPrimaryControls.Controls.Add(this.btnEdit);
			this.pnlPrimaryControls.Controls.Add(this.btnAddNew);
			this.pnlPrimaryControls.Location = new Point(16, 163);
			this.pnlPrimaryControls.Name = "pnlPrimaryControls";
			this.pnlPrimaryControls.Size = new Size(730, 44);
			this.pnlPrimaryControls.TabIndex = 1;
			this.btnRemove.BackColor = Color.FromArgb(50, 52, 77);
			this.btnRemove.FlatAppearance.BorderSize = 0;
			this.btnRemove.FlatStyle = FlatStyle.Flat;
			this.btnRemove.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnRemove.ForeColor = Color.Gainsboro;
			this.btnRemove.Location = new Point(615, 1);
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
			this.btnEdit.Location = new Point(498, 1);
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
			this.btnAddNew.Location = new Point(380, 1);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new Size(112, 38);
			this.btnAddNew.TabIndex = 0;
			this.btnAddNew.Text = "THÊM MỚI";
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new EventHandler(this.btnAddNew_Click);
			this.pnlSecondaryControls.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pnlSecondaryControls.AutoSize = true;
			this.pnlSecondaryControls.Controls.Add(this.btnCancel);
			this.pnlSecondaryControls.Controls.Add(this.btnConfirm);
			this.pnlSecondaryControls.Location = new Point(16, 209);
			this.pnlSecondaryControls.Name = "pnlSecondaryControls";
			this.pnlSecondaryControls.Size = new Size(730, 45);
			this.pnlSecondaryControls.TabIndex = 2;
			this.btnCancel.BackColor = Color.FromArgb(50, 52, 77);
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = Color.Gainsboro;
			this.btnCancel.Location = new Point(615, 4);
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
			this.btnConfirm.Location = new Point(498, 4);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new Size(112, 38);
			this.btnConfirm.TabIndex = 3;
			this.btnConfirm.Text = "XÁC NHẬN";
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnConfirm.Click += new EventHandler(this.btnConfirm_Click);
			this.btnConfirm.KeyDown += new KeyEventHandler(this.btnConfirm_KeyDown);
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
			this.dgwProduct.Location = new Point(16, 257);
			this.dgwProduct.Name = "dgwProduct";
			this.dgwProduct.ReadOnly = true;
			this.dgwProduct.Size = new Size(730, 262);
			this.dgwProduct.TabIndex = 3;
			this.dgwProduct.CellMouseUp += new DataGridViewCellMouseEventHandler(this.dgwProduct_CellMouseUp);
			this.dgwProduct.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgwProduct_RowsAdded);
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
			base.Controls.Add(this.pnlSecondaryControls);
			base.Controls.Add(this.pnlPrimaryControls);
			base.Controls.Add(this.tlpInput);
			base.Name = "FrmAddProduct";
			this.Text = "FrmAddProduct";
			base.Load += new EventHandler(this.FrmAddProduct_Load);
			this.tlpInput.ResumeLayout(false);
			this.tlpInput.PerformLayout();
			this.pnlPrimaryControls.ResumeLayout(false);
			this.pnlSecondaryControls.ResumeLayout(false);
			((ISupportInitialize)this.dgwProduct).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
