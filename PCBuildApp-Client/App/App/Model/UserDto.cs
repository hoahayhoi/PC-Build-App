using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class UserDto
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public List<string> Roles { get; set; }

        public UserDto(string name, string username, string email, string phone, string password)
        {
            Name = name;
            UserName = username;
            Email = email;
            Phone = phone;
            Password = password;
            Roles = new List<string>();
        }
    }
}
