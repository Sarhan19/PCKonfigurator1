using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Gehäuselüfter : Produkt
    {
        internal Double Breite;
        internal String Farbe;

        public Gehäuselüfter()
        {            
        }

        public Gehäuselüfter(Int32 _id, String _hersteller, String _typ, decimal _preis, Double _breite, String _farbe)
        {
                        this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Breite = _breite;
            this.Farbe = _farbe;
        }
    }
}
