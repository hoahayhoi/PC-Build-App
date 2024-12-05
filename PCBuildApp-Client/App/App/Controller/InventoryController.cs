using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    public class InventoryController
    {
        private string connectionString = "Data Source=34.80.167.226,1433;Initial Catalog=PCBuild;User Id=sqlserver;Password=admin;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        // Lấy thông tin tồn kho
        public DataTable GetInventory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT c.Id, c.Name, c.CategoryID, c.Stock as CurrentStock,
                            ISNULL(SUM(po.Quantity), 0) as OnOrder,
                            c.Price as UnitPrice
                            FROM Component c
                            LEFT JOIN PurchaseOrderDetail po ON c.Id = po.ComponentID 
                            LEFT JOIN PurchaseOrder p ON po.PurchaseOrderID = p.Id 
                            AND p.Status = 'New'
                            GROUP BY c.Id, c.Name, c.CategoryID, c.Stock, c.Price";

                using var adapter = new SqlDataAdapter(query, conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Lấy lịch sử nhập kho
        public DataTable GetImportHistory(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT i.Id, c.Name as ComponentName, i.Quantity,
                            i.ImportDate, s.Name as SupplierName, i.PricePerUnit,
                            i.Note, u.Name as ImportedBy
                            FROM InventoryImport i
                            JOIN Component c ON i.ComponentID = c.Id
                            LEFT JOIN Supplier s ON i.SupplierID = s.Id
                            JOIN Users u ON i.ImportedBy = u.Id
                            WHERE (@fromDate IS NULL OR i.ImportDate >= @fromDate)
                            AND (@toDate IS NULL OR i.ImportDate <= @toDate)
                            ORDER BY i.ImportDate DESC";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fromDate", fromDate ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@toDate", toDate ?? (object)DBNull.Value);

                using var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Lấy lịch sử xuất kho
        public DataTable GetExportHistory(DateTime? fromDate = null, DateTime? toDate = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT e.Id, c.Name as ComponentName, e.Quantity,
                            e.ExportDate, od.OrderID, e.Note, u.Name as ExportedBy
                            FROM InventoryExport e
                            JOIN Component c ON e.ComponentID = c.Id
                            LEFT JOIN OrderDetail od ON e.OrderDetailID = od.Id
                            JOIN Users u ON e.ExportedBy = u.Id
                            WHERE (@fromDate IS NULL OR e.ExportDate >= @fromDate)
                            AND (@toDate IS NULL OR e.ExportDate <= @toDate)
                            ORDER BY e.ExportDate DESC";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fromDate", fromDate ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@toDate", toDate ?? (object)DBNull.Value);

                using var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Nhập kho
        public bool ImportInventory(int componentId, int quantity, int supplierId,
            decimal pricePerUnit, string note, int importedBy)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using var transaction = conn.BeginTransaction();

                try
                {
                    // Thêm lịch sử nhập
                    string importQuery = @"INSERT INTO InventoryImport 
                    (ComponentID, Quantity, SupplierID, PricePerUnit, Note, ImportedBy)
                    VALUES (@componentId, @quantity, @supplierId, @pricePerUnit, @note, @importedBy)";

                    using var cmd = new SqlCommand(importQuery, conn, transaction);
                    cmd.Parameters.AddWithValue("@componentId", componentId);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@supplierId", supplierId);
                    cmd.Parameters.AddWithValue("@pricePerUnit", pricePerUnit);
                    cmd.Parameters.AddWithValue("@note", note);
                    cmd.Parameters.AddWithValue("@importedBy", importedBy);
                    cmd.ExecuteNonQuery();

                    // Cập nhật số lượng tồn
                    string updateQuery = @"UPDATE Component 
                    SET Stock = Stock + @quantity
                    WHERE Id = @componentId";

                    cmd.CommandText = updateQuery;
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        // Xuất kho
        public bool ExportInventory(int componentId, int quantity, int? orderDetailId,
            string note, int exportedBy)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using var transaction = conn.BeginTransaction();

                try
                {
                    // Kiểm tra số lượng tồn
                    string checkQuery = "SELECT Stock FROM Component WHERE Id = @componentId";
                    using var cmd = new SqlCommand(checkQuery, conn, transaction);
                    cmd.Parameters.AddWithValue("@componentId", componentId);
                    int currentStock = Convert.ToInt32(cmd.ExecuteScalar());

                    if (currentStock < quantity)
                        throw new Exception("Không đủ số lượng tồn kho");

                    // Thêm lịch sử xuất
                    string exportQuery = @"INSERT INTO InventoryExport 
                    (ComponentID, Quantity, OrderDetailID, Note, ExportedBy)
                    VALUES (@componentId, @quantity, @orderDetailId, @note, @exportedBy)";

                    cmd.CommandText = exportQuery;
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@orderDetailId", orderDetailId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@note", note);
                    cmd.Parameters.AddWithValue("@exportedBy", exportedBy);
                    cmd.ExecuteNonQuery();

                    // Cập nhật số lượng tồn
                    string updateQuery = @"UPDATE Component 
                    SET Stock = Stock - @quantity
                    WHERE Id = @componentId";

                    cmd.CommandText = updateQuery;
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public DataTable GetComponents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Truy vấn để lấy danh sách các component, bao gồm ID và tên
                string query = @"SELECT Id, Name FROM Component";

                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

    }
}
