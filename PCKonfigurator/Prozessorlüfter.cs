using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Prozessorlüfter : Produkt
    {
        internal String Sockel;
        internal String Name;

        public Prozessorlüfter()
        {
        }

        public Prozessorlüfter(Int32 _id, String _hersteller, String _typ, decimal _preis, String _sockel, String _name)
        {
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.Sockel = _sockel;
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
            return id + "\t" + hersteller + "\t" + typ + "\t" + preis + "€\t" + Sockel + "\t" + Name;
        }
    }
}
