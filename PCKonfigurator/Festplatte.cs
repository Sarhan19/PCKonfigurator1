using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Festplatte : Produkt
    {

        internal Int32 Kapazität;
        internal Double Bauform;
        internal Int16 Rotationsgeschwindigkeit;
        internal String Chiptyp;

        public Festplatte()
        {
        }

        public Festplatte(Int32 _id, String _hersteller, String _typ, decimal _preis, Int32 _kapazität, Double _bauform, Int16 _rotationsgeschwindigkeit, String _chiptyp)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Kapazität = _kapazität;
            this.Bauform = _bauform;
            this.Rotationsgeschwindigkeit = _rotationsgeschwindigkeit;
            this.Chiptyp = _chiptyp;
        }

        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + Kapazität + "\t" + Bauform + "\t" + Rotationsgeschwindigkeit;
        }
    }
}
