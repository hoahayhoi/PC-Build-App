using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.View
{
    public partial class frm_ChooseAction : Form
    {
        public enum UserAction
        {
            Edit,
            Delete,
            None
        }

        public UserAction SelectedAction { get; private set; } = UserAction.None;

        public frm_ChooseAction()
        {
            InitializeComponent();
        }

        private void btn_Edit_Click_1(object sender, EventArgs e)
        {
            SelectedAction = UserAction.Edit;
            this.Close();
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            SelectedAction = UserAction.Delete;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
