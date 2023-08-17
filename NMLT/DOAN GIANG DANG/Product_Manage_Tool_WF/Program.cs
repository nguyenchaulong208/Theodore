using Product_Manage_Tool_WF.Forms;
using System;
using System.Windows.Forms;
namespace Product_Manage_Tool_WF
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmMain());
		}
	}
}
