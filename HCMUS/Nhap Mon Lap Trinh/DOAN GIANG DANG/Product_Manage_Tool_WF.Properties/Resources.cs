using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
namespace Product_Manage_Tool_WF.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager resourceMan;
		private static CultureInfo resourceCulture;
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Product_Manage_Tool_WF.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}
		internal static Bitmap icons8_add_tag_50
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icons8-add-tag-50", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}
		internal static Bitmap icons8_search_50
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icons8-search-50", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}
		internal static Bitmap icons8_synchronize_30
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icons8-synchronize-30", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}
		internal static Bitmap Storage_50x50
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Storage_50x50", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}
		internal Resources()
		{
		}
	}
}
