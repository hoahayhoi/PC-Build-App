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

            // Lấy thông tin user và password hash
            string query = "SELECT PasswordHash FROM Users WHERE UserName = @username";
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", loginDto.Username);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string hashedPassword = reader["PasswordHash"].ToString();

                // So sánh password dựa vào loại hash được sử dụng
                if (hashedPassword.StartsWith("$2a$")) // BCrypt hash
                {
                    return BCrypt.Net.BCrypt.Verify(loginDto.Password, hashedPassword);
                }
                else if (hashedPassword.StartsWith("AQA")) // ASP.NET Identity hash
                {
                    // TODO: Implement ASP.NET Identity password verification
                    return false;
                }
                else // Plain text
                {
                    return hashedPassword == loginDto.Password;
                }
            }

            return false;
        }
    }
}
