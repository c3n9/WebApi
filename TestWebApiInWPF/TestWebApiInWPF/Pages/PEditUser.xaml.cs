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
            CBRole.ItemsSource = DBConnection.Roles.ToList();
            CBGender.ItemsSource = DBConnection.Genders.ToList();
            contextUser = user;
            DataContext = contextUser;
        }
        private async void BSave_Click(object sender, RoutedEventArgs e)
        {
            await NetManager.Put($"api/Users/Edit", contextUser);
            
            NavigationService.GoBack();
        }
        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


    }
}
