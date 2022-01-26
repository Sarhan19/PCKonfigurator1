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
using System.ComponentModel;

namespace PCKonfigurator
{
    /// <summary>
    /// Interaction logic for Bauteile_Seite.xaml
    /// </summary>
    public partial class Bauteile_Seite : Page
    {
        private List<Arbeitsspeicher> RAMs = new List<Arbeitsspeicher>();
        private List<Prozessorlüfter> CPULuefter = new List<Prozessorlüfter>();
        private List<Mainboard> Mainboards = new List<Mainboard>();
        private List<Grafikkarte> GPUs = new List<Grafikkarte>();
        private List<HDD> HDDs = new List<HDD>();
        private List<SSD> SSDs = new List<SSD>();
        private List<CPU> CPUs = new List<CPU>();
        private List<Gehäuselüfter> GHLuefter = new List<Gehäuselüfter>();
        private List<Gehäuse> GHs = new List<Gehäuse>();
        private List<Netzteil> NTs = new List<Netzteil>();
        private List<Betriebssystem> OSs = new List<Betriebssystem>();
        private SqlConnection connection;

        public Bauteile_Seite()
        {
            InitializeComponent();            
        }

        public void TabelleAnzeigen(string tabellenname, SqlConnection _connection)
        {
            connection = _connection;
            TxtBlkBauteil.Text = " " + tabellenname;
            using (var connection = new SqlConnection(Properties.Settings.Default.DBPCTeileConnectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                DataGridTextColumn textColumn;
                switch (tabellenname)
                {
                    case "CPU":
                        GetCPUList(cmd);                        
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Sockel";
                        textColumn.Binding = new Binding("sockel");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Kerne";
                        textColumn.Binding = new Binding("kerne");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Name";
                        textColumn.Binding = new Binding("name");
                        DataGridTabellen.Columns.Add(textColumn);
                        foreach (CPU cpu in CPUs)
                        {                            
                            DataGridTabellen.Items.Add(cpu);
                        }                        
                        break;
                    case "Arbeitsspeicher":
                        GetRAMList(cmd);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Anzahl Speichermodule";
                        textColumn.Binding = new Binding("anzahlSpeichermodule");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Speicherkapazität (GB)";
                        textColumn.Binding = new Binding("speicherkapazität");
                        DataGridTabellen.Columns.Add(textColumn);
                        foreach(Arbeitsspeicher arbeitsspeicher in RAMs)
                        {
                            DataGridTabellen.Items.Add(arbeitsspeicher);
                        }
                        break;
                    case "Prozessorlüfter":
                        GetCPULuefterList(cmd);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Sockel";
                        textColumn.Binding = new Binding("sockel");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Name";
                        textColumn.Binding = new Binding("name");
                        DataGridTabellen.Columns.Add(textColumn);
                        foreach(Prozessorlüfter prozessorlüfter in CPULuefter)
                        {
                            DataGridTabellen.Items.Add(prozessorlüfter);
                        }
                        break;
                    case "Mainboard":
                        GetMainboardList(cmd);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Formfaktor";
                        textColumn.Binding = new Binding("formfaktor");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Chipsatz";
                        textColumn.Binding = new Binding("chipsatz");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Name";
                        textColumn.Binding = new Binding("name");
                        DataGridTabellen.Columns.Add(textColumn);
                        foreach(Mainboard mainboard in Mainboards)
                        {                            
                            DataGridTabellen.Items.Add(mainboard);
                        }
                        break;
                    case "Grafikkarte":
                        GetGPUList(cmd);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Grafikchip";
                        textColumn.Binding = new Binding("grafikchip");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Speicherkapazität (GB)";
                        textColumn.Binding = new Binding("speicherkapazität");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Name";
                        textColumn.Binding = new Binding("name");
                        DataGridTabellen.Columns.Add(textColumn);
                        foreach(Grafikkarte grafikkarte in GPUs)
                        {
                            
                            DataGridTabellen.Items.Add(grafikkarte);
                        }
                        break;
                    case "HDD":
                        GetHDDList(cmd);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Bauform (Zoll)";
                        textColumn.Binding = new Binding("bauform");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Rotationsgeschwindigkeit (U/min)";
                        textColumn.Binding = new Binding("rotationsgeschwindigkeit");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Name";
                        textColumn.Binding = new Binding("name");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Kapazität (GB)";
                        textColumn.Binding = new Binding("kapazität");
                        DataGridTabellen.Columns.Add(textColumn);
                        foreach (HDD hdd in HDDs)
                        {
                            DataGridTabellen.Items.Add(hdd);
                        }
                        break;
                    case "SSD":
                        GetSSDList(cmd);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Chipsatz";
                        textColumn.Binding = new Binding("chipsatz");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Name";
                        textColumn.Binding = new Binding("name");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Kapazität (GB)";
                        textColumn.Binding = new Binding("kapazität");
                        DataGridTabellen.Columns.Add(textColumn);
                        foreach (SSD ssd in SSDs)
                        {
                            DataGridTabellen.Items.Add(ssd);
                        }
                        break;
                    case "Gehäuselüfter":
                        GetGHLuefterList(cmd);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Breite (mm)";
                        textColumn.Binding = new Binding("breite");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Farbe";
                        textColumn.Binding = new Binding("farbe");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Name";
                        textColumn.Binding = new Binding("name");
                        DataGridTabellen.Columns.Add(textColumn);
                        foreach(Gehäuselüfter gehäuselüfter in GHLuefter)
                        {
                            DataGridTabellen.Items.Add(gehäuselüfter);
                        }
                        break;
                    case "Gehäuse":
                        GetGHList(cmd);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Mainboard Formfaktor";
                        textColumn.Binding = new Binding("mainboardFormfaktor");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Netzteil Formfaktor";
                        textColumn.Binding = new Binding("netzteilFormfaktor");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Farbe";
                        textColumn.Binding = new Binding("farbe");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Name";
                        textColumn.Binding = new Binding("name");
                        DataGridTabellen.Columns.Add(textColumn);
                        foreach(Gehäuse gehäuse in GHs)
                        {
                            DataGridTabellen.Items.Add(gehäuse);
                        }
                        break;
                    case "Netzteil":
                        GetNTList(cmd);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Bauform";
                        textColumn.Binding = new Binding("bauform");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Leistung (Watt)";
                        textColumn.Binding = new Binding("leistung");
                        DataGridTabellen.Columns.Add(textColumn);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Name";
                        textColumn.Binding = new Binding("name");
                        DataGridTabellen.Columns.Add(textColumn);
                        foreach(Netzteil netzteil in NTs)
                        {
                            DataGridTabellen.Items.Add(netzteil);
                        }
                        break;
                    case "Betriebssystem":
                        GetOSList(cmd);
                        textColumn = new DataGridTextColumn();
                        textColumn.Header = "Architektur (Bit)";
                        textColumn.Binding = new Binding("architektur");
                        DataGridTabellen.Columns.Add(textColumn);
                        foreach(Betriebssystem betriebssystem in OSs)
                        {                            
                            DataGridTabellen.Items.Add(betriebssystem);
                        }                                                
                        TxtBlockHinweis.Text = "Hinweis: Betriebssysteme mit Architektur -1 können sowohl 32-, als auch 64-Bit-Betrieb.";                        
                        break;
                    default:
                        break;
                }
            }
        }



        private void GetOSList(SqlCommand cmd)
        {
            OSs.Clear();
            cmd.CommandText = "SELECT * FROM Betriebssystem";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Betriebssystem os = new Betriebssystem(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), (Int16)reader.GetInt32(4));
                    OSs.Add(os);
                }
                reader.Close();
            }
        }

        private void GetNTList(SqlCommand cmd)
        {
            NTs.Clear();
            cmd.CommandText = "SELECT * FROM Netzteil";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Netzteil nt = new Netzteil(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4), (Int16)reader.GetInt32(5), reader.GetString(6));
                    NTs.Add(nt);
                }
                reader.Close();
            }
        }
        private void GetGHList(SqlCommand cmd)
        {
            GHs.Clear();
            cmd.CommandText = "SELECT * FROM Gehause";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Gehäuse gh = new Gehäuse(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                    GHs.Add(gh);
                }
                reader.Close();
            }
        }

        private void GetGHLuefterList(SqlCommand cmd)
        {
            GHLuefter.Clear();
            cmd.CommandText = "SELECT * FROM Gehauseluefter";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Gehäuselüfter ghl = new Gehäuselüfter(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), (Int16)reader.GetInt32(4), reader.GetString(5), reader.GetString(6));
                    GHLuefter.Add(ghl);
                }
                reader.Close();
            }
        }

        private void GetSSDList(SqlCommand cmd)
        {
            SSDs.Clear();
            cmd.CommandText = "SELECT * FROM SSD";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    SSD ssd = new SSD(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), (Int16)reader.GetInt32(4), reader.GetString(5), reader.GetString(6));
                    SSDs.Add(ssd);
                }
                reader.Close();
            }
        }
        private void GetHDDList(SqlCommand cmd)
        {
            HDDs.Clear();
            cmd.CommandText = "SELECT * FROM HDD";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    HDD hdd = new HDD(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), (Int16)reader.GetInt32(4), reader.GetDouble(5), (Int16)reader.GetInt32(6), reader.GetString(7));
                    HDDs.Add(hdd);
                }
                reader.Close();
            }
        }

        private void GetGPUList(SqlCommand cmd)
        {
            GPUs.Clear();
            cmd.CommandText = "SELECT * FROM GPU";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Grafikkarte gpu = new Grafikkarte(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4), (Int16)reader.GetInt32(5), reader.GetString(6));
                    GPUs.Add(gpu);
                }
                reader.Close();
            }
        }

        private void GetMainboardList(SqlCommand cmd)
        {
            Mainboards.Clear();
            cmd.CommandText = "SELECT * FROM Mainboard";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Mainboard mb = new Mainboard(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    Mainboards.Add(mb);
                }
                reader.Close();
            }
        }

        private void GetCPULuefterList(SqlCommand cmd)
        {
            CPULuefter.Clear();
            cmd.CommandText = "SELECT * FROM CPULuefter";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Prozessorlüfter cpuLftr = new Prozessorlüfter(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4), reader.GetString(5));
                    CPULuefter.Add(cpuLftr);
                }
                reader.Close();
            }
        }

        private void GetRAMList(SqlCommand cmd)
        {
            RAMs.Clear();
            cmd.CommandText = "SELECT * FROM RAM";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Arbeitsspeicher ram = new Arbeitsspeicher(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), (Int16)reader.GetInt32(4), (Int16)reader.GetInt32(5));
                    RAMs.Add(ram);
                }
                reader.Close();
            }
        }

        private void GetCPUList(SqlCommand cmd)
        {
            CPUs.Clear();
            cmd.CommandText = "SELECT * FROM CPU";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CPU cpu = new CPU(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6));
                    CPUs.Add(cpu);
                }
                reader.Close();
            }
        }



        private void Add_Bauteil()
        {            
            object addition = DataGridTabellen.SelectedItem;
            WindowCollection windows = new WindowCollection();
            windows = Application.Current.Windows;
            Window[] WINs = new Window[2];
            windows.CopyTo(WINs, 0);
            PCKonfiguration oldWindow = (PCKonfiguration)WINs[0];            
            Produkt produkt = (Produkt)addition;
            if(produkt.preis < 0)
            {
                MessageBox.Show("Bauteil ist nicht verfügbar!", "WARNUNG!");
                return;
            }
            else
            {
                oldWindow.KonfigSchreiben(addition);
                MessageBox.Show("Neues Bauteil ausgewählt!", "Auswahl");
            }
            
        }
        

        private void DataGridBauteile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Add_Bauteil();
        }

    }
}
