using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
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
    /// Логика взаимодействия для PEditUser.xaml
    /// </summary>
    public partial class PEditUser : Page
    {
        User contextUser;
        public PEditUser(User user)
        {
            InitializeComponent();
            LoadItemsSources();
            contextUser = user;
            DataContext = contextUser;
        }

        private async void LoadItemsSources()
        {
            CBGender.ItemsSource = await NetManager.Get<List<Gender>>("api/Genders/GetallGender");
            CBRole.ItemsSource = await NetManager.Get<List<Role>>("api/Roles/GetallRole");
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //LoadItemsSources();
        }
        private async void BSave_Click(object sender, RoutedEventArgs e)
        {
            await NetManager.Put($"api/Users/Delete/{contextUser.Name}", contextUser);
            NavigationService.GoBack();
        }
        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


    }
}
