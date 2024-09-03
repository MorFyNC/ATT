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
    /// Логика взаимодействия для NewSellerWindow.xaml
    /// </summary>
    public partial class NewSellerWindow : Window
    {
        public NewSellerWindow()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if(!Validator.ValidateFullname(SellerFullname.Text))
            {
                MessageBox.Show("Некорректно введены фамилия и/или инициалы!");
                return;
            }
            if(!Validator.ValidateDate(AppliementDate.SelectedDate.Value))
            {
                MessageBox.Show("Некорректно задана дата!");
                return;
            }
            var newSeller = new Seller(SellerFullname.Text, AppliementDate.SelectedDate.Value);
            AppContext.AddSeller(newSeller);
            AppContext.SelectedSeller = newSeller;
            var main = Application.Current.MainWindow as MainWindow;
            main.UpdateData();
            Close();
        }
    }
}
