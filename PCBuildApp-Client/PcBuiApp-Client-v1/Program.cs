using PcBuiApp_Client_v1.View;

namespace PcBuiApp_Client_v1
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			//Application.Run(new frm_QuanLyChinh());
            Application.Run(new frm_DangNhap());
        }
	}
}