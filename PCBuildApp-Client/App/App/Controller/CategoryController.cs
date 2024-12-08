using App.Model;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using App.Helper;

namespace App.Controller
{
    public class CategoryController
    {
        public DataTable GetAllCategories()
        {
            using (SqlConnection conn = BackendHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT CategoryID, CategoryName FROM CategoryComponent";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static List<CategoryDto> getListCategory()
        {
            using (var db = new DatabaseDataContext(Properties.Settings.Default.PCBuildConnectionString))
            {
                // Lấy danh sách khách hàng từ bảng Customer
                var list = from category in db.CategoryComponents // Giả sử bảng tên là Customers
                           select new CategoryDto
                           {
                               Id = category.CategoryID,
                               Name = category.CategoryName
                           };

                // Chuyển đổi kết quả thành một List và trả về
                return list.ToList();
            }
        }
    }
}
