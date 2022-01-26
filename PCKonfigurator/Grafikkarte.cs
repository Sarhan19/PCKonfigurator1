using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Grafikkarte : Produkt
    {
        internal String Grafikchip;
        internal Int16 Speicherkapazität;
        internal String Name;

        public Grafikkarte()
        {
        }

        public Grafikkarte(Int32 _id, String _hersteller, String _typ, decimal _preis, String _grafikchip, Int16 _speicherkapazität, String _name)
        {
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.Grafikchip = _grafikchip;
            this.Speicherkapazität = _speicherkapazität;
            this.Name = _name;
        }

        public String grafikchip
        {
            get
            {
                return this.Grafikchip;
            }
            set
            {
                this.Grafikchip = value;
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
            return id + "\t" + hersteller + "\t" + typ + "\t" + preis + "€\t" + Grafikchip + "\t" + Speicherkapazität + "\t" + Name;
        }

    }
}
