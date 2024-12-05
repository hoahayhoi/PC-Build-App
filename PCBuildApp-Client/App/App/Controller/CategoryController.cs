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
    }
}
