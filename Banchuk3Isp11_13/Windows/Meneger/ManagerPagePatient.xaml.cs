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

namespace Banchuk3Isp11_13.Windows.Meneger
{
    /// <summary>
    /// Логика взаимодействия для ManagerPagePatient.xaml
    /// </summary>
    public partial class ManagerPagePatient : Page
    {
        public ManagerPagePatient()
        {
            InitializeComponent();
            LvUserPatient.ItemsSource = Context.Patient.ToList();
            LvUserPatient.ItemsSource = Context.KindOfAnimal.ToList();
            LvUserPatient.ItemsSource = Context.Breed.ToList();
            LvUserPatient.ItemsSource = Context.Client.ToList();
        }
    }
}
