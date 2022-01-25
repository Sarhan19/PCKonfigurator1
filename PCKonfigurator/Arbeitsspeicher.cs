using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Arbeitsspeicher : Produkt
    {
        internal Int16 AnzahlSpeichermodule;
        internal Int16 Speicherkapazität;

        public Arbeitsspeicher()
        {
        }

        public Arbeitsspeicher(Int32 _id, String _hersteller, String _typ, decimal _preis, Int16 _anzahlSpeichermodule, Int16 _speicherkapazität)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.AnzahlSpeichermodule = _anzahlSpeichermodule;
            this.Speicherkapazität = _speicherkapazität;
        }
        public override string ToString()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t\t" + Preis + "€\t" + AnzahlSpeichermodule + "\t" + Speicherkapazität + "GB";
        }

        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + AnzahlSpeichermodule + "\t" + Speicherkapazität;
        }
    }
}
