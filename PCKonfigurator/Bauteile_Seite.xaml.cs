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

namespace PCKonfigurator
{
    /// <summary>
    /// Interaction logic for Bauteile_Seite.xaml
    /// </summary>
    public partial class Bauteile_Seite : Page
    {
        public Bauteile_Seite()
        {
            InitializeComponent();
        }

        public void TabelleAnzeigen(string tabellenname)
        {
            TxtBlkBauteil.Text = " "+tabellenname;
            LstBxBauteile.Items.Add(" Moin");
            LstBxBauteile.Items.Add(" Hallo");
            LstBxBauteile.Items.Add(" Servus");
        }
    }
}
