using Banchuk3Isp11_13.EF;
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
using static Banchuk3Isp11_13.EF.Entfr;

namespace Banchuk3Isp11_13.Windows.Veterinar
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            LvUserPatient.ItemsSource = Context.Doctor.ToList();
            LvUserPatient.ItemsSource = Context.Order.ToList();
            LvUserPatient.ItemsSource = Context.Service.ToList();
            LvUserPatient.ItemsSource = Context.Patient.ToList();

        }

        private void LvUserPatient_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
