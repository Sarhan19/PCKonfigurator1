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
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.Breite = _breite;
            this.Farbe = _farbe;
        }

        public Double breite
        {
            get
            {
                return this.Breite;
            }
            set
            {
                this.Breite = value;
            }
        }

        public String farbe
        {
            get
            {
                return this.Farbe;
            }
            set
            {
                this.Farbe = value;
            }
        }

        public string WriteFile()
        {
            return id + "\t" + hersteller + "\t" + typ + "\t" + preis + "€\t" + Breite + "\t" + Farbe;
        }
    }
}
