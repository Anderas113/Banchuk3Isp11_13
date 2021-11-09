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


namespace Banchuk3Isp11_13.Windows.Meneger
{
    /// <summary>
    /// Логика взаимодействия для EditWindowPatient.xaml
    /// </summary>
    public partial class EditWindowPatient : Window
    {
        public EditWindowPatient()
        {
            InitializeComponent();
            Gender.ItemsSource = Context.Gender.Select(i => i.GenderName).ToList();
            Kind.ItemsSource = Context.KindOfAnimal.Select(i => i.KindName).ToList();
            Bread.ItemsSource = Context.Breed.Select(i => i.NameBreed).ToList();
            var patient = Context.Patient.Where(i => i.IdPatient == idClient).FirstOrDefault();
            Gender.SelectedItem = Context.Gender.Where(i => i.GenderID == patient.GenderId).Select(i => i.GenderName).FirstOrDefault();
            Name.Text = patient.Name;
            height.Text = Convert.ToString(patient.height);
            weight.Text = Convert.ToString(patient.weight);
            Lenght.Text = Convert.ToString(patient.length);
            calendar1.SelectedDate = patient.DateOfBirth;
            Masster.Text = Context.Client.Where(i => i.IdClient == patient.IdClient).Select(i => i.Email).FirstOrDefault();
            Bread.SelectedItem = Context.Breed.Where(i => i.IdBreed == patient.IdBreed).Select(i => i.NameBreed).FirstOrDefault();
            Kind.SelectedItem = Context.KindOfAnimal.Where(i => i.IdKind == patient.IdKind).Select(i => i.KindName).FirstOrDefault();
        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {
            var patient = Context.Patient.Where(i => i.IdPatient == idClient).FirstOrDefault();
            patient.Name = Name.Text;
            patient.height = Convert.ToInt32(height.Text);
            patient.weight = Convert.ToInt32(weight.Text);
            patient.length = Convert.ToInt32(Lenght.Text);
            patient.DateOfBirth = calendar1.SelectedDate.Value;
            patient.IdClient = Context.Client.Where(i => i.Email == Masster.Text).Select(i => i.IdClient).FirstOrDefault();
            patient.GenderId = Context.Gender.Where(i => i.GenderName == Gender.SelectedItem.ToString()).Select(i => i.GenderID).FirstOrDefault();
            patient.IdKind = Context.KindOfAnimal.Where(i => i.KindName == Kind.SelectedItem.ToString()).Select(i => i.IdKind).FirstOrDefault();
            patient.IdBreed = Context.Breed.Where(i => i.NameBreed == Bread.SelectedItem.ToString()).Select(i => i.IdBreed).FirstOrDefault();
            Context.SaveChanges();
            this.Close();
        }
        private void ClickClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
