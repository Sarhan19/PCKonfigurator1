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

using System.Data.SqlClient;
using System.Data;

namespace PCKonfigurator
{
    /// <summary>
    /// Interaction logic for PCKonfiguration.xaml
    /// </summary>
    public partial class PCKonfiguration : Window
    {
        public PCKonfiguration()
        {
            InitializeComponent();            
        }
        

        //private void TabelleAnzeigen(string tabellenname)
        //{


        //    string selectTabelle = $"SELECT * FROM {tabellenname}";
        //    //SQLiteDataReader sqlite_datareader;
        //    //SQLiteCommand sqlite_cmd;
        //    //sqlite_cmd = conn.CreateCommand();
        //    //sqlite_cmd.CommandText = selectTabelle;

        //    //sqlite_datareader = sqlite_cmd.ExecuteReader();
        //    //while (sqlite_datareader.Read())
        //    //{
        //    //    string myreader = sqlite_datareader.GetString(0);
        //    //    //Console.WriteLine(myreader);
        //    //    ListBoxItem newItem = new ListBoxItem();
        //    //    newItem.Content = myreader;
        //    //    KFZListBox.Items.Add(newItem);
        //    //}
        //    //conn.Close();
        //}

        

        private void Mainboard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Mainboard_Page = new Bauteile_Seite();
            Mainboard_Page.TabelleAnzeigen("Mainboard", connection);
            //MidGridFrame.Content = Mainboard_Page;
            MidGridFrame.NavigationService.Navigate(Mainboard_Page);
        }

