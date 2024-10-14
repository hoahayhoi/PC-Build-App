using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.UserControlCustom
{
    public partial class RoundedUserControl : Panel
    {
        public RoundedUserControl()
        {
            InitializeComponent();
        }

        private int _cornerRadius = 20;
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set { _cornerRadius = value; this.Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Tạo GraphicsPath với các góc bo tròn
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, _cornerRadius, _cornerRadius, 180, 90);
            path.AddArc(this.Width - _cornerRadius, 0, _cornerRadius, _cornerRadius, 270, 90);
            path.AddArc(this.Width - _cornerRadius, this.Height - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90);
            path.AddArc(0, this.Height - _cornerRadius, _cornerRadius, _cornerRadius, 90, 90);
            path.CloseFigure();

            // Thiết lập vùng hiển thị của Panel
            this.Region = new Region(path);

            // Vẽ nền cho Panel
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }
        }
    }
}
