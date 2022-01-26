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
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.AnzahlSpeichermodule = _anzahlSpeichermodule;
            this.Speicherkapazität = _speicherkapazität;
        }

        public Int16 anzahlSpeichermodule
        {
            get
            {
                return this.AnzahlSpeichermodule;
            }
            set
            {
                this.AnzahlSpeichermodule = value;
            }
        }

        public Int16 speicherkapazität
        {
            get
            {
                return this.Speicherkapazität;
            }
            set
            {
                this.Speicherkapazität = value;
            }
        }

        public string WriteFile()
        {
            return id + "\t" + hersteller + "\t" + typ + "\t" + preis + "€\t" + AnzahlSpeichermodule + "\t" + Speicherkapazität;
        }
    }
}
