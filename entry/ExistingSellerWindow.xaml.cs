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
using System.Windows.Shapes;

namespace entry
{
    /// <summary>
    /// Логика взаимодействия для ExistingSellerWindow.xaml
    /// </summary>
    public partial class ExistingSellerWindow : Window
    {
        public ExistingSellerWindow()
        {
            InitializeComponent();
            SellerCB.ItemsSource = AppContext.Sellers;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            AppContext.SelectedSeller = SellerCB.SelectedItem as Seller;
            var main = Application.Current.MainWindow as MainWindow;
            main.UpdateData();
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
