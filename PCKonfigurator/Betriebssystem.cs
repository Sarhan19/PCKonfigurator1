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
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.Architektur = _architektur;
        }

        public Int16 architektur
        {
            get
            {
                return this.Architektur;
            }
            set
            {
                this.Architektur = value;
            }
        }

        public string WriteFile()
        {
            return id + "\t" + hersteller + "\t" + typ + "\t" + preis + "€\t" + Architektur;
        }
    }
}
