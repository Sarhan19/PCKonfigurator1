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
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Grafikchip = _grafikchip;
            this.Speicherkapazität = _speicherkapazität;
            this.Name = _name;
        }

        public override string ToString()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t\t" + Preis + "€\t" + Grafikchip + "\t" + Speicherkapazität + "\t" + Name;
        }

        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + Grafikchip + "\t" + Speicherkapazität + "\t" + Name;
        }

    }
}
