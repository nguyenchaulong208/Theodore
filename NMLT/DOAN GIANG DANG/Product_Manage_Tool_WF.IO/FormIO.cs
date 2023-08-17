using Product_Manage_Tool_WF.Data;
using System;
using System.Windows.Forms;
namespace Product_Manage_Tool_WF.IO
{
	public static class FormIO
	{
		public static bool IsAllInputBoxEmpty(TableLayoutPanel inputTableLayoutPanel)
		{
			bool result;
			foreach (object current in inputTableLayoutPanel.Controls)
			{
				bool flag = current is TextBox;
				if (flag)
				{
					TextBox textBox = (TextBox)current;
					bool flag2 = textBox.Text != string.Empty;
					if (flag2)
					{
						result = false;
						return result;
					}
				}
				bool flag3 = current is MaskedTextBox;
				if (flag3)
				{
					MaskedTextBox maskedTextBox = (MaskedTextBox)current;
					bool flag4 = maskedTextBox.Text != string.Empty;
					if (flag4)
					{
						result = false;
						return result;
					}
				}
				bool flag5 = current is ComboBox;
				if (flag5)
				{
					ComboBox comboBox = (ComboBox)current;
					bool flag6 = comboBox.Text != string.Empty;
					if (flag6)
					{
						result = false;
						return result;
					}
				}
			}
			result = true;
			return result;
		}
		public static bool IsAnyInputBoxEmpty(TableLayoutPanel inputTableLayoutPanel)
		{
			bool result;
			foreach (object current in inputTableLayoutPanel.Controls)
			{
				bool flag = current is TextBox;
				if (flag)
				{
					TextBox textBox = (TextBox)current;
					bool flag2 = textBox.Text == string.Empty;
					if (flag2)
					{
						result = true;
						return result;
					}
				}
				bool flag3 = current is MaskedTextBox;
				if (flag3)
				{
					MaskedTextBox maskedTextBox = (MaskedTextBox)current;
					bool flag4 = maskedTextBox.Text == string.Empty;
					if (flag4)
					{
						result = true;
						return result;
					}
				}
				bool flag5 = current is ComboBox;
				if (flag5)
				{
					ComboBox comboBox = (ComboBox)current;
					bool flag6 = comboBox.Text == string.Empty;
					if (flag6)
					{
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}
		public static void EnableInputBoxes(TableLayoutPanel inputTableLayoutPanel)
		{
			foreach (Control control in inputTableLayoutPanel.Controls)
			{
				control.Enabled = true;
			}
		}
		public static void DisableInputBoxes(TableLayoutPanel inputTableLayoutPanel)
		{
			foreach (Control control in inputTableLayoutPanel.Controls)
			{
				bool flag = control is Label;
				if (flag)
				{
					control.Enabled = true;
				}
				else
				{
					control.Enabled = false;
				}
			}
		}
		public static void DisableTables(Form form)
		{
			foreach (Control control in form.Controls)
			{
				bool flag = control is DataGridView;
				if (flag)
				{
					control.Enabled = false;
				}
			}
		}
		public static void EnableTables(Form form)
		{
			foreach (Control control in form.Controls)
			{
				bool flag = control is DataGridView;
				if (flag)
				{
					control.Enabled = true;
				}
			}
		}
		public static void ClearInputBoxes(TableLayoutPanel inputTableLayoutPanel)
		{
			foreach (Control control in inputTableLayoutPanel.Controls)
			{
				bool flag = control is TextBox || control is ComboBox || control is MaskedTextBox;
				if (flag)
				{
					control.Text = string.Empty;
				}
			}
		}
		public static void EnableControls(Panel panel)
		{
			foreach (Control control in panel.Controls)
			{
				control.Enabled = true;
			}
		}
		public static void DisableControls(Panel panel)
		{
			foreach (Control control in panel.Controls)
			{
				control.Enabled = false;
			}
		}
		public static void UpdateProductListToTable(ListProduct productList, DataGridView dataGridView)
		{
			dataGridView.Rows.Clear();
			for (int i = 0; i < productList.CurrentLength; i++)
			{
				dataGridView.Rows.Add(new object[]
				{
					productList.List[i].ProductID,
					productList.List[i].ProductName,
					productList.List[i].ExpiryDate,
					productList.List[i].ProductionCompany,
					productList.List[i].ManufactureYear,
					productList.List[i].ProductType.TypeID,
					productList.List[i].ProductType.TypeName
				});
			}
		}
		public static void UpdateTypeListToTable(ListType typeList, DataGridView dataGridView)
		{
			dataGridView.Rows.Clear();
			for (int i = 0; i < typeList.CurrentLength; i++)
			{
				dataGridView.Rows.Add(new object[]
				{
					typeList.List[i].TypeID,
					typeList.List[i].TypeName
				});
			}
		}
		public static void UpdateFromTypeListToComboBox(ListType typeList, ComboBox comboBox)
		{
			comboBox.Items.Clear();
			bool flag = typeList.CurrentLength > 0;
			if (flag)
			{
				for (int i = 0; i < typeList.CurrentLength; i++)
				{
					comboBox.Items.Add(typeList.List[i].TypeName);
				}
			}
		}
	}
}
