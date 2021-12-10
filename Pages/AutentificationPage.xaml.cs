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
using Wpf_ogm.Class;

namespace Wpf_ogm.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutentificationPage.xaml
    /// </summary>
    public partial class AutentificationPage : Page
    {
        public AutentificationPage()
        {
            InitializeComponent();
        }

        private void Btn_pk_pass_Click(object sender, RoutedEventArgs e)
        {
            if (Tb_pass_2.Visibility == Visibility.Collapsed)
            {
                Tb_pass_2.Text = Tb_pass.Password;
                Tb_pass_2.Visibility = Visibility.Visible;
                Tb_pass.Visibility = Visibility.Collapsed;
            }
            else
            {
                Tb_pass_2.Visibility = Visibility.Collapsed;
                Tb_pass.Visibility = Visibility.Visible;
            }
        }

        private void Btn_vhod_Click(object sender, RoutedEventArgs e)
        {
            
            var userObj = Class_DB_Connect.db_obj.User.FirstOrDefault(
                x => x.login == Tb_login.Text && x.password == Tb_pass.Password);

            if(userObj == null)
            {
                MessageBox.Show("Такой пользователь уже сущевствует", "Уведомление");
            }
            else
            {
                switch (userObj.Role_id)
                {
                    case 1:
                        MessageBox.Show("Ваш профиль админ");
                        Class_Frame_Perehod.frm_obj.Navigate(new Vhod_menu_Page());
                        break;
                    case 2:
                        MessageBox.Show("Ваш профиль пользователь");
                        break;



                }
                


            }
        }
    }
}
