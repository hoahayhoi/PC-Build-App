using App.Controller;
using App.Model;
using App.View.QuanLyKhachHang;
using App.View.QuanLySanPham;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;

namespace App
{
    public partial class frm_Main : Form
    {
        private CustomMenuStripRender _renderer;
        private CustomPermissions phanQuyen;
        private LoginUserControl loginControl;

        public frm_Main()
        {
            InitializeComponent();
            _renderer = new CustomMenuStripRender();
            this.menuStrip1.Renderer = _renderer;
            _renderer.CurrentItem = trangChủToolStripMenuItem.Text;

            phanQuyen = new CustomPermissions();
            ApplyPermissions();
            loadCategory();
        }

        private int selectedId; // Biến lưu Id của mục được chọn

        private void loadCategory()
        {
            List<CategoryDto> categories = CategoryController.getListCategory();
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Name";  // Hiển thị thuộc tính Name
            comboBoxCategory.ValueMember = "Id";     // Giá trị là thuộc tính Id

            // Mặc định chọn mục đầu tiên
            if (categories != null && categories.Count > 0)
            {
                comboBoxCategory.SelectedIndex = 0;
                selectedId = (int)comboBoxCategory.SelectedValue; // Lưu Id của mục đầu tiên
            }
        }


        private void ApplyPermissions()
        {
            foreach (ToolStripMenuItem item in this.menuStrip1.Items)
            {
                item.Visible = phanQuyen.permissions[frm_Login.CurrentUserRole].Contains(item.Text);
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySanPham f = new QuanLySanPham();
            f.Show();
            this.Hide();
        }

        private void frm_Main_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang frm = new QuanLyKhachHang();
            frm.Show();
            this.Hide();

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedValue != null)
            {
                try
                {
                    // Chuyển đổi SelectedValue sang int an toàn
                    CategoryDto selectedCategory = (CategoryDto)comboBoxCategory.SelectedItem;
                    int categoryId = selectedCategory.Id;

                    // Lấy danh sách Component theo ID
                    List<ComponentDto> components = ComponentController.getComponentByCategoryId(categoryId);

                    // Gán dữ liệu vào DataGridView
                    dataGridViewComponent.DataSource = components;
                    dataGridViewComponent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục.");
            }
        }


