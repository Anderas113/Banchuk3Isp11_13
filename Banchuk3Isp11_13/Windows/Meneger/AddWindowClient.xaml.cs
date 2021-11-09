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
    /// Логика взаимодействия для AddWindowClient.xaml
    /// </summary>
    public partial class AddWindowClient : Window
    {
        public AddWindowClient()
        {
            InitializeComponent();
            Gender.ItemsSource = Context.Gender.Select(i => i.GenderName).ToList();
            
        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {
            Context.Client.Add(new Client
            { 
                FirstName=Name.Text,
                LastName=FName.Text,
                Patronomyc=Patronomyc.Text,
                GenderId=Context.Gender.Where(i=>i.GenderName==Gender.SelectedItem.ToString()).Select(i=>i.GenderID).FirstOrDefault(),
                Email=Email.Text,
                Phone=Phone.Text,
                DateOfBirth= calendar1.SelectedDate.Value,
                DateOfRegestretion=DateTime.Now
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
