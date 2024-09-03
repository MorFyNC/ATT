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
    /// Логика взаимодействия для PayList.xaml
    /// </summary>
    public partial class PayList : Window
    {
        public PayList()
        {
            InitializeComponent();
            PayListLV.ItemsSource = AppContext.PayList;
        }
    }
}
