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
        private void btnAddClientClick(object sender, RoutedEventArgs e)
        {
            AddWindowPatient addWindowPatient = new AddWindowPatient();
            addWindowPatient.ShowDialog();
            LvUserPatient.ItemsSource = Context.Patient.ToList();
        }
        private void btnDelClient(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы хотите удалить клиента?", "Удаление клиента.", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (LvUserPatient.SelectedItem is Patient patient)
                {
                    Context.Patient.Remove(Context.Patient.Where(i => i.IdPatient == patient.IdPatient).FirstOrDefault());
                    Context.SaveChanges();
                    MessageBox.Show("Запись удалена.", "Удаление записи.", MessageBoxButton.OK, MessageBoxImage.Information);
                    LvUserPatient.ItemsSource = Context.Patient.ToList();
                }
                else
                { MessageBox.Show("Пожалуста выберити клиента.", "Удаление клиента.", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
        }
        private void btnEditClientClick(object sender, RoutedEventArgs e)
        {
            if (LvUserPatient.SelectedItem is Patient patient)
            {
                idClient = patient.IdPatient;
                EditWindowPatient editWindowPatient = new EditWindowPatient();
                editWindowPatient.ShowDialog();
                LvUserPatient.ItemsSource = Context.Patient.ToList();
            }
            else
            {
                MessageBox.Show("Вы не выбрали клиента из списка.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
