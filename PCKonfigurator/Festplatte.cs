using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Festplatte : Produkt
    {

        internal Int16 Kapazität;

        public Festplatte()
        {
        }

        public Festplatte(Int32 _id, String _hersteller, String _typ, decimal _preis, Int16 _kapazität)
        {
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.Kapazität = _kapazität;
        }

        public Int16 kapazität
        {
            get
            {
                return this.Kapazität;
            }
            set
            {
                this.Kapazität = value;
            }
        }
        
    }
}
