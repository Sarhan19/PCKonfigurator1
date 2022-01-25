using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class SSD : Festplatte
    {
        internal String Chipsatz;
        internal String Name;

        public SSD()
        {
        }

        public SSD(Int32 _id, String _hersteller, String _typ, decimal _preis, Int16 _kapazität, String _chiptyp, String _name)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Kapazität = _kapazität;
            this.Chipsatz = _chiptyp;
            this.Name = _name;
        }
        public override string ToString()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t\t" + Preis + "€\t" + Kapazität + "GB\t" + Chipsatz + "\t" + Name;
        }
        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + Kapazität + "GB\t" + Chipsatz +"\t" + Name;
        }
    }
}
