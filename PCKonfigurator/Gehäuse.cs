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

        public Gehäuse()
        {            
        }

        public Gehäuse(Int32 _id, String _hersteller, String _typ, decimal _preis, String _mainboardFormfaktor, String _netzteilFormfaktor, String _farbe)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.MainboardFormfaktor = _mainboardFormfaktor;
            this.NetzteilFormfaktor = _netzteilFormfaktor;
            this.Farbe = _farbe;
        }


    }
}
