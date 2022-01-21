using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class CPU : Produkt
    {
        internal String Sockel;
        internal SByte Kerne;
        internal String Name;

        public CPU()
        {
        }

        public CPU(Int32 _id, String _hersteller, String _typ, Int16 _preis, String _sockel, SByte _kerne, String _name)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Sockel = _sockel;
            this.Kerne = _kerne;
            this.Name = _name;
        }
    }
}
