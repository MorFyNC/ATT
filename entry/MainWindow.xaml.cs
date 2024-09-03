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

namespace entry
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SellerSelectButton_OnClick(object sender, RoutedEventArgs e)
        {
            var STCDialog = new SellerTypeChoiceDialog();
            STCDialog.Show();
        }
        public void UpdateData()
        {
            if (!(AppContext.SelectedSeller is null)) SellerLbl.Content = $"Продавец: {AppContext.SelectedSeller.Fullname}";
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if(AppContext.SelectedSeller is null)
            {
                MessageBox.Show("Сначала выберите продавца!");
                return;
            }
            if(DailySallary.Text == "")
            {
                MessageBox.Show("Введите дневную выручку!");
                return;
            }
            if (!double.TryParse(DailySallary.Text, out double res))
            {
                MessageBox.Show("Введите корректную дневную выручку!");
                return;
            }

            AppContext.PayList.Add(new Field(AppContext.SelectedSeller, res));
            MessageBox.Show("Поле добавлено в рассчётный лист!");
        }

        private void ShowPayList_Click(object sender, RoutedEventArgs e)
        {
            var paylist = new PayList();
            paylist.Show();
        }
    }
}
