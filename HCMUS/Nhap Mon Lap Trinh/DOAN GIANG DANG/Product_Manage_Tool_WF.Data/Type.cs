using System;
namespace Product_Manage_Tool_WF.Data
{
	public struct Type
	{
		public string TypeID;
		public string TypeName;
		public Type(string _typeID, string _typeName)
		{
			this.TypeID = _typeID;
			this.TypeName = _typeName;
		}
	}
}
