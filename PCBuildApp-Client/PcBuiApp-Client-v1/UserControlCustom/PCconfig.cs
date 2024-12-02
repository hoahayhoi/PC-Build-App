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
	public partial class PCconfig : UserControl
	{
		public PCconfig(int id, string components)
		{
			InitializeComponent();

			labelid.Text = $"ID: {id}";
			labelcauhinh.Text = $"Cấu hình: {components}";
		}
	}
}
