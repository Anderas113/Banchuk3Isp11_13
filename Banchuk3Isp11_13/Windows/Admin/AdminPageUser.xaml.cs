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
    /// Логика взаимодействия для AdminPageUser.xaml
    /// </summary>
    public partial class AdminPageUser : Page
    {
        public AdminPageUser()
        {
            InitializeComponent();
            LvUserManager.ItemsSource = Context.Administrator.ToList();
        }
        private void btnAddManager(object sender, RoutedEventArgs e)
        {
            AddWindowManager addWindowClient = new AddWindowManager();
            addWindowClient.ShowDialog();
            LvUserManager.ItemsSource = Context.Administrator.ToList();
        }
        private void btnDelManager(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы хотите удалить клиента?", "Удаление клиента.", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (LvUserManager.SelectedItem is Administrator administrator)
                {
                    Context.Administrator.Remove(Context.Administrator.Where(i => i.IdAdmin == administrator.IdAdmin).FirstOrDefault());
                    Context.SaveChanges();
                    MessageBox.Show("Запись удалена.", "Удаление записи.", MessageBoxButton.OK, MessageBoxImage.Information);
                    LvUserManager.ItemsSource = Context.Administrator.ToList();
                }
                else
                { MessageBox.Show("Пожалуста выберити клиента.", "Удаление клиента.", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
        }
        private void btnEditManager(object sender, RoutedEventArgs e)
        {
            if (LvUserManager.SelectedItem is Client client)
            {
                idClient = client.IdClient;
                EditWindowManager editWindowManager = new EditWindowManager();
                editWindowManager.ShowDialog();
                LvUserManager.ItemsSource = Context.Administrator.ToList();
            }
            else
            {
                MessageBox.Show("Вы не выбрали клиента из списка.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
