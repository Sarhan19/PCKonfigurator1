﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
using Microsoft.Win32;

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
            konfiguration.Preis = 0;
            int cart = 0;

            if(konfiguration.Cpu != null)
            {
                CPUBeschreibung.Text = $"{konfiguration.Cpu.Hersteller} {konfiguration.Cpu.Typ}\n{konfiguration.Cpu.Name}";
                CPUBeschreibung.TextAlignment = TextAlignment.Center;
                konfiguration.Preis += konfiguration.Cpu.Preis;
                cart++;
            }
            else
            {
                CPUBeschreibung.Text = "";
            }
            if(konfiguration.ArbeitsSpeicher != null)
            {
                ArbeitsspeicherBeschreibung.Text = $"{konfiguration.ArbeitsSpeicher.Hersteller} {konfiguration.ArbeitsSpeicher.Typ}\n{konfiguration.ArbeitsSpeicher.Speicherkapazität}";
                ArbeitsspeicherBeschreibung.TextAlignment = TextAlignment.Center;
                konfiguration.Preis += konfiguration.ArbeitsSpeicher.Preis;
                cart++;
            }
            else
            {
                ArbeitsspeicherBeschreibung.Text = "";
            }
            if (konfiguration.BetriebsSystem != null)
            {
                BetriebssystemBeschreibung.Text = $"{konfiguration.BetriebsSystem.Hersteller} {konfiguration.BetriebsSystem.Typ}\n{konfiguration.BetriebsSystem.Architektur}";
                BetriebssystemBeschreibung.TextAlignment = TextAlignment.Center;
                konfiguration.Preis += konfiguration.BetriebsSystem.Preis;
                cart++;
            }
            else
            {
                BetriebssystemBeschreibung.Text = "";
            }
            if (konfiguration.FestPlatte != null)
            {
                FestplatteBeschreibung.Text = $"{konfiguration.FestPlatte.Hersteller} {konfiguration.FestPlatte.Typ}\n{konfiguration.FestPlatte.Kapazität}";
                FestplatteBeschreibung.TextAlignment = TextAlignment.Center;
                konfiguration.Preis += konfiguration.FestPlatte.Preis;
                cart++;
            }
            else
            {
                FestplatteBeschreibung.Text = "";
            }
            if (konfiguration.GeHäuse != null)
            {
                GehäuseBeschreibung.Text = $"{konfiguration.GeHäuse.Hersteller} {konfiguration.GeHäuse.Typ}\n{konfiguration.GeHäuse.Farbe}";
                GehäuseBeschreibung.TextAlignment = TextAlignment.Center;
                konfiguration.Preis += konfiguration.GeHäuse.Preis;
                cart++;
            }
            else
            {
                GehäuseBeschreibung.Text = "";
            }
            if (konfiguration.GehäuseLüfter != null)
            {
                GehäuselüfterBeschreibung.Text = $"{konfiguration.GehäuseLüfter.Hersteller} {konfiguration.GehäuseLüfter.Typ}\n{konfiguration.GehäuseLüfter.Farbe}";
                GehäuselüfterBeschreibung.TextAlignment = TextAlignment.Center;
                konfiguration.Preis += konfiguration.GehäuseLüfter.Preis;
                cart++;
            }
            else
            {
                GehäuselüfterBeschreibung.Text = "";
            }
            if (konfiguration.GrafikKarte != null)
            {
                GrafikkarteBeschreibung.Text = $"{konfiguration.GrafikKarte.Hersteller} {konfiguration.GrafikKarte.Typ}\n{konfiguration.GrafikKarte.Grafikchip}";
                GrafikkarteBeschreibung.TextAlignment = TextAlignment.Center;
                konfiguration.Preis += konfiguration.GrafikKarte.Preis;
                cart++;
            }
            else
            {
                GrafikkarteBeschreibung.Text = "";
            }
            if (konfiguration.MainBoard != null)
            {
                MainboardBeschreibung.Text = $"{konfiguration.MainBoard.Hersteller} {konfiguration.MainBoard.Typ}\n{konfiguration.MainBoard.Formfaktor}";
                MainboardBeschreibung.TextAlignment = TextAlignment.Center;
                konfiguration.Preis += konfiguration.MainBoard.Preis;
                cart++;
            }
            else
            {
                MainboardBeschreibung.Text = "";
            }
            if (konfiguration.NetzTeil != null)
            {
                NetzteilBeschreibung.Text = $"{konfiguration.NetzTeil.Hersteller} {konfiguration.NetzTeil.Typ}\n{konfiguration.NetzTeil.Leistung}";
                NetzteilBeschreibung.TextAlignment = TextAlignment.Center;
                konfiguration.Preis += konfiguration.NetzTeil.Preis;
                cart++;
            }
            else
            {
                NetzteilBeschreibung.Text = "";
            }
            if (konfiguration.ProzessorLüfter != null)
            {
                ProzessorlüfterBeschreibung.Text = $"{konfiguration.ProzessorLüfter.Hersteller} {konfiguration.ProzessorLüfter.Name}\n{konfiguration.ProzessorLüfter.Typ}";
                ProzessorlüfterBeschreibung.TextAlignment = TextAlignment.Center;
                konfiguration.Preis += konfiguration.ProzessorLüfter.Preis;
                cart++;
            }
            else
            {
                ProzessorlüfterBeschreibung.Text = "";
            }            
            GesamtPreis.Text = Convert.ToString(konfiguration.Preis);
            EinkaufswagenAnzahl.Text = Convert.ToString(cart);
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

        private void BtnKonfigurationSpeichern_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            string dateiname = "";           
            if (saveFileDialog.ShowDialog() == true)
            {
                dateiname = saveFileDialog.FileName;
            }
            if(dateiname != string.Empty)
            {
                StreamWriter sw;
                sw = new StreamWriter(dateiname, false);

                List<string> dateiinhalte = KonfigurationslisteErzeugen();

                foreach (string s in dateiinhalte)
                {
                    sw.WriteLine(s);
                }

                sw.Flush();
                sw.Close();
            }            
        }

        private void BtnKonfigurationLaden_Click(object sender, RoutedEventArgs e)
        {
            konfiguration = new Konfiguration();
            BauteileAktualisieren();

            string dateiname = "";
            List<string> dateiinhalt = new List<string>();
            
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";


            if (openFileDialog.ShowDialog() == true)
            {
                dateiname = openFileDialog.FileName;
            }
                        
            if (dateiname != string.Empty)
            {
                int i = 0;
                foreach (string s in File.ReadLines(dateiname))
                {
                    dateiinhalt.Add(s);
                    if (dateiinhalt[0] != "PC-Konfiguration" && dateiinhalt[1] != "================")
                    {
                        MessageBox.Show("Keine gültige Konfigurationsdatei!");
                        break;
                    }
                }
                for (i = 0; i < 2; i++)
                {
                    dateiinhalt.RemoveAt(0);
                }
                for (i = 0; i < dateiinhalt.Count; i++)
                {
                    dateiinhalt[i] = dateiinhalt[i].Split(new string[] { ": " }, StringSplitOptions.None)[1];
                }
                for (i = 0; i < dateiinhalt.Count-1; i++)
                {
                    string[] bauteil = dateiinhalt[i].Split(new string[] { "\t" }, StringSplitOptions.None);

                    if (dateiinhalt[i] != "")
                    {
                        Int16 id = Convert.ToInt16(bauteil[0]);
                        string hersteller = bauteil[1];
                        string typ = bauteil[2];
                        decimal preis = Convert.ToDecimal(bauteil[3].Split('€')[0]);
                        if (i == 0)
                        {
                            KonfigSchreiben(new Arbeitsspeicher(id, hersteller, typ, preis, Convert.ToInt16(bauteil[4]), Convert.ToInt16(bauteil[5])));
                        }
                        if (i == 1)
                        {
                            KonfigSchreiben(new Betriebssystem(id, hersteller, typ, preis, Convert.ToInt16(bauteil[4])));
                        }
                        if (i == 2)
                        {
                            KonfigSchreiben(new CPU(id, hersteller, typ, preis, bauteil[4], Convert.ToInt16(bauteil[5]), bauteil[6]));
                        }
                        if (i == 3)
                        {
                            KonfigSchreiben(new Festplatte(id, hersteller, typ, preis, Convert.ToInt16(bauteil[4])));
                        }
                        if (i == 4)
                        {
                            KonfigSchreiben(new Gehäuse(id, hersteller, typ, preis, bauteil[4], bauteil[5], bauteil[6]));
                        }
                        if (i == 5)
                        {
                            KonfigSchreiben(new Gehäuselüfter(id, hersteller, typ, preis, Convert.ToDouble(bauteil[4]), bauteil[5]));
                        }
                        if (i == 6)
                        {
                            KonfigSchreiben(new Grafikkarte(id, hersteller, typ, preis, bauteil[4], Convert.ToInt16(bauteil[5]), bauteil[6]));
                        }
                        if (i == 7)
                        {
                            KonfigSchreiben(new Mainboard(id, hersteller, typ, preis, bauteil[4], bauteil[5], bauteil[6]));
                        }
                        if (i == 8)
                        {
                            KonfigSchreiben(new Netzteil(id, hersteller, typ, preis, bauteil[4], Convert.ToInt16(bauteil[5])));
                        }
                        if (i == 9)
                        {
                            KonfigSchreiben(new Prozessorlüfter(id, hersteller, typ, preis, bauteil[4], bauteil[5]));
                        }
                        
                    }

                }
            }
            
        }


        private List<string> KonfigurationslisteErzeugen()
        {
            List<string> dateiinhalte = new List<string>();
            string content = "";
            dateiinhalte.Add("PC-Konfiguration");
            dateiinhalte.Add("================");
            content = "Arbeitsspeicher: ";
            if (konfiguration.ArbeitsSpeicher != null)
            {
                content += konfiguration.ArbeitsSpeicher.WriteFile();
            }
            dateiinhalte.Add(content);
            content = "Betriebssystem: ";
            if (konfiguration.BetriebsSystem != null)
            {
                content += konfiguration.BetriebsSystem.WriteFile();
            }
            dateiinhalte.Add(content);
            content = "CPU: ";
            if (konfiguration.Cpu != null)
            {
                content += konfiguration.Cpu.WriteFile();
            }
            dateiinhalte.Add(content);
            if (konfiguration.FestPlatte != null)
            {
                dateiinhalte.Add($"{konfiguration.FestPlatte.GetType()}: {konfiguration.FestPlatte.WriteFile()}");
            }
            else
            {
                dateiinhalte.Add("Festplatte: ");
            }
            content = "Gehäuse: ";
            if (konfiguration.GeHäuse != null)
            {
                content += konfiguration.GeHäuse.WriteFile();
            }
            dateiinhalte.Add(content);
            content = "Gehäuselüfter: ";
            if (konfiguration.GehäuseLüfter != null)
            {
                content += konfiguration.GehäuseLüfter.WriteFile();
            }
            dateiinhalte.Add(content);
            content = "Grafikkarte: ";
            if (konfiguration.GrafikKarte != null)
            {
                content += konfiguration.GrafikKarte.WriteFile();
            }
            dateiinhalte.Add(content);
            content = "Mainboard: ";
            if (konfiguration.MainBoard != null)
            {
                content += konfiguration.MainBoard.WriteFile();
            }
            dateiinhalte.Add(content);
            content = "Netzteil: ";
            if (konfiguration.NetzTeil != null)
            {
                content += konfiguration.NetzTeil.WriteFile();
            }
            dateiinhalte.Add(content);
            content = "Prozessorlüfter: ";
            if (konfiguration.ProzessorLüfter != null)
            {
                content += konfiguration.ProzessorLüfter.WriteFile();
            }
            dateiinhalte.Add(content);
            content = $"Gesamtpreis: {Convert.ToString(konfiguration.Preis)}";
            dateiinhalte.Add(content);

            return dateiinhalte;
        }

        private void BtnKaufen_Click(object sender, RoutedEventArgs e)
        {            
            MessageBoxResult result = MessageBox.Show("Möchten Sie Ihre Konfiguration kaufen?", "Checkout", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                MessageBox.Show($"Gesamtpreis: {konfiguration.Preis} €\nAnzahl der Bauteile: {EinkaufswagenAnzahl.Text}", "Total");
                konfiguration = new Konfiguration();
                BauteileAktualisieren();                
            }
            else
            {
                
            }
        }

        private void Arbeitsspeicher_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            konfiguration.ArbeitsSpeicher = null;
            BauteileAktualisieren();
        }

        private void Betriebssystem_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            konfiguration.BetriebsSystem = null;
            BauteileAktualisieren();
        }

        private void Mainboard_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            konfiguration.MainBoard = null;
            BauteileAktualisieren();
        }

        private void CPU_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            konfiguration.Cpu = null;
            BauteileAktualisieren();
        }

        private void Grafikkarte_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            konfiguration.GrafikKarte = null;
            BauteileAktualisieren();
        }

        private void Prozessorlüfter_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            konfiguration.ProzessorLüfter = null;
            BauteileAktualisieren();
        }

        private void Festplatte_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            konfiguration.FestPlatte = null;
            BauteileAktualisieren();
        }

        private void Gehäuase_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            konfiguration.GeHäuse = null;
            BauteileAktualisieren();
        }

        private void Gehäuselüfter_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            konfiguration.GehäuseLüfter = null;
            BauteileAktualisieren();
        }

        private void Netzteil_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            konfiguration.NetzTeil = null;
            BauteileAktualisieren();
        }
            
    }

}
