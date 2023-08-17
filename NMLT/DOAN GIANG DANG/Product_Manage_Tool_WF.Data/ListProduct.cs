using System;
namespace Product_Manage_Tool_WF.Data
{
	public struct ListProduct
	{
		public Product[] List;
		public int CurrentLength;
		public ListProduct(Product[] _list, int _currentLength)
		{
			this.List = _list;
			this.CurrentLength = _currentLength;
		}
		public void Add(Product newProduct)
		{
			bool flag = this.CurrentLength < 10000;
			if (flag)
			{
				this.List[this.CurrentLength] = newProduct;
				this.CurrentLength++;
			}
		}
		public void Clear()
		{
			this.List = new Product[10000];
			this.CurrentLength = 0;
		}
		public int IndexOf(Product product)
		{
			int result;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].Equals(product);
				if (flag)
				{
					result = i;
					return result;
				}
			}
			result = -1;
			return result;
		}
		public bool IsContain(Product product)
		{
			bool flag = this.IndexOf(product) == -1;
			return !flag;
		}
		public void RemoveAt(int removePosition)
		{
			bool flag = removePosition == 9999;
			if (flag)
			{
				this.List[removePosition] = default(Product);
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
				this.List[this.CurrentLength - 1] = default(Product);
				this.CurrentLength--;
			}
		}
		public void Remove(Product removeProduct)
		{
			int num = this.IndexOf(removeProduct);
			bool flag = num != -1;
			if (flag)
			{
				this.RemoveAt(num);
			}
		}
		public void RemoveAllProductInType(Type type)
		{
			Product[] array = new Product[10000];
			int num = 0;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = !this.List[i].ProductType.Equals(type);
				if (flag)
				{
					array[num] = this.List[i];
					num++;
				}
			}
			this.List = array;
			this.CurrentLength = num;
		}
		public void EditAt(int editingPosition, Product product)
		{
			this.List[editingPosition] = product;
		}
		public void EditTypeForAllProductsHaveType(Type oldType, Type newType)
		{
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].ProductType.Equals(oldType);
				if (flag)
				{
					this.List[i].ProductType = newType;
				}
			}
		}
		public ListProduct FindAllProductHaveThisStringInID(string thisString)
		{
			Product[] array = new Product[10000];
			int num = 0;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].ProductID.Contains(thisString);
				if (flag)
				{
					array[num] = this.List[i];
					num++;
				}
			}
			return new ListProduct(array, num);
		}
		public ListProduct FindAllProductBelongThisType(Type thisType)
		{
			Product[] array = new Product[10000];
			int num = 0;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].ProductType.Equals(thisType);
				if (flag)
				{
					array[num] = this.List[i];
					num++;
				}
			}
			return new ListProduct(array, num);
		}
		public ListProduct FindAllProductHaveThisStringInTypeID(string thisString)
		{
			Product[] array = new Product[10000];
			int num = 0;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].ProductType.TypeID.Contains(thisString);
				if (flag)
				{
					array[num] = this.List[i];
					num++;
				}
			}
			return new ListProduct(array, num);
		}
		public ListProduct FindAllProductHaveThisStringInTypeName(string thisString)
		{
			Product[] array = new Product[10000];
			int num = 0;
			for (int i = 0; i < this.CurrentLength; i++)
			{
				bool flag = this.List[i].ProductType.TypeName.Contains(thisString);
				if (flag)
				{
					array[num] = this.List[i];
					num++;
				}
			}
			return new ListProduct(array, num);
		}
	}
}
