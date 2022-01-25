using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Netzteil : Produkt
    {
        internal String Bauform;
        internal Int16 Leistung;

        public Netzteil()
        {
        }

        public Netzteil(Int32 _id, String _hersteller, String _typ, decimal _preis, String _bauform, Int16 _leistung)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Bauform = _bauform;
            this.Leistung = _leistung;
        }

        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + Bauform + "\t" + Leistung;
        }
    }
}
