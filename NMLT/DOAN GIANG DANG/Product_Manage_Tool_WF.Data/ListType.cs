using System;
namespace Product_Manage_Tool_WF.Data
{
	public struct ListType
	{
		public Type[] List;
		public int CurrentLength;
		public ListType(Type[] _list, int _currentLength)
		{
			this.List = _list;
			this.CurrentLength = _currentLength;
		}
		public void Add(Type newType)
		{
			bool flag = this.CurrentLength < 10000;
			if (flag)
			{
				this.List[this.CurrentLength] = newType;
				this.CurrentLength++;
			}
		}
		public void RemoveAt(int removePosition)
		{
			bool flag = removePosition == 9999;
			if (flag)
			{
				this.List[removePosition] = default(Type);
				this.CurrentLength--;
			}
			else
			{
				for (int i = removePosition; i < this.CurrentLength - 1; i++)
				{
					bool flag2 = i + 1 <= 10000;
					if (flag2)
					{
						this.List[i] = this.List[i + 1];
					}
				}
				this.List[this.CurrentLength - 1] = default(Type);
				this.CurrentLength--;
			}
		}
		public int IndexOf(Type type)
		{
			int result;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].Equals(type);
				if (flag)
				{
					result = i;
					return result;
				}
			}
			result = -1;
			return result;
		}
		public int IndexOfTypeName(string thisTypeName)
		{
			int result;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].TypeName.Equals(thisTypeName);
				if (flag)
				{
					result = i;
					return result;
				}
			}
			result = -1;
			return result;
		}
		public int IndexOfTypeID(string thisTypeID)
		{
			int result;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].TypeName.Equals(thisTypeID);
				if (flag)
				{
					result = i;
					return result;
				}
			}
			result = -1;
			return result;
		}
		public bool IsContainsTypeID(string typeID)
		{
			bool result;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].TypeID == typeID;
				if (flag)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
		public bool IsContainsTypeName(string typeName)
		{
			bool result;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].TypeName == typeName;
				if (flag)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
		public bool IsContains(Type type)
		{
			bool result;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].Equals(type);
				if (flag)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
		public void Remove(Type removeType)
		{
			int num = this.IndexOf(removeType);
			bool flag = num != -1;
			if (flag)
			{
				this.RemoveAt(num);
			}
		}
		public void Edit(Type oldType, Type newType)
		{
			bool flag = this.IsContains(oldType);
			if (flag)
			{
				this.List[this.IndexOf(oldType)] = newType;
			}
		}
		public void Clear()
		{
			this.List = new Type[10000];
			this.CurrentLength = 0;
		}
		public ListType FindAllProductHaveThisStringInTypeID(string thisString)
		{
			Type[] array = new Type[10000];
			int num = 0;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].TypeID.Contains(thisString);
				if (flag)
				{
					array[num] = this.List[i];
					num++;
				}
			}
			return new ListType(array, num);
		}
		public ListType FindAllProductHaveThisStringInTypeName(string thisString)
		{
			Type[] array = new Type[10000];
			int num = 0;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].TypeName.Contains(thisString);
				if (flag)
				{
					array[num] = this.List[i];
					num++;
				}
			}
			return new ListType(array, num);
		}
	}
}
