using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Festplatte : Produkt
    {

        internal Int16 Kapazität;

        public Festplatte()
        {
        }

        public Festplatte(Int32 _id, String _hersteller, String _typ, decimal _preis, Int16 _kapazität)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Kapazität = _kapazität;
        }

        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + Kapazität + "\t";
        }
    }
}
