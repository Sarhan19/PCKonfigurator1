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
        internal Int32 Kerne;
        internal String Name;

        public CPU()
        {
        }

        public CPU(Int32 _id, String _hersteller, String _typ, decimal _preis, String _sockel, Int32 _kerne, String _name)
        {
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.Sockel = _sockel;
            this.Kerne = _kerne;
            this.Name = _name;
        }

        public String sockel
        {
            get
            {
                return this.Sockel;
            }
            set
            {
                this.Sockel = value;
            }
        }

        public Int32 kerne
        {
            get
            {
                return this.Kerne;
            }
            set
            {
                this.Kerne = value;
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
            return $"{id}\t{hersteller}\t{typ}\t{preis}€\t{Sockel}\t{Kerne}\t{Name}";
        }
    }
}
