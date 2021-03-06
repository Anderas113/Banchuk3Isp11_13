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

namespace Banchuk3Isp11_13.Windows.Meneger
{
    /// <summary>
    /// Логика взаимодействия для PageMaster.xaml
    /// </summary>
    public partial class PageMaster : Page
    {
        public PageMaster()
        {
            InitializeComponent();
            LvUserClient.ItemsSource = Context.Client.ToList();
        }
        private void btnAddClientClick(object sender, RoutedEventArgs e)
        {
            AddWindowClient addWindowClient = new AddWindowClient();
            addWindowClient.ShowDialog();
            LvUserClient.ItemsSource = Context.Client.ToList();
        }
        private void btnDelClient(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы хотите удалить клиента?","Удаление клиента.",MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (LvUserClient.SelectedItem is Client client)
                {
                    Context.Client.Remove(Context.Client.Where(i => i.IdClient == client.IdClient).FirstOrDefault());
                    Context.SaveChanges();
                    MessageBox.Show("Запись удалена.", "Удаление записи.", MessageBoxButton.OK, MessageBoxImage.Information);
                    LvUserClient.ItemsSource = Context.Client.ToList();
                }
                else
                { MessageBox.Show("Пожалуста выберити клиента.","Удаление клиента.",MessageBoxButton.OK,MessageBoxImage.Information); }
            }
        }
        private void btnEditClientClick(object sender, RoutedEventArgs e)
        {
            if (LvUserClient.SelectedItem is Client client)
            {
                idClient = client.IdClient;
                EditWindowClient editWindowClient = new EditWindowClient();
                editWindowClient.ShowDialog();
                LvUserClient.ItemsSource = Context.Client.ToList();
            }
            else
            {
                MessageBox.Show("Вы не выбрали клиента из списка.","Предупреждение",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }
    }
}
