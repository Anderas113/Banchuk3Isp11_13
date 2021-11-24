using Banchuk3Isp11_13.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Banchuk3Isp11_13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
           
        }
        public DataTable Select(string SelectSql)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-RAQ0KCC;Trusted_Connection=Yes;DataBase=Veterenar");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = SelectSql;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        private void EnterClick(object sender, RoutedEventArgs e)
        {
  
            if (RoleList.SelectedValue == Veterinar)
            {
                if (Login.Text.Length > 0) // проверяем введён ли логин     
                {
                    if (password.Password.Length > 0) // проверяем введён ли пароль         
                    {             // ищем в базе данных пользователя с такими данными         
                        DataTable dt_user = Select("SELECT * FROM [dbo].[Doctor] WHERE [Email] = '" + Login.Text + "' AND [Phone] = '" + password.Password + "'");
                        if (dt_user.Rows.Count > 0) // если такая запись существует       
                        {
                            IdUser= Convert.ToInt32(Select("SELECT IdDoctor FROM [dbo].[Doctor] WHERE [Email] = '" + Login.Text + "' AND [Phone] = '" + password.Password + "'"));
                            Banchuk3Isp11_13.Windows.VeterinarWindow aM = new Banchuk3Isp11_13.Windows.VeterinarWindow();
                            aM.Show();
                            Application.Current.MainWindow.Close();
                        }
                        else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
                    }
                    else MessageBox.Show("Введите пароль"); // выводим ошибку    
                }
                else MessageBox.Show("Введите логин"); // выводим ошибку 
            }
            else if (RoleList.SelectedValue == Meneger)
            {
                if (Login.Text.Length > 0) // проверяем введён ли логин     
                {
                    if (password.Password.Length > 0) // проверяем введён ли пароль         
                    {             // ищем в базе данных пользователя с такими данными         
                        DataTable dt_user = Select("SELECT * FROM [dbo].[Administrator] WHERE [Email] = '" + Login.Text + "' AND [Phone] = '" + password.Password + "'");
                        if (dt_user.Rows.Count > 0) // если такая запись существует       
                        {   

                            Banchuk3Isp11_13.Windows.MenegerWindow aM = new Banchuk3Isp11_13.Windows.MenegerWindow();
                            aM.Show();
                            Application.Current.MainWindow.Close();
                        }
                        else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
                    }
                    else MessageBox.Show("Введите пароль"); // выводим ошибку    
                }
                else MessageBox.Show("Введите логин"); // выводим ошибку 
            }
            else if (RoleList.SelectedValue == Admin)
            {
                if (Login.Text.Length > 0) // проверяем введён ли логин     
                {
                    if (password.Password.Length > 0) // проверяем введён ли пароль         
                    {             // ищем в базе данных пользователя с такими данными         
                        DataTable dt_user = Select("SELECT * FROM [dbo].[ChiefMedicalOfficer] WHERE [Email] = '" + Login.Text + "' AND [Phone] = '" + password.Password + "'");
                        if (dt_user.Rows.Count > 0) // если такая запись существует       
                        {
                            Banchuk3Isp11_13.Windows.AdminWindow aM = new Banchuk3Isp11_13.Windows.AdminWindow();
                            aM.Show();
                            Application.Current.MainWindow.Close();
                        }
                        else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
                    }
                    else MessageBox.Show("Введите пароль"); // выводим ошибку    
                }
                else MessageBox.Show("Введите логин"); // выводим ошибку 
            }
            else
            { MessageBox.Show("Пожалуста выберити роль"); }
            }
            private void CloseClick(object sender, RoutedEventArgs e)
            {
                this.Close();
            }
        }
    }
