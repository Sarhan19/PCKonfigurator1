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
        private SqlConnection connection;
        public Bauteile_Seite()
        {
            InitializeComponent();
        }

        public void TabelleAnzeigen(string tabellenname, SqlConnection _connection)
        {
            connection = _connection;
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
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM CPU"; // update select command accordingly
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CPU cpu = new CPU(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6));
                        CPUs.Add(cpu);
                    }
                }
            }
        }
        //public SqlConnection connection;
        //public void OpenConnection()
        //{
        //    connection = new SqlConnection(Properties.Settings.Default.DBPCTeileConnectionString);
        //    connection.Open();
        //}
        //public void CloseConnection()
        //{
        //    connection.Close();
        //}

        //private void load_List()
        //{
        //    //CPUs.Clear();
        //    //LstBxBauteile.ItemsSource = CPUs; 
        //    GetCPUList();
        //    LstBxBauteile.ItemsSource = CPUs;
        //}
    }
}
