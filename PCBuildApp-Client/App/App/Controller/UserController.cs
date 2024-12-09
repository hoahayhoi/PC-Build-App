using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Model;
using System.Windows;

namespace App.Controller
{
    public class UserController
    {
        private string connectionString = "Data Source=34.80.167.226,1433;Initial Catalog=PCBuild;User Id=sqlserver;Password=admin;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        public DataTable GetAllUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT u.Id, u.Name, u.UserName, u.Email, u.Phone, 
                           STRING_AGG(r.Name, ', ') as Roles
                           FROM Users u
                           LEFT JOIN UserRoles ur ON u.Id = ur.UserId
                           LEFT JOIN Roles r ON ur.RoleId = r.Id
                           GROUP BY u.Id, u.Name, u.UserName, u.Email, u.Phone";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public List<string> GetAllRoles()
        {
            List<string> roles = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Name FROM Roles";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(reader["Name"].ToString());
                        }
                    }
                }
            }
            return roles;
        }

        public bool AddUser(UserDto user, List<string> roles)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Kiểm tra username đã tồn tại chưa
                            string checkQuery = "SELECT COUNT(*) FROM Users WHERE UserName = @username";
                            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction))
                            {
                                checkCmd.Parameters.AddWithValue("@username", user.UserName);
                                int count = (int)checkCmd.ExecuteScalar();
                                if (count > 0)
                                {
                                    transaction.Rollback();
                                    return false;
                                }
                            }

                            // Thêm user với AccessFailedCount = 0
                            string userQuery = @"INSERT INTO Users (
                                           Name, 
                                           UserName, 
                                           Email, 
                                           Phone, 
                                           PasswordHash,
                                           AccessFailedCount,
                                           NormalizedUserName,
                                           NormalizedEmail
                                       ) 
                                       VALUES (
                                           @name, 
                                           @username, 
                                           @email, 
                                           @phone, 
                                           @password,
                                           0,
                                           @normalizedUsername,
                                           @normalizedEmail
                                       );
                                       SELECT SCOPE_IDENTITY()";

                            SqlCommand cmd = new SqlCommand(userQuery, conn, transaction);

                            // Xử lý các tham số
                            cmd.Parameters.AddWithValue("@name", user.Name);
                            cmd.Parameters.AddWithValue("@username", user.UserName);

                            // Xử lý email
                            if (string.IsNullOrEmpty(user.Email))
                            {
                                cmd.Parameters.AddWithValue("@email", DBNull.Value);
                                cmd.Parameters.AddWithValue("@normalizedEmail", DBNull.Value);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@email", user.Email);
                                cmd.Parameters.AddWithValue("@normalizedEmail", user.Email.ToUpper());
                            }

                            // Xử lý phone
                            if (string.IsNullOrEmpty(user.Phone))
                            {
                                cmd.Parameters.AddWithValue("@phone", DBNull.Value);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@phone", user.Phone);
                            }

                            cmd.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(user.Password));
                            cmd.Parameters.AddWithValue("@normalizedUsername", user.UserName.ToUpper());

                            int userId = Convert.ToInt32(cmd.ExecuteScalar());

                            // Thêm role
                            if (roles.Any())
                            {
                                string roleQuery = @"INSERT INTO UserRoles (UserId, RoleId)
                                          SELECT @userId, Id FROM Roles WHERE Name = @role";
                                cmd = new SqlCommand(roleQuery, conn, transaction);
                                cmd.Parameters.AddWithValue("@userId", userId);
                                cmd.Parameters.AddWithValue("@role", roles.First());
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception($"Lỗi khi thêm user: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return false;
            }
        }
        public bool UpdateUser(int id, UserDto user, List<string> roles)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string userQuery;
                        SqlCommand cmd;

                        // Nếu có password mới
                        if (!string.IsNullOrEmpty(user.Password))
                        {
                            userQuery = @"UPDATE Users 
                                SET Name = @name, 
                                    UserName = @username,
                                    Email = @email, 
                                    Phone = @phone,
                                    PasswordHash = @password
                                WHERE Id = @id";

                            cmd = new SqlCommand(userQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(user.Password));
                        }
                        else
                        {
                            userQuery = @"UPDATE Users 
                                SET Name = @name, 
                                    UserName = @username,
                                    Email = @email, 
                                    Phone = @phone
                                WHERE Id = @id";

                            cmd = new SqlCommand(userQuery, conn, transaction);
                        }

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", user.Name);
                        cmd.Parameters.AddWithValue("@username", user.UserName);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@phone", user.Phone);
                        cmd.ExecuteNonQuery();

                        // Update role - chỉ cho phép 1 role
                        cmd = new SqlCommand("DELETE FROM UserRoles WHERE UserId = @userId", conn, transaction);
                        cmd.Parameters.AddWithValue("@userId", id);
                        cmd.ExecuteNonQuery();

                        // Chỉ lấy role đầu tiên được chọn
                        if (roles.Any())
                        {
                            string roleQuery = @"INSERT INTO UserRoles (UserId, RoleId)
                                      SELECT @userId, Id FROM Roles WHERE Name = @role";
                            cmd = new SqlCommand(roleQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@userId", id);
                            cmd.Parameters.AddWithValue("@role", roles.First());
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
        public bool DeleteUser(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Delete roles
                        SqlCommand cmd = new SqlCommand("DELETE FROM UserRoles WHERE UserId = @id", conn, transaction);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        // Delete user
                        cmd = new SqlCommand("DELETE FROM Users WHERE Id = @id", conn, transaction);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public UserDto GetUserById(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT u.Id, u.Name, u.UserName, u.Email, u.Phone, 
                   STRING_AGG(r.Name, ', ') AS Roles
            FROM Users u
            LEFT JOIN UserRoles ur ON u.Id = ur.UserId
            LEFT JOIN Roles r ON ur.RoleId = r.Id
            WHERE u.Id = @userId
            GROUP BY u.Id, u.Name, u.UserName, u.Email, u.Phone";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lấy danh sách vai trò từ chuỗi roles
                            var roles = reader["Roles"].ToString().Split(',').ToList();

                            return new UserDto(
                                reader["Name"].ToString(),
                                reader["UserName"].ToString(),
                                reader["Email"].ToString(),
                                reader["Phone"].ToString(),
                                null  // Không cần mật khẩu trong này, vì không cần truyền
                            )
                            {
                                Roles = roles  // Gán vai trò vào UserDto
                            };
                        }
                    }
                }
            }
            return null;  // Trả về null nếu không tìm thấy người dùng
        }


        public bool ChangePassword(int userId, string currentPassword, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT PasswordHash FROM Users WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    string hashedPassword = (string)cmd.ExecuteScalar();

                    // Kiểm tra mật khẩu cũ
                    if (BCrypt.Net.BCrypt.Verify(currentPassword, hashedPassword))
                    {
                        // Mã hóa mật khẩu mới
                        string hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                        // Cập nhật mật khẩu mới
                        string updateQuery = "UPDATE Users SET PasswordHash = @password WHERE Id = @id";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@password", hashedNewPassword);
                            updateCmd.Parameters.AddWithValue("@id", userId);
                            updateCmd.ExecuteNonQuery();
                            return true;
                        }
                    }
                    return false;
                }
            }
        }

    }
}
