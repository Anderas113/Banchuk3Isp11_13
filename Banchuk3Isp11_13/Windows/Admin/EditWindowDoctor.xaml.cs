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
    /// Логика взаимодействия для EditWindowDoctor.xaml
    /// </summary>
    public partial class EditWindowDoctor : Window
    {
        public EditWindowDoctor()
        {
            InitializeComponent();
            Gender.ItemsSource = Context.Gender.Select(i => i.GenderName).ToList();
            Specality.ItemsSource = Context.Specality.Select(i => i.NameSpecality).ToList();
            var doctor = Context.Doctor.Where(i => i.IdDoctor == idClient).FirstOrDefault();
            Gender.SelectedItem = Context.Gender.Where(i => i.GenderID == doctor.GenderId).Select(i => i.GenderName).FirstOrDefault();
            Specality.SelectedItem = Context.Specality.Where(i => i.IdSpecality == doctor.IdDoctor).Select(i => i.NameSpecality).FirstOrDefault();
            Name.Text = doctor.DoctorNane;
            FName.Text = doctor.LastName;
            Patronomyc.Text = doctor.Patronomyc;
            Email.Text = doctor.Email;
            Phone.Text = doctor.Phone;
            calendar1.SelectedDate = doctor.DateOfBirth;
            Salary.Text = Convert.ToString(doctor.Salary);

        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {
            var admin = Context.Doctor.Where(i => i.IdDoctor == idClient).FirstOrDefault();
            admin.DoctorNane = Name.Text;
            admin.LastName = FName.Text;
            admin.Patronomyc = Patronomyc.Text;
            admin.GenderId = Context.Gender.Where(i => i.GenderName == Gender.SelectedItem.ToString()).Select(i => i.GenderID).FirstOrDefault();
            admin.IdSpecality = Context.Specality.Where(i => i.NameSpecality == Specality.SelectedItem.ToString()).Select(i => i.IdSpecality).FirstOrDefault();
            admin.Email = Email.Text;
            admin.Phone = Phone.Text;
            admin.DateOfBirth = calendar1.SelectedDate.Value;
            admin.Salary = Convert.ToDecimal(Salary.Text);
            Context.SaveChanges();
            this.Close();
        }
        private void ClickClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
