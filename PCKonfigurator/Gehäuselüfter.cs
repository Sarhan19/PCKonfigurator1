using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Gehäuselüfter : Produkt
    {
        internal Int16 Breite;
        internal String Farbe;
        internal String Name;

        public Gehäuselüfter()
        {
        }

        public Gehäuselüfter(Int32 _id, String _hersteller, String _typ, decimal _preis, Int16 _breite, String _farbe, String _name)
        {
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.Breite = _breite;
            this.Farbe = _farbe;
            this.Name = _name;
        }

        public Int16 breite
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

        public String name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }

        public string WriteFile()
        {
            return $"{id}\t{hersteller}\t{typ}\t{preis}€\t{Breite}\t{Farbe}\t{Name}";
        }
    }
}
