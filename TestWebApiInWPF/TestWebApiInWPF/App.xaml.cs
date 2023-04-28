using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using TestWebApiInWPF.Models;
using TestWebApiInWPF.Service;

namespace TestWebApiInWPF
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<Role> Roles = new List<Role>();
        public static List<Gender> Genders = new List<Gender>();
        public App()
        {
            LoadItemsSources();
        }
        private async void LoadItemsSources()
        {
            Genders = await NetManager.Get<List<Gender>>("api/Genders/GetallGender");
            Roles = await NetManager.Get<List<Role>>("api/Roles/GetallRole");
        }
    }
}
