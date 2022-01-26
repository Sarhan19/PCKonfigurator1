using System;
using System.Collections.Generic;
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

namespace PCKonfigurator
{
    /// <summary>
    /// Interaction logic for FestplatteAuswahl.xaml
    /// </summary>
    public partial class FestplatteAuswahl : Page
    {
        public FestplatteAuswahl()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection;

        public void Datenübertragung(string title, SqlConnection connection)
        {
            TxtBlkFestplatten.Text = title;
            sqlConnection = connection;
        }

        private void BtnHDD_Click(object sender, RoutedEventArgs e)
        {
            Bauteile_Seite Festplatte_Page = new Bauteile_Seite();
            Festplatte_Page.TabelleAnzeigen("HDD", sqlConnection);
            this.NavigationService.Navigate(Festplatte_Page);
        }

        private void BtnSSD_Click(object sender, RoutedEventArgs e)
        {
            Bauteile_Seite Festplatte_Page = new Bauteile_Seite();
            Festplatte_Page.TabelleAnzeigen("SSD", sqlConnection);
            this.NavigationService.Navigate(Festplatte_Page);
        }
    }
}