        private void CPU_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite CPU_Page = new Bauteile_Seite();
            CPU_Page.TabelleAnzeigen("CPU", connection);
            //MidGridFrame.Content = CPU_Page;
            MidGridFrame.NavigationService.Navigate(CPU_Page);
        }

        private void Grafikkarte_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Grafikkarte_Page = new Bauteile_Seite();
            Grafikkarte_Page.TabelleAnzeigen("Grafikkarte", connection);
            //MidGridFrame.Content = Grafikkarte_Page;
            MidGridFrame.NavigationService.Navigate(Grafikkarte_Page);
        }

        private void Prozessorlüfter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Prozessorlüfter_Page = new Bauteile_Seite();
            Prozessorlüfter_Page.TabelleAnzeigen("Prozessorlüfter", connection);
            //MidGridFrame.Content = Prozessorlüfter_Page;
            MidGridFrame.NavigationService.Navigate(Prozessorlüfter_Page);
        }

        private void Arbeitsspeicher_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Arbeitsspeicher_Page = new Bauteile_Seite();
            Arbeitsspeicher_Page.TabelleAnzeigen("Arbeitsspeicher", connection);
            //MidGridFrame.Content = Arbeitsspeicher_Page;
            MidGridFrame.NavigationService.Navigate(Arbeitsspeicher_Page);
        }

        private void Festplatte_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Festplatte_Page = new Bauteile_Seite();
            Festplatte_Page.TabelleAnzeigen("Festplatte", connection);
            //MidGridFrame.Content = Festplatte_Page;
            MidGridFrame.NavigationService.Navigate(Festplatte_Page);
        }

        private void Gehäuse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Gehäuse_Page = new Bauteile_Seite();
            Gehäuse_Page.TabelleAnzeigen("Gehäuse", connection);
            //MidGridFrame.Content = Gehäuse_Page;
            MidGridFrame.NavigationService.Navigate(Gehäuse_Page);
        }

        private void Gehäuselüfter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Gehäuselüfter_Page = new Bauteile_Seite();
            Gehäuselüfter_Page.TabelleAnzeigen("Gehäuselüfter", connection);
            //MidGridFrame.Content = Gehäuselüfter_Page;
            MidGridFrame.NavigationService.Navigate(Gehäuselüfter_Page);
        }

        private void Netzteil_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Netzteil_Page = new Bauteile_Seite();
            Netzteil_Page.TabelleAnzeigen("Netzteil", connection);
            //MidGridFrame.Content = Netzteil_Page;
            MidGridFrame.NavigationService.Navigate(Netzteil_Page);
        }

        private void Betriebssystem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Betriebssystem_Page = new Bauteile_Seite();
            Betriebssystem_Page.TabelleAnzeigen("Betriebssystem", connection);
            //MidGridFrame.Content = Betriebssystem_Page;
            MidGridFrame.NavigationService.Navigate(Betriebssystem_Page);
        }

        
        private void PackIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MidGridFrame.Content = null;
            //BauteileAktualisieren();
        }

        private void BauteileAktualisieren()
        {   
            if(konfiguration.Cpu != null)
            {
                CPUBeschreibung.Text = $"{konfiguration.Cpu.Hersteller} {konfiguration.Cpu.Typ}\n{konfiguration.Cpu.Name}";
                CPUBeschreibung.TextAlignment = TextAlignment.Center;
            }
            if(konfiguration.ArbeitsSpeicher != null)
            {
                ArbeitsspeicherBeschreibung.Text = $"{konfiguration.ArbeitsSpeicher.Hersteller} {konfiguration.ArbeitsSpeicher.Typ}\n{konfiguration.ArbeitsSpeicher.Speicherkapazität}";
                ArbeitsspeicherBeschreibung.TextAlignment = TextAlignment.Center;
            }
            if(konfiguration.BetriebsSystem != null)
            {
                BetriebssystemBeschreibung.Text = $"{konfiguration.BetriebsSystem.Hersteller} {konfiguration.BetriebsSystem.Typ}\n{konfiguration.BetriebsSystem.Architektur}";
                BetriebssystemBeschreibung.TextAlignment = TextAlignment.Center;
            }
            if(konfiguration.FestPlatte != null)
            {
                FestplatteBeschreibung.Text = $"{konfiguration.FestPlatte.Hersteller} {konfiguration.FestPlatte.Typ}\n{konfiguration.FestPlatte.Kapazität}";
                FestplatteBeschreibung.TextAlignment = TextAlignment.Center;
            }
            if(konfiguration.GeHäuse != null)
            {
                GehäuseBeschreibung.Text = $"{konfiguration.GeHäuse.Hersteller} {konfiguration.GeHäuse.Typ}\n{konfiguration.GeHäuse.Farbe}";
                GehäuseBeschreibung.TextAlignment = TextAlignment.Center;
            }
            if(konfiguration.GehäuseLüfter != null)
            {
                GehäuselüfterBeschreibung.Text = $"{konfiguration.GehäuseLüfter.Hersteller} {konfiguration.GehäuseLüfter.Typ}\n{konfiguration.GehäuseLüfter.Farbe}";
                GehäuselüfterBeschreibung.TextAlignment = TextAlignment.Center;
            }
            if(konfiguration.GrafikKarte != null)
            {
                GrafikkarteBeschreibung.Text = $"{konfiguration.GrafikKarte.Hersteller} {konfiguration.GrafikKarte.Typ}\n{konfiguration.GrafikKarte.Grafikchip}";
                GrafikkarteBeschreibung.TextAlignment = TextAlignment.Center;
            }
            if(konfiguration.MainBoard != null)
            {
                MainboardBeschreibung.Text = $"{konfiguration.MainBoard.Hersteller} {konfiguration.MainBoard.Typ}\n{konfiguration.MainBoard.Formfaktor}";
                MainboardBeschreibung.TextAlignment = TextAlignment.Center;
            }
            if(konfiguration.NetzTeil != null)
            {
                NetzteilBeschreibung.Text = $"{konfiguration.NetzTeil.Hersteller} {konfiguration.NetzTeil.Typ}\n{konfiguration.NetzTeil.Leistung}";
                NetzteilBeschreibung.TextAlignment = TextAlignment.Center;
            }
            if(konfiguration.ProzessorLüfter != null)
            {
                ProzessorlüfterBeschreibung.Text = $"{konfiguration.ProzessorLüfter.Hersteller} {konfiguration.ProzessorLüfter.Typ}\n{konfiguration.ProzessorLüfter.Kühlungsart}";
                ProzessorlüfterBeschreibung.TextAlignment = TextAlignment.Center;
            }
        }

        public void KonfigSchreiben(object add)
        {
            Type type = add.GetType();
            if (type == typeof(CPU))
            {
                konfiguration.Cpu = (CPU)add;
            }
            else if (type == typeof(Arbeitsspeicher))
            {
                konfiguration.ArbeitsSpeicher = (Arbeitsspeicher)add;
            }
            else if (type == typeof(Betriebssystem))
            {
                konfiguration.BetriebsSystem = (Betriebssystem)add;
            }
            else if(type == typeof(Festplatte))
            {
                konfiguration.FestPlatte = (Festplatte)add;
            }
            else if(type == typeof(Gehäuse))
            {
                konfiguration.GeHäuse = (Gehäuse)add;
            }
            else if(type == typeof(Gehäuselüfter))
            {
                konfiguration.GehäuseLüfter = (Gehäuselüfter)add;
            }
            else if(type == typeof(Grafikkarte))
            {
                konfiguration.GrafikKarte = (Grafikkarte)add;
            }
            else if(type == typeof(Mainboard))
            {
                konfiguration.MainBoard = (Mainboard)add;
            }
            else if(type == typeof(Prozessorlüfter))
            {
                konfiguration.ProzessorLüfter = (Prozessorlüfter)add;
            }
            else if(type == typeof(Netzteil))
            {
                konfiguration.NetzTeil = (Netzteil)add;
            }
            else
            {
                // do nothing
            }
            BauteileAktualisieren();
        }
    }

}
