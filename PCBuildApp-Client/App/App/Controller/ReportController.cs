using System;
using System.Data;
using System.Data.SqlClient;
using App.Helper;

namespace App.Controller
{
    public class ReportController
    {
        public DataTable GetMonthlyRevenue(int year)
        {
            using (SqlConnection conn = BackendHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        MONTH(o.CreatedOn) as Month,
                        COUNT(DISTINCT o.Id) as TotalOrders,
                        SUM(o.TotalPrice) as Revenue,
                        SUM(od.Quantity) as TotalItems
                    FROM [Order] o
                    JOIN OrderDetail od ON o.Id = od.OrderID
                    WHERE YEAR(o.CreatedOn) = @year
                    AND o.Status = 'Completed'
                    GROUP BY MONTH(o.CreatedOn)
                    ORDER BY Month";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable GetTopSellingProducts(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = BackendHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        c.Name as ProductName,
                        SUM(od.Quantity) as TotalQuantity,
                        SUM(od.Price * od.Quantity) as TotalRevenue
                    FROM OrderDetail od
                    JOIN Component c ON od.ComponentID = c.Id
                    JOIN [Order] o ON od.OrderID = o.Id
                    WHERE o.CreatedOn BETWEEN @startDate AND @endDate
                    AND o.Status = 'Completed'
                    GROUP BY c.Name
                    ORDER BY TotalQuantity DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable GetInventoryValue()
        {
            using (SqlConnection conn = BackendHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        cc.CategoryName,
                        COUNT(c.Id) as TotalProducts,
                        SUM(c.Stock) as TotalStock,
                        SUM(c.Stock * c.Price) as TotalValue
                    FROM Component c
                    JOIN CategoryComponent cc ON c.CategoryID = cc.CategoryID
                    GROUP BY cc.CategoryName
                    ORDER BY TotalValue DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}