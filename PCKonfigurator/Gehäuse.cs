using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Gehäuse : Produkt
    {
        internal String MainboardFormfaktor;
        internal String NetzteilFormfaktor;
        internal String Farbe;
        internal String Name;

        public Gehäuse()
        {
        }

        public Gehäuse(Int32 _id, String _hersteller, String _typ, decimal _preis, String _mainboardFormfaktor, String _netzteilFormfaktor, String _farbe, String _name)
        {
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.MainboardFormfaktor = _mainboardFormfaktor;
            this.NetzteilFormfaktor = _netzteilFormfaktor;
            this.Farbe = _farbe;
            this.Name = _name;
        }

        public String mainboardFormfaktor
        {
            get
            {
                return this.MainboardFormfaktor;
            }
            set
            {
                this.MainboardFormfaktor = value;
            }
        }

        public String netzteilFormfaktor
        {
            get
            {
                return this.NetzteilFormfaktor;
            }
            set
            {
                this.NetzteilFormfaktor = value;
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
                this.name = value;
            }
        }

        public string WriteFile()
        {
            return id + "\t" + hersteller + "\t" + typ + "\t" + preis + "€\t" + MainboardFormfaktor + "\t" + NetzteilFormfaktor + "\t" + Farbe + "\t" + Name;
        }

    }
}
