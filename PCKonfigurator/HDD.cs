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
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.Bauform = _bauform;
            this.Rotationsgeschwindigkeit = _rotationsgeschwindigkeit;
            this.Kapazität = _kapazität;
            this.Name = _name;
        }

        public Double bauform
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

        public Int16 rotationsgeschwindigkeit
        {
            get
            {
                return this.Rotationsgeschwindigkeit;
            }
            set
            {
                this.Rotationsgeschwindigkeit = value;
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
            return id + "\t" + hersteller + "\t" + typ + "\t" + preis + "€\t" + Kapazität + "GB\t" + Bauform + "\t" + Rotationsgeschwindigkeit + "\t" + Name;
        }
    }
}
