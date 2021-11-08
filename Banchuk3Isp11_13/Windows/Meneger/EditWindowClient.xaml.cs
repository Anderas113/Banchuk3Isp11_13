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
    /// Логика взаимодействия для EditWindowClient.xaml
    /// </summary>
    public partial class EditWindowClient : Window
    {
        public EditWindowClient()
        {
            InitializeComponent();
            Gender.ItemsSource = Context.Gender.Select(i => i.GenderName).ToList();
            var client = Context.Client.Where(i => i.IdClient == idClient).FirstOrDefault();
            Gender.SelectedItem = Context.Gender.Where(i => i.GenderID == client.GenderId).Select(i => i.GenderName).FirstOrDefault();
            Name.Text = client.FirstName;
            FName.Text = client.LastName;
            Patronomyc.Text = client.Patronomyc;
            Email.Text = client.Email;
            Phone.Text = client.Phone;
            calendar1.SelectedDate = client.DateOfBirth;

        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {
            var client = Context.Client.Where(i => i.IdClient == idClient).FirstOrDefault();
            client.FirstName = Name.Text;
            client.LastName = FName.Text;
            client.Patronomyc = Patronomyc.Text;
            client.GenderId = Context.Gender.Where(i => i.GenderName == Gender.SelectedItem.ToString()).Select(i => i.GenderID).FirstOrDefault();
            client.Email = Email.Text;
            client.Phone = Phone.Text;
            client.DateOfBirth = calendar1.SelectedDate.Value;
            Context.SaveChanges();
            this.Close();
        }
        private void ClickClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
