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
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.Kapazität = _kapazität;
            this.Chipsatz = _chiptyp;
            this.Name = _name;
        }

        public String chipsatz
        {
            get
            {
                return this.Chipsatz;
            }
            set
            {
                this.Chipsatz = value;
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
            return id + "\t" + hersteller + "\t" + typ + "\t" + preis + "€\t" + Kapazität + "GB\t" + Chipsatz + "\t" + Name;
        }
    }
}
