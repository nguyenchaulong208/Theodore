using System;
namespace Product_Manage_Tool_WF.Data
{
	public struct Product
	{
		public string ProductID;
		public string ProductName;
		public string ExpiryDate;
		public string ProductionCompany;
		public Type ProductType;
		public int ManufactureYear;
		public Product(string _productID, string _productName, string _expiryDate, string _productionCompany, int _manufactureYear, Type _productType)
		{
			this.ProductID = _productID;
			this.ProductName = _productName;
			this.ExpiryDate = _expiryDate;
			this.ProductionCompany = _productionCompany;
			this.ProductType = _productType;
			this.ManufactureYear = _manufactureYear;
		}
	}
}
