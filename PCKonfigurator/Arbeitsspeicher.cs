using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Arbeitsspeicher : Produkt
    {
        internal SByte AnzahlSpeichermodule;
        internal SByte Speicherkapazität;

        public Arbeitsspeicher()
        {
        }

        public Arbeitsspeicher(Int32 _id, String _hersteller, String _typ, decimal _preis, SByte _anzahlSpeichermodule, SByte _speicherkapazität)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.AnzahlSpeichermodule = _anzahlSpeichermodule;
            this.Speicherkapazität = _speicherkapazität;
        }

        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + AnzahlSpeichermodule + "\t" + Speicherkapazität;
        }
    }
}
