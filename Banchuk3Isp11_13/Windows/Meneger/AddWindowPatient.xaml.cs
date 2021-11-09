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
using Banchuk3Isp11_13.EF;

namespace Banchuk3Isp11_13.Windows.Meneger
{
    /// <summary>
    /// Логика взаимодействия для AddWindowPatient.xaml
    /// </summary>
    public partial class AddWindowPatient : Window
    {
        public AddWindowPatient()
        {
            InitializeComponent();
            Gender.ItemsSource = Context.Gender.Select(i => i.GenderName).ToList();
            Kind.ItemsSource = Context.KindOfAnimal.Select(i=>i.KindName).ToList();
            Bread.ItemsSource = Context.Breed.Select(i=>i.NameBreed).ToList();
        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {
            Context.Patient.Add(new Patient
            {
                Name = Name.Text,
                height = Convert.ToInt32(height.Text),
                weight = Convert.ToInt32(weight.Text),
                length = Convert.ToInt32(Lenght.Text),
                GenderId = Context.Gender.Where(i => i.GenderName == Gender.SelectedItem.ToString()).Select(i => i.GenderID).FirstOrDefault(),
                IdKind = Context.KindOfAnimal.Where(i => i.KindName == Kind.SelectedItem.ToString()).Select(i => i.IdKind).FirstOrDefault(),
                IdBreed = Context.Breed.Where(i => i.NameBreed == Bread.SelectedItem.ToString()).Select(i => i.IdBreed).FirstOrDefault(),
                IdClient=Context.Client.Where(i => i.Email == Masster.Text.ToString()).Select(i => i.IdClient).FirstOrDefault(),
                DateOfBirth = calendar1.SelectedDate.Value,
                DateOfRegestrition = DateTime.Now
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
