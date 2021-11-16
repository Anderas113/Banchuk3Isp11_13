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
using System.Windows.Shapes;
using static Banchuk3Isp11_13.EF.Entfr;

namespace Banchuk3Isp11_13.Windows.Admin
{
    /// <summary>
    /// Логика взаимодействия для AddAdminWindowService.xaml
    /// </summary>
    public partial class AddAdminWindowService : Window
    {
        public AddAdminWindowService()
        {
            InitializeComponent();
        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {
            Context.Service.Add(new Service
            {
                NameService=Name.Text,
                LengTimeService=Convert.ToInt32(LengOfTime.Text),
                DescriptionService=Description.Text,
                Cost=Convert.ToDecimal(Cost.Text)
            });
            Context.SaveChanges();
            this.Close();
        }
        private void ClickClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
