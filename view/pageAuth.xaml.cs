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
using WpfApp1p.model;

namespace WpfApp1p.view
{
    /// <summary>
    /// Логика взаимодействия для pageAuth.xaml
    /// </summary>
    public partial class pageAuth : Page
    {
        public pageAuth()
        {
            InitializeComponent();
        }

        private void signBt_Click(object sender, RoutedEventArgs e)
        {
            var obj = ConnectDB.tradeEntities.User
                .FirstOrDefault(o => o.UserLogin == loginTb.Text 
                && o.UserPassword == passwordTb.Text);

            if (obj != null)
            {
                NavigationService.Navigate(new pageAdmin());
            }
            else MessageBox.Show($"Данный {loginTb.Text} и {passwordTb.Text} не верны!");
        }
    }
}
