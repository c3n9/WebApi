using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebApiInWPF.Models;

namespace TestWebApiInWPF.Service
{
    public static class DBConnection
    {
        public static List<User> Users { get; set; }
        public static List<Role> Roles { get; set; }
        public static List<Gender> Genders { get; set; }
        public static async void InitializeDBConnection()
        {
            Roles = await NetManager.Get<List<Role>>("api/Roles/GetallRole");
            Genders = await NetManager.Get<List<Gender>>("api/Genders/GetallGender");
            await RefreshData();
        }
        public static async Task RefreshData()
        {
            Users = await NetManager.Get<List<User>>("api/Users/GetallUsers");
        }
    }
}
