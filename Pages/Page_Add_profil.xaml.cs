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
using Wpf_ogm.db_con;

namespace Wpf_ogm.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page_Add_profil.xaml
    /// </summary>
    public partial class Page_Add_profil : Page
    {
        public Page_Add_profil()
        {
            InitializeComponent();
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = new User();
                user.login = Tb_login.Text;
                user.password = Tb_pass.Text;

                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
