using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class SATA : Festplatte
    {
        internal Double Bauform;
        internal Int16 Rotationsgeschwindigkeit;

        public SATA()
        {            
        }

        public SATA(Int32 _id, String _hersteller, String _typ, decimal _preis, Double _bauform, Int16 _rotationsgeschwindigkeit)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Bauform = _bauform;
            this.Rotationsgeschwindigkeit = _rotationsgeschwindigkeit;
        }

        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + Bauform + "\t" + Rotationsgeschwindigkeit;
        }
    }
}
