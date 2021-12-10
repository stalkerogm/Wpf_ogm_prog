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
    /// Логика взаимодействия для Vhod_menu_Page.xaml
    /// </summary>
    public partial class Vhod_menu_Page : Page
    {
        public Vhod_menu_Page()
        {
            InitializeComponent();
            GridList.ItemsSource = Class_DB_Connect.db_obj.User.ToList();
            
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            Class_Frame_Perehod.frm_obj.GoBack();
        }
    }
}
