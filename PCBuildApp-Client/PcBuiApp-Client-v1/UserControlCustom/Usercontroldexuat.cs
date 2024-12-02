using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.UserControlCustom
{
	public partial class Usercontroldexuat : UserControl
	{
		public Usercontroldexuat(string cauhinh, double giatien)
		{
			InitializeComponent();
			labeldexuat.Text = $"Cấu Hình Đề Xuất: {cauhinh}";
			labelgiatien.Text = $"Giá Tiền: {giatien}";
		}
	}
}
