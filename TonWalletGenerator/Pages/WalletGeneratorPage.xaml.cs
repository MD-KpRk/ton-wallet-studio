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
using TonWalletStudio.Controllers;

namespace TonWalletStudio.Pages
{
    /// <summary>
    /// Логика взаимодействия для WalletGeneratorPage.xaml
    /// </summary>
    public partial class WalletGeneratorPage : Page
    {
        public WalletGeneratorPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationController.Instance.GoBack();
        }
    }
}
