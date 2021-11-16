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
    /// Логика взаимодействия для EditAdminWindowService.xaml
    /// </summary>
    public partial class EditAdminWindowService : Window
    {
        public EditAdminWindowService()
        {
            InitializeComponent();
            var service = Context.Service.Where(i => i.IdService == idClient).FirstOrDefault();
            Name.Text = service.NameService;
            LengOfTime.Text = Convert.ToString(service.LengTimeService);
            Description.Text = service.DescriptionService;
            Cost.Text = Convert.ToString(service.Cost);
        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {
            var service = Context.Service.Where(i => i.IdService == idClient).FirstOrDefault();
            service.NameService = Name.Text;
            service.LengTimeService = Convert.ToInt32(LengOfTime.Text);
            service.DescriptionService = Description.Text;
            service.Cost = Convert.ToDecimal(Cost.Text);

        }
        private void ClickClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
