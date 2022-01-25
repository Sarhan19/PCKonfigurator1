using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Betriebssystem : Produkt
    {
        internal Int16 Architektur;

        public Betriebssystem()
        {            
        }

        public Betriebssystem(Int32 _id, String _hersteller, String _typ, decimal _preis, Int16 _architektur)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Architektur = _architektur;
        }

        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + Architektur;
        }
    }
}
