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

namespace Banchuk3Isp11_13.Windows.Admin
{
    /// <summary>
    /// Логика взаимодействия для PageServiceAdmin.xaml
    /// </summary>
    public partial class PageServiceAdmin : Page
    {
        public PageServiceAdmin()
        {
            InitializeComponent();
            LvServicer.ItemsSource = Context.Service.ToList();
        }
        private void btnAddDoctorClick(object sender, RoutedEventArgs e)
        {
            AddAdminWindowService addAdminWindowService = new AddAdminWindowService();
            addAdminWindowService.ShowDialog();
            LvServicer.ItemsSource = Context.Doctor.ToList();
        }
        private void btnDelDoctorClick(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы хотите удалить клиента?", "Удаление клиента.", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (LvServicer.SelectedItem is Service service)
                {
                    Context.Service.Remove(Context.Service.Where(i => i.IdService == service.IdService).FirstOrDefault());
                    Context.SaveChanges();
                    MessageBox.Show("Запись удалена.", "Удаление записи.", MessageBoxButton.OK, MessageBoxImage.Information);
                    LvServicer.ItemsSource = Context.Service.ToList();
                }
                else
                { MessageBox.Show("Пожалуста выберити клиента.", "Удаление клиента.", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
        }
        private void btnEditDoctorClick(object sender, RoutedEventArgs e)
        {
            if (LvServicer.SelectedItem is Service service)
            {
                idClient = service.IdService;
                EditAdminWindowService editAdminWindowService = new EditAdminWindowService();
                editAdminWindowService.ShowDialog();
                LvServicer.ItemsSource = Context.Doctor.ToList();
            }
            else
            {
                MessageBox.Show("Вы не выбрали клиента из списка.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

