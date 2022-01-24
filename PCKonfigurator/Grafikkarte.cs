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
        internal SByte Speicherkapazität;

        public Grafikkarte()
        {            
        }

        public Grafikkarte(Int32 _id, String _hersteller, String _typ, decimal _preis, String _grafikchip, SByte _speicherkapazität)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Grafikchip = _grafikchip;
            this.Speicherkapazität = _speicherkapazität;
        }



    }
}
