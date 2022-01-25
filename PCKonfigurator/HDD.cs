using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class HDD : Festplatte
    {
        internal Double Bauform;
        internal Int16 Rotationsgeschwindigkeit;
        internal String Name;

        public HDD()
        {
        }

        public HDD(Int32 _id, String _hersteller, String _typ, decimal _preis, Int16 _kapazität, Double _bauform, Int16 _rotationsgeschwindigkeit, String _name)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Bauform = _bauform;
            this.Rotationsgeschwindigkeit = _rotationsgeschwindigkeit;
            this.Kapazität = _kapazität;
            this.Name = _name;
        }
        public override string ToString()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t\t" + Preis + "€\t" + Kapazität + "GB\t" + Bauform + "Z\t" + Rotationsgeschwindigkeit + "\t" + Name;
        }

        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + Kapazität + "GB\t" + Bauform + "\t" + Rotationsgeschwindigkeit + "\t" + Name;
        }
    }
}
