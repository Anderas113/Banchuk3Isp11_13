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

namespace Banchuk3Isp11_13.Windows.Admin
{
    /// <summary>
    /// Логика взаимодействия для PageAdminVetirinar.xaml
    /// </summary>
    public partial class PageAdminVetirinar : Page
    {
        public PageAdminVetirinar()
        {
            InitializeComponent();
            LvUserVeterenar.ItemsSource = Context.Doctor.ToList();
            LvUserVeterenar.ItemsSource = Context.Specality.ToList();

        }
    }
}
