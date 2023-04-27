using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestWebApiInWPF.Models;
using TestWebApiInWPF.Service;

namespace TestWebApiInWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для PAddUser.xaml
    /// </summary>
    public partial class PAddUser : Page
    {
        public PAddUser()
        {
            InitializeComponent();
            Refresh();
        }
        private async void Refresh()
        {
            CBGender.ItemsSource = await NetManager.Get<List<Gender>>("api/Genders/GetallGender");
            CBRole.ItemsSource = await NetManager.Get<List<Role>>("api/Roles/GetallRole");
            var users = await NetManager.Get<List<User>>("api/Users/GetallUsers");
            DGUsers.ItemsSource = users;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private async void BAdd_Click(object sender, RoutedEventArgs e)
        {
            var user = new User();
            user.Name = TBName.Text;
            user.Age = int.Parse(TBAge.Text);
            user.City = TBCity.Text;
            user.GenderId = CBGender.SelectedIndex + 1;
            user.RoleId = CBRole.SelectedIndex + 1; 
            await NetManager.Post("api/Users/Add", user);
            Refresh();
        }

        private async void BDelete_Click(object sender, RoutedEventArgs e)
        {
            var user = DGUsers.SelectedItem as User;
            await NetManager.Delete($"api/Users/Delete/{user.Name}");
            Refresh();
        }
    }
}
