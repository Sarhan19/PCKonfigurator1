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

using System.Data.SqlClient;
using System.Data;

namespace PCKonfigurator
{
    /// <summary>
    /// Interaction logic for Bauteile_Seite.xaml
    /// </summary>
    public partial class Bauteile_Seite : Page
    {
        List<CPU> CPUs = new List<CPU>();        
        public Bauteile_Seite()
        {
            InitializeComponent();            
        }

        public void TabelleAnzeigen(string tabellenname)
        {
            TxtBlkBauteil.Text = " " + tabellenname;
            if (tabellenname != "CPU")
            {
                LstBxBauteile.Items.Add(" Moin");
                LstBxBauteile.Items.Add(" Hallo");
                LstBxBauteile.Items.Add(" Servus");
            }
            else
            {
                CPUs.Clear();                
                LstBxBauteile.ItemsSource = CPUs;                
                GetCPUList();
                LstBxBauteile.ItemsSource = CPUs;                
            }
            
        }


        public void GetCPUList()
        {
            CPUs.Clear();
            using (var connection = new SqlConnection(Properties.Settings.Default.DBPCTeileConnectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = "SELECT * FROM CPU"; // update select command accordingly
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CPU cpu = new CPU(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6));
                        CPUs.Add(cpu);
                        Console.WriteLine(reader.GetInt32(0));
                    }
                    reader.Close();
                }

            }
        }


        private void Add_Bauteil()
        {
            object addition = LstBxBauteile.SelectedItem;            
            WindowCollection windows = new WindowCollection();
            windows = Application.Current.Windows;
            Window[] winds = new Window[2];
            windows.CopyTo(winds, 0);
            PCKonfiguration oldWindow = (PCKonfiguration)winds[0];
            oldWindow.KonfigSchreiben(addition);
        }
        

        private void LstBxBauteile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Add_Bauteil();
        }
    }
}
