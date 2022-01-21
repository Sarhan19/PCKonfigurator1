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
            Mainboard_Page.TabelleAnzeigen("Mainboard");
            //MidGridFrame.Content = Mainboard_Page;
            MidGridFrame.NavigationService.Navigate(Mainboard_Page);
        }

        private void CPU_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite CPU_Page = new Bauteile_Seite();
            CPU_Page.TabelleAnzeigen("CPU");
            //MidGridFrame.Content = CPU_Page;
            MidGridFrame.NavigationService.Navigate(CPU_Page);
        }

        private void Grafikkarte_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Grafikkarte_Page = new Bauteile_Seite();
            Grafikkarte_Page.TabelleAnzeigen("Grafikkarte");
            //MidGridFrame.Content = Grafikkarte_Page;
            MidGridFrame.NavigationService.Navigate(Grafikkarte_Page);
        }

        private void Prozessorlüfter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Prozessorlüfter_Page = new Bauteile_Seite();
            Prozessorlüfter_Page.TabelleAnzeigen("Prozessorlüfter");
            //MidGridFrame.Content = Prozessorlüfter_Page;
            MidGridFrame.NavigationService.Navigate(Prozessorlüfter_Page);
        }

        private void Arbeitsspeicher_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Arbeitsspeicher_Page = new Bauteile_Seite();
            Arbeitsspeicher_Page.TabelleAnzeigen("Arbeitsspeicher");
            //MidGridFrame.Content = Arbeitsspeicher_Page;
            MidGridFrame.NavigationService.Navigate(Arbeitsspeicher_Page);
        }

        private void Festplatte_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Festplatte_Page = new Bauteile_Seite();
            Festplatte_Page.TabelleAnzeigen("Festplatte");
            //MidGridFrame.Content = Festplatte_Page;
            MidGridFrame.NavigationService.Navigate(Festplatte_Page);
        }

        private void Gehäuse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Gehäuse_Page = new Bauteile_Seite();
            Gehäuse_Page.TabelleAnzeigen("Gehäuse");
            //MidGridFrame.Content = Gehäuse_Page;
            MidGridFrame.NavigationService.Navigate(Gehäuse_Page);
        }

        private void Gehäuselüfter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Gehäuselüfter_Page = new Bauteile_Seite();
            Gehäuselüfter_Page.TabelleAnzeigen("Gehäuselüfter");
            //MidGridFrame.Content = Gehäuselüfter_Page;
            MidGridFrame.NavigationService.Navigate(Gehäuselüfter_Page);
        }

        private void Netzteil_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Netzteil_Page = new Bauteile_Seite();
            Netzteil_Page.TabelleAnzeigen("Netzteil");
            //MidGridFrame.Content = Netzteil_Page;
            MidGridFrame.NavigationService.Navigate(Netzteil_Page);
        }

        private void Betriebssystem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bauteile_Seite Betriebssystem_Page = new Bauteile_Seite();
            Betriebssystem_Page.TabelleAnzeigen("Betriebssystem");
            //MidGridFrame.Content = Betriebssystem_Page;
            MidGridFrame.NavigationService.Navigate(Betriebssystem_Page);
        }

        
        private void PackIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MidGridFrame.Content = null;
        }
    }

}
