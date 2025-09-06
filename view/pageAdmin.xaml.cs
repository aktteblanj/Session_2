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
    /// Логика взаимодействия для pageAdmin.xaml
    /// </summary>
    public partial class pageAdmin : Page
    {
        public pageAdmin()
        {
            InitializeComponent();
            viewProductLv.ItemsSource = ConnectDB.tradeEntities.Product.ToList();
        }
    }
}
