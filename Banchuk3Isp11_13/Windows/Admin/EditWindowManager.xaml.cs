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
    /// Логика взаимодействия для EditWindowManager.xaml
    /// </summary>
    public partial class EditWindowManager : Window
    {
        public EditWindowManager()
        {
            InitializeComponent();
            Gender.ItemsSource = Context.Gender.Select(i => i.GenderName).ToList();
            var admin = Context.Administrator.Where(i => i.IdAdmin == idClient).FirstOrDefault();
            Gender.SelectedItem = Context.Gender.Where(i => i.GenderID == admin.GenderId).Select(i => i.GenderName).FirstOrDefault();
            Name.Text = admin.AdminNane;
            FName.Text = admin.LastName;
            Patronomyc.Text = admin.Patronomyc;
            Email.Text = admin.Email;
            Phone.Text = admin.Phone;
            calendar1.SelectedDate = admin.DateOfBirth;
            Salary.Text = Convert.ToString(admin.Salary);

        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {
            var admin = Context.Administrator.Where(i => i.IdAdmin == idClient).FirstOrDefault();
            admin.AdminNane = Name.Text;
            admin.LastName = FName.Text;
            admin.Patronomyc = Patronomyc.Text;
            admin.GenderId = Context.Gender.Where(i => i.GenderName == Gender.SelectedItem.ToString()).Select(i => i.GenderID).FirstOrDefault();
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
