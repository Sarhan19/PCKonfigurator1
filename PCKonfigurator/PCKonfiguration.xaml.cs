﻿using System;
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
using System.Windows.Shapes;

namespace PCKonfigurator
{
    /// <summary>
    /// Interaction logic for PCKonfiguration.xaml
    /// </summary>
    public partial class PCKonfiguration : Window
    {
        internal Konfiguration konfiguration;
        private SqlConnection connection;

        public PCKonfiguration()
        {
            InitializeComponent();
            konfiguration = new Konfiguration();
            OpenConnection();
            this.Closed += new EventHandler(PCKonfiguration_Closed);
        }

        private void PCKonfiguration_Closed(object sender, EventArgs e)
        {
            connection.Close();
        }
        private void OpenConnection()
        {
            connection = new SqlConnection(Properties.Settings.Default.DBPCTeileConnectionString);
            connection.Open();
        }

        private void Mainboard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Mainboard_Page = new Bauteile_Seite();
            Mainboard_Page.TabelleAnzeigen("Mainboard", connection);            
            MidGridFrame.NavigationService.Navigate(Mainboard_Page);
        }

        private void CPU_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite CPU_Page = new Bauteile_Seite();
            CPU_Page.TabelleAnzeigen("CPU", connection);
            MidGridFrame.NavigationService.Navigate(CPU_Page);
        }

        private void Grafikkarte_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Grafikkarte_Page = new Bauteile_Seite();
            Grafikkarte_Page.TabelleAnzeigen("Grafikkarte", connection);
            MidGridFrame.NavigationService.Navigate(Grafikkarte_Page);
        }

        private void Prozessorlüfter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Prozessorlüfter_Page = new Bauteile_Seite();
            Prozessorlüfter_Page.TabelleAnzeigen("Prozessorlüfter", connection);
            MidGridFrame.NavigationService.Navigate(Prozessorlüfter_Page);
        }

        private void Arbeitsspeicher_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Arbeitsspeicher_Page = new Bauteile_Seite();
            Arbeitsspeicher_Page.TabelleAnzeigen("Arbeitsspeicher", connection);
            MidGridFrame.NavigationService.Navigate(Arbeitsspeicher_Page);
        }

        private void Festplatte_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Festplatte_Page = new Bauteile_Seite();
            Festplatte_Page.TabelleAnzeigen("Festplatte", connection);
            MidGridFrame.NavigationService.Navigate(Festplatte_Page);
        }

        private void Gehäuse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Gehäuse_Page = new Bauteile_Seite();
            Gehäuse_Page.TabelleAnzeigen("Gehäuse", connection);
            MidGridFrame.NavigationService.Navigate(Gehäuse_Page);
        }

        private void Gehäuselüfter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Gehäuselüfter_Page = new Bauteile_Seite();
            Gehäuselüfter_Page.TabelleAnzeigen("Gehäuselüfter", connection);
            MidGridFrame.NavigationService.Navigate(Gehäuselüfter_Page);
        }

        private void Netzteil_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Netzteil_Page = new Bauteile_Seite();
            Netzteil_Page.TabelleAnzeigen("Netzteil", connection);
            MidGridFrame.NavigationService.Navigate(Netzteil_Page);
        }

        private void Betriebssystem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Betriebssystem_Page = new Bauteile_Seite();
            Betriebssystem_Page.TabelleAnzeigen("Betriebssystem", connection);
            MidGridFrame.NavigationService.Navigate(Betriebssystem_Page);
        }



        private void PackIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MidGridFrame.Content = null;            
        }

        private void BauteileAktualisieren()
        {
            decimal gesamtpreis = 0;
            if(konfiguration.Cpu != null)
            {
                CPUBeschreibung.Text = $"{konfiguration.Cpu.Hersteller} {konfiguration.Cpu.Typ}\n{konfiguration.Cpu.Name}";
                CPUBeschreibung.TextAlignment = TextAlignment.Center;
                gesamtpreis += konfiguration.Cpu.Preis;
            }
            else
            {
                CPUBeschreibung.Text = "";
            }
            if(konfiguration.ArbeitsSpeicher != null)
            {
                ArbeitsspeicherBeschreibung.Text = $"{konfiguration.ArbeitsSpeicher.Hersteller} {konfiguration.ArbeitsSpeicher.Typ}\n{konfiguration.ArbeitsSpeicher.Speicherkapazität}";
                ArbeitsspeicherBeschreibung.TextAlignment = TextAlignment.Center;
                gesamtpreis += konfiguration.ArbeitsSpeicher.Preis;
            }
            else
            {
                ArbeitsspeicherBeschreibung.Text = "";
            }
            if (konfiguration.BetriebsSystem != null)
            {
                BetriebssystemBeschreibung.Text = $"{konfiguration.BetriebsSystem.Hersteller} {konfiguration.BetriebsSystem.Typ}\n{konfiguration.BetriebsSystem.Architektur}";
                BetriebssystemBeschreibung.TextAlignment = TextAlignment.Center;
                gesamtpreis += konfiguration.BetriebsSystem.Preis;
            }
            else
            {
                BetriebssystemBeschreibung.Text = "";
            }
            if (konfiguration.FestPlatte != null)
            {
                FestplatteBeschreibung.Text = $"{konfiguration.FestPlatte.Hersteller} {konfiguration.FestPlatte.Typ}\n{konfiguration.FestPlatte.Kapazität}";
                FestplatteBeschreibung.TextAlignment = TextAlignment.Center;
                gesamtpreis += konfiguration.FestPlatte.Preis;
            }
            else
            {
                FestplatteBeschreibung.Text = "";
            }
            if (konfiguration.GeHäuse != null)
            {
                GehäuseBeschreibung.Text = $"{konfiguration.GeHäuse.Hersteller} {konfiguration.GeHäuse.Typ}\n{konfiguration.GeHäuse.Farbe}";
                GehäuseBeschreibung.TextAlignment = TextAlignment.Center;
                gesamtpreis += konfiguration.GeHäuse.Preis;
            }
            else
            {
                GehäuseBeschreibung.Text = "";
            }
            if (konfiguration.GehäuseLüfter != null)
            {
                GehäuselüfterBeschreibung.Text = $"{konfiguration.GehäuseLüfter.Hersteller} {konfiguration.GehäuseLüfter.Typ}\n{konfiguration.GehäuseLüfter.Farbe}";
                GehäuselüfterBeschreibung.TextAlignment = TextAlignment.Center;
                gesamtpreis += konfiguration.GehäuseLüfter.Preis;
            }
            else
            {
                GehäuselüfterBeschreibung.Text = "";
            }
            if (konfiguration.GrafikKarte != null)
            {
                GrafikkarteBeschreibung.Text = $"{konfiguration.GrafikKarte.Hersteller} {konfiguration.GrafikKarte.Typ}\n{konfiguration.GrafikKarte.Grafikchip}";
                GrafikkarteBeschreibung.TextAlignment = TextAlignment.Center;
                gesamtpreis += konfiguration.GrafikKarte.Preis;
            }
            else
            {
                GrafikkarteBeschreibung.Text = "";
            }
            if (konfiguration.MainBoard != null)
            {
                MainboardBeschreibung.Text = $"{konfiguration.MainBoard.Hersteller} {konfiguration.MainBoard.Typ}\n{konfiguration.MainBoard.Formfaktor}";
                MainboardBeschreibung.TextAlignment = TextAlignment.Center;
                gesamtpreis += konfiguration.MainBoard.Preis;
            }
            else
            {
                MainboardBeschreibung.Text = "";
            }
            if (konfiguration.NetzTeil != null)
            {
                NetzteilBeschreibung.Text = $"{konfiguration.NetzTeil.Hersteller} {konfiguration.NetzTeil.Typ}\n{konfiguration.NetzTeil.Leistung}";
                NetzteilBeschreibung.TextAlignment = TextAlignment.Center;
                gesamtpreis += konfiguration.NetzTeil.Preis;
            }
            else
            {
                NetzteilBeschreibung.Text = "";
            }
            if (konfiguration.ProzessorLüfter != null)
            {
                ProzessorlüfterBeschreibung.Text = $"{konfiguration.ProzessorLüfter.Hersteller} {konfiguration.ProzessorLüfter.Typ}\n{konfiguration.ProzessorLüfter.Kühlungsart}";
                ProzessorlüfterBeschreibung.TextAlignment = TextAlignment.Center;
                gesamtpreis += konfiguration.ProzessorLüfter.Preis;
            }
            else
            {
                ProzessorlüfterBeschreibung.Text = "";
            }            
            GesamtPreis.Text = Convert.ToString(gesamtpreis);
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

        private void BtnKonfigurationZurücksetzen_Click(object sender, RoutedEventArgs e)
        {
            konfiguration = new Konfiguration();
            BauteileAktualisieren();
        }
        
    }

}
