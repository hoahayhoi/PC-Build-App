using App.View.QuanLySanPham;
using App.Controller;
using App.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.View.QuanLyKhachHang
{
    public partial class QuanLyKhachHang : Form
    {
        private CustomMenuStripRender _renderer;
        private CustomPermissions phanQuyen;

        public QuanLyKhachHang()
        {
            InitializeComponent();
            loadCustomers();

            _renderer = new CustomMenuStripRender();
            this.menuStrip1.Renderer = _renderer;
            _renderer.CurrentItem = quảnLýKháchHàngToolStripMenuItem.Text;

            phanQuyen = new CustomPermissions();
            ApplyPermissions();
        }

        private void ApplyPermissions()
        {
            foreach (ToolStripMenuItem item in this.menuStrip1.Items)
            {
                item.Visible = phanQuyen.permissions[frm_Login.CurrentUserRole].Contains(item.Text);
            }
        }

        public void loadCustomers()
        {
            dataGridViewCustomers.DataSource = CustomerController.getListCustomer();
            // Thiết lập để các cột tự động lấp đầy không gian có sẵn
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string address = textBoxAddress.Text;
            if (name == "" || phone == "")
            {
                MessageBox.Show("Vui lòng nhập ít nhất tên và số điện thoại!");
            }
            CustomerDto customer = new CustomerDto(name, email, phone, address);
            
            CustomerController.addCustomer(customer);

            MessageBox.Show("Thêm khách hàng thành công!");
            loadCustomers();

        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một dòng hợp lệ (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu tại chỉ số e.RowIndex
                var row = dataGridViewCustomers.Rows[e.RowIndex];

                // Gán các giá trị từ dòng vào các TextBox
                textBoxId.Text = row.Cells["Id"].Value?.ToString() ?? "";
                textBoxName.Text = row.Cells["Name"].Value?.ToString() ?? ""; // Hoặc sử dụng tên cột bạn đã định nghĩa
                textBoxPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                textBoxEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                textBoxAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(textBoxId.Text);
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string address = textBoxAddress.Text;
            CustomerController.updateCustomer(new CustomerDto(name, email, phone, address), Id);
            MessageBox.Show("Cập nhật thành công!");
            loadCustomers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần xoá!");
            }
            else
            {
                int Id = int.Parse(textBoxId.Text);
                CustomerController.deleteCustomer(Id);
                MessageBox.Show("Xoá thành khách hàng công");
                loadCustomers();
                refresh();
            }

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Main f = new frm_Main();
            f.Show();
            this.Hide();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySanPham.QuanLySanPham f = new QuanLySanPham.QuanLySanPham();
            f.Show();
            this.Hide();
        }
    }
}