        private Dictionary<int, Tuple<int, string>> listComponent = new Dictionary<int, Tuple<int, string>>();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng đang chọn trong DataGridView
            if (dataGridViewComponent.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewComponent.SelectedRows[0];

                // Lấy ID của component
                int componentId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Lấy tên của component
                string componentName = Convert.ToString(selectedRow.Cells["Name"].Value);  

                // Lấy số lượng tồn kho từ cột "Stock"
                int stockQuantity = Convert.ToInt32(selectedRow.Cells["Stock"].Value);

                // Lấy số lượng từ NumericUpDown
                int quantity = (int)numericUpDownQuantity.Value;

                if (quantity > 0)
                {
                    if (quantity <= stockQuantity)
                    {
                        // Nếu ID đã có trong dictionary, cộng thêm số lượng
                        if (listComponent.ContainsKey(componentId))
                        {
                            var existingItem = listComponent[componentId];
                            listComponent[componentId] = new Tuple<int, string>(existingItem.Item1 + quantity, existingItem.Item2);
                            loadItemOrder(listComponent);
                        }
                        else
                        {
                            listComponent.Add(componentId, new Tuple<int, string>(quantity, componentName));
                            loadItemOrder(listComponent);
                        }

                    }
                    else
                    {
                        // Thông báo nếu số lượng nhập vào vượt quá số lượng tồn kho
                        MessageBox.Show($"Số lượng không thể vượt quá số lượng tồn kho ({stockQuantity})!");
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong DataGridView!");
            }
        }


        private void loadItemOrder(Dictionary<int, Tuple<int, string>> listComponent)
        {
            // Tạo một danh sách để chứa các đối tượng ComponentOrder
            List<ComponentOrder> componentOrders = new List<ComponentOrder>();

            // Lặp qua các phần tử trong dictionary và thêm vào danh sách componentOrders
            foreach (var item in listComponent)
            {
                componentOrders.Add(new ComponentOrder
                {
                    ComponentId = item.Key,
                    ComponentName = item.Value.Item2,
                    Quantity = item.Value.Item1
                });
            }

            // Bind danh sách componentOrders vào DataGridView
            dataGridViewItemOrder.DataSource = componentOrders;

            // Tự động điều chỉnh kích thước cột
            dataGridViewItemOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void clearItemOrder()
        {
            listComponent.Clear();

            dataGridViewItemOrder.DataSource = null;

            dataGridViewItemOrder.Rows.Clear();
        }


        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (listComponent.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi tạo đơn hàng!");
            }
            else
            {
                string name = textBoxCustomerName.Text;
                string phone = textBoxPhone.Text;
                string email = textBoxEmail.Text;
                string address = textBoxAddress.Text;
                if (name == "" || phone == "")
                {
                    MessageBox.Show("Vui lòng nhập ít nhất Tên và số điện thoại của khách hàng!");
                }
                else
                {
                    if (!CustomerController.IsExist(phone))
                    {
                        CustomerDto customerDto = new CustomerDto(name, email, phone, address);
                        CustomerController.addCustomer(customerDto);
                        CustomerDto customer = CustomerController.GetCustomerByPhone(phone);

                        int customerId = customer.Id;
                        // Tính tổng tiền 
                        List<int> componentIds = listComponent.Keys.ToList();
                        decimal totalPrice = ComponentController.CalculateTotalPrice(componentIds);

                        DateTime createdOn = DateTime.Now;
                        DateTime dateCompleted = DateTime.Now;

                        string status = "finish";
                        OrderDto orderDto = new OrderDto(customerId, createdOn, dateCompleted, totalPrice, status, 18);

                        int orderId = OrderController.AddOrder(orderDto);

                        // Duyêt qua từng sản phẩm và tạo ctdh 
                        
                        foreach (var item in listComponent)
                        {
                            int componentId = item.Key;
                            int quantity = item.Value.Item1;
                            string type = "Component";
                            ComponentDto component = ComponentController.getComponentById(componentId);
                            decimal price = component.Price;
                            OrderDetailDto detailDto = new OrderDetailDto(orderId, type, componentId, null, quantity, price);
                            OrderDetailController.addOrderDetail(detailDto);
                        }
                        // Xoá đi ds các mặt hàng đã chọn và thông tin khách hàng
                        clearItemOrder();
                        refresh();
                        MessageBox.Show("Tạo đơn hàng thành công!");
                    }
                    else
                    {
                        // Hiển thị cửa sổ thông báo
                        DialogResult result = MessageBox.Show(
                            $"Đã tồn tại khách hàng sử dụng số điện thoại : {phone} trong hệ thống\nBạn có muốn cập nhật thông tin khách hàng mới nhất và tạo đơn hàng không?",   
                            "Xác nhận",                       
                            MessageBoxButtons.YesNo,           
                            MessageBoxIcon.Question);            

                        // Kiểm tra giá trị được trả về
                        if (result == DialogResult.Yes)
                        {
                            // Người dùng chọn Yes
                            CustomerDto customerDto = new CustomerDto(name, email, phone, address);

                            // Cập nhật khách hàng 
                            CustomerDto existCustomer = CustomerController.GetCustomerByPhone(phone);
                            CustomerController.updateCustomer(customerDto, existCustomer.Id);

                            // Tạo đơn hàng + ctdh
                            int customerId = existCustomer.Id;
                            // Tính tổng tiền 
                            List<int> componentIds = listComponent.Keys.ToList();
                            decimal totalPrice = ComponentController.CalculateTotalPrice(componentIds);

                            DateTime createdOn = DateTime.Now;
                            DateTime dateCompleted = DateTime.Now;

                            string status = "finish";
                            OrderDto orderDto = new OrderDto(customerId, createdOn, dateCompleted, totalPrice, status, 18);

                            int orderId = OrderController.AddOrder(orderDto);

                            MessageBox.Show("Tạo đơn hàng thành công!");
                            // Duyêt qua từng sản phẩm và tạo ctdh 

                            foreach (var item in listComponent)
                            {
                                int componentId = item.Key;
                                int quantity = item.Value.Item1;
                                string type = "Component";
                                ComponentDto component = ComponentController.getComponentById(componentId);
                                decimal price = component.Price;
                                OrderDetailDto detailDto = new OrderDetailDto(orderId, type, componentId, -1, quantity, price);
                                OrderDetailController.addOrderDetail(detailDto);
                            }
                            
                            // Xoá đi ds các mặt hàng đã chọn và thông tin khách hàng
                            clearItemOrder();
                            refresh();
                            MessageBox.Show("Tạo đơn hàng thành công!");
                        }
                        else if (result == DialogResult.No)
                        {
                            // Người dùng chọn No
                            MessageBox.Show("Vui lòng nhập thông tin khách hàng khác!");
                        }
                    }

                }
            }
        }

        private void refresh()
        {
            textBoxCustomerName.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng đang chọn trong DataGridView
            if (dataGridViewItemOrder.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                var selectedRow = dataGridViewItemOrder.SelectedRows[0];

                int componentId = Convert.ToInt32(selectedRow.Cells["ComponentId"].Value);

                if (listComponent.ContainsKey(componentId))
                {
                    listComponent.Remove(componentId);

                    loadItemOrder(listComponent);
                }
                else
                {
                    MessageBox.Show("Component không tồn tại trong danh sách.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong DataGridView!");
            }
        }

    }
}
