using App.Helper;
using App.Model;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    public class AccountController
    {
        public bool Login(LoginDto loginDto)
        {
            using SqlConnection conn = BackendHelper.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Users WHERE UserName = @username AND PasswordHash = @password";
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", loginDto.Username);
            cmd.Parameters.AddWithValue("@password", loginDto.Password);

            using SqlDataReader reader = cmd.ExecuteReader();
            return reader.HasRows;
        }
    }
}
