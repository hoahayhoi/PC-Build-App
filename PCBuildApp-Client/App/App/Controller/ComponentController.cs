using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using App.Helper;

namespace App.Controller
{
    public class ComponentController
    {
        // Sử dụng BackendHelper để quản lý kết nối
        // Không cần khai báo connectionString ở đây

        public DataTable GetAllComponents()
        {
            using (SqlConnection conn = BackendHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        c.Id, 
                        c.Name, 
                        cc.CategoryName, 
                        c.Price, 
                        c.Stock, 
                        c.Image,
                        c.CategoryID
                    FROM 
                        Component c
                    LEFT JOIN 
                        CategoryComponent cc ON c.CategoryID = cc.CategoryID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool AddComponent(string name, int categoryId, decimal price, int stock, string image, int? supplierId)
        {
            using (SqlConnection conn = BackendHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO Component (Name, CategoryID, Price, Stock, Image, SupplierID)
                        VALUES (@name, @categoryId, @price, @stock, @image, @supplierId)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 255).Value = name;
                        cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = categoryId;
                        cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
                        cmd.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
                        cmd.Parameters.Add("@image", SqlDbType.NVarChar, 255).Value = image;
                        cmd.Parameters.Add("@supplierId", SqlDbType.Int).Value = (object)supplierId ?? DBNull.Value;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Log lỗi ở đây
                    MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}");
                    return false;
                }
            }
        }

        public bool UpdateComponent(int id, string name, int categoryId, decimal price, int stock, string image, int? supplierId)
        {
            using (SqlConnection conn = BackendHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE Component 
                        SET 
                            Name = @name,
                            CategoryID = @categoryId, 
                            Price = @price,
                            Stock = @stock,
                            Image = @image,
                            SupplierID = @supplierId
                        WHERE 
                            Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 255).Value = name;
                        cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = categoryId;
                        cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
                        cmd.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
                        cmd.Parameters.Add("@image", SqlDbType.NVarChar, 255).Value = image;
                        cmd.Parameters.Add("@supplierId", SqlDbType.Int).Value = (object)supplierId ?? DBNull.Value;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Log lỗi ở đây
                    MessageBox.Show($"Lỗi khi cập nhật sản phẩm: {ex.Message}");
                    return false;
                }
            }
        }

        public bool DeleteComponent(int id)
        {
            using (SqlConnection conn = BackendHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Component WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Log lỗi ở đây
                    MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
