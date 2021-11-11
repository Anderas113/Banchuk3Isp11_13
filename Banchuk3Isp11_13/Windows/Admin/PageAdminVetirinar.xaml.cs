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
        private void btnAddManager(object sender, RoutedEventArgs e)
        {
            AddWindowDoctor addWindowDoctor = new AddWindowDoctor();
            addWindowDoctor.ShowDialog();
            LvUserVeterenar.ItemsSource = Context.Doctor.ToList();
        }
        private void btnDelManager(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы хотите удалить клиента?", "Удаление клиента.", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (LvUserVeterenar.SelectedItem is Doctor doctor)
                {
                    Context.Doctor.Remove(Context.Doctor.Where(i => i.IdDoctor == doctor.IdDoctor).FirstOrDefault());
                    Context.SaveChanges();
                    MessageBox.Show("Запись удалена.", "Удаление записи.", MessageBoxButton.OK, MessageBoxImage.Information);
                    LvUserVeterenar.ItemsSource = Context.Doctor.ToList();
                }
                else
                { MessageBox.Show("Пожалуста выберити клиента.", "Удаление клиента.", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
        }
        private void btnEditManager(object sender, RoutedEventArgs e)
        {
            if (LvUserVeterenar.SelectedItem is Doctor doctor)
            {
                idClient = doctor.IdDoctor;
                EditWindowDoctor editWindowDoctor = new EditWindowDoctor();
                editWindowDoctor.ShowDialog();
                LvUserVeterenar.ItemsSource = Context.Doctor.ToList();
            }
            else
            {
                MessageBox.Show("Вы не выбрали клиента из списка.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}