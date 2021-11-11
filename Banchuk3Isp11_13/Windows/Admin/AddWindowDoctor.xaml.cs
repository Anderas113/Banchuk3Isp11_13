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
    /// Логика взаимодействия для AddWindowDoctor.xaml
    /// </summary>
    public partial class AddWindowDoctor : Window
    {
        public AddWindowDoctor()
        {
            InitializeComponent();
            Gender.ItemsSource = Context.Gender.Select(i => i.GenderName).ToList();
            Specality.ItemsSource = Context.Specality.Select(i => i.NameSpecality).ToList();

        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {
            Context.Doctor.Add(new Doctor
            {
                DoctorNane = Name.Text,
                LastName = FName.Text,
                Patronomyc = Patronomyc.Text,
                GenderId = Context.Gender.Where(i => i.GenderName == Gender.SelectedItem.ToString()).Select(i => i.GenderID).FirstOrDefault(),
                IdSpecality=Context.Specality.Where(i=>i.NameSpecality==Specality.SelectedItem.ToString()).Select(i=>i.IdSpecality).FirstOrDefault(),
                Email = Email.Text,
                Phone = Phone.Text,
                DateOfBirth = calendar1.SelectedDate.Value,
                DateOfBeginWork = DateTime.Now,
                Salary = Convert.ToDecimal(Salary.Text)
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
