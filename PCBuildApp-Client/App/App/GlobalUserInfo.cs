using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public static class GlobalUserInfo
    {
        public static string CurrentUserRole { get; set; }
        public static string CurrentUserID { get; set; }
        public static string CurrentUserName { get; set; }
    }
}