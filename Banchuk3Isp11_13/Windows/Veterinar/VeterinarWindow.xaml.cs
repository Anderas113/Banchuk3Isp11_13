using Banchuk3Isp11_13.Windows.Veterinar;
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

namespace Banchuk3Isp11_13.Windows
{
    /// <summary>
    /// Логика взаимодействия для VeterinarWindow.xaml
    /// </summary>
    public partial class VeterinarWindow : Window
    {
        public VeterinarWindow()
        {
            InitializeComponent();
        }
        private void BtnClickPathient(object sender, RoutedEventArgs e)
        {
            frmMainAdmin.Navigate(new ClientPage());
        }
        private void BtnClickService(object sender, RoutedEventArgs e)
        {
            frmMainAdmin.Navigate(new PageService());
        }
        private void btnListExitProfileClick(object sender, RoutedEventArgs e)
        {
            AuthWindow mw = new AuthWindow();
            mw.Show();
            this.Close();
        }
        private void BtnClickExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
