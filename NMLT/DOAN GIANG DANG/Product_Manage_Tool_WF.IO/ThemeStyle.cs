using System;
using System.Drawing;
namespace Product_Manage_Tool_WF.IO
{
	public static class ThemeStyle
	{
		public static string[] ColorList = new string[]
		{
			"#3F51B5",
			"#009688",
			"#607D8B",
			"#2196F3",
			"#EA676C",
			"#5978BB",
			"#018790",
			"#0E3441",
			"#721D47",
			"#126881",
			"#364D5B",
			"#0094BC",
			"#B71C46"
		};
		public static readonly Color INACTIVE_BTN_BACK_GROUND_COLOR = Color.FromArgb(50, 52, 77);
		public static readonly Color INACTIVE_BTN_FORE_COLOR = Color.Gainsboro;
		public static readonly Font ACTIVE_BTN_FONT_STYLE = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
		public static readonly Font INACTIVE_BTN_FONT_STYLE = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
	}
}
