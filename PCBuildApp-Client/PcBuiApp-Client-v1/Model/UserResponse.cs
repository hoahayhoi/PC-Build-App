using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Models/UserResponse.cs
namespace PcBuiApp_Client_v1.Models
{
    public class UserResponse
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
