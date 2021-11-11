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
    /// Логика взаимодействия для AddWindowManager.xaml
    /// </summary>
    public partial class AddWindowManager : Window
    {
        public AddWindowManager()
        {
            InitializeComponent();
            Gender.ItemsSource = Context.Gender.Select(i => i.GenderName).ToList();

        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {
            Context.Administrator.Add(new Administrator
            {
                AdminNane = Name.Text,
                LastName = FName.Text,
                Patronomyc = Patronomyc.Text,
                GenderId = Context.Gender.Where(i => i.GenderName == Gender.SelectedItem.ToString()).Select(i => i.GenderID).FirstOrDefault(),
                Email = Email.Text,
                Phone = Phone.Text,
                DateOfBirth = calendar1.SelectedDate.Value,
                DateOfBeginWork = DateTime.Now,
               Salary=Convert.ToDecimal(Salary.Text)
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
