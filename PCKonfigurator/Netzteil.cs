using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Netzteil : Produkt
    {
        internal String Bauform;
        internal Int16 Leistung;
        internal String Name;

        public Netzteil()
        {
        }

        public Netzteil(Int32 _id, String _hersteller, String _typ, decimal _preis, String _bauform, Int16 _leistung, String _name)
        {
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.Bauform = _bauform;
            this.Leistung = _leistung;
            this.Name = _name;
        }


        public String bauform
        {
            get
            {
                return this.Bauform;
            }
            set
            {
                this.Bauform = value;
            }
        }

        public Int16 leistung
        {
            get
            {
                return this.Leistung;
            }
            set
            {
                this.Leistung = value;
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
            return $"{id}\t{hersteller}\t{typ}\t{preis}\t{Bauform}\t{Leistung}\t{Name}";
        }
    }
}
