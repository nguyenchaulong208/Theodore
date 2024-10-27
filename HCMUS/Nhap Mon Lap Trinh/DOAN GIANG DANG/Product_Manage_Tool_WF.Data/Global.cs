using System;
namespace Product_Manage_Tool_WF.Data
{
	public static class Global
	{
		public const int MAX_LIST_LENGTH = 10000;
		public static ListProduct ProductList = new ListProduct(new Product[10000], 0);
		public static ListType TypeList = new ListType(new Type[10000], 0);
	}
}
