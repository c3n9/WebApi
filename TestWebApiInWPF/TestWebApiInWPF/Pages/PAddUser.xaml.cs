using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
        User contextUser;

        public PAddUser()
        {
            InitializeComponent();
            LoadItemsSources();
        }
        private async void LoadItemsSources()
        {
            CBGender.ItemsSource = await NetManager.Get<List<Gender>>("api/Genders/GetallGender");
            CBRole.ItemsSource = await NetManager.Get<List<Role>>("api/Roles/GetallRole");
        }
        private async void Refresh()
        {
            contextUser = new User();
            DataContext = contextUser;
            var users = await NetManager.Get<List<User>>("api/Users/GetallUsers");
            DGUsers.ItemsSource = users;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //LoadItemsSources();
            Refresh();
        }

        private async void BAdd_Click(object sender, RoutedEventArgs e)
        { 
            await NetManager.Post("api/Users/Add", contextUser);
            Refresh();
        }

        private async void BDelete_Click(object sender, RoutedEventArgs e)
        {
            var user = DGUsers.SelectedItem as User;
            if (user == null)
            {
                MessageBox.Show("Выберите пользователя");
                return;
            }
            await NetManager.Delete<bool>($"api/Users/Delete/{user.Name}");
            Refresh();
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            var user = DGUsers.SelectedItem as User;
            if (user == null)
            {
                MessageBox.Show("Выберите пользователя");
                return;
            }
            NavigationService.Navigate(new PEditUser(user));
        }
    }
}
