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
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Sockel = _sockel;
            this.Name = _name;
        }
        public override string ToString()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t\t" + Preis + "€\t" + Sockel + "\t" + Name;
        }

        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + Sockel + "\t" + Name;
        }
    }
}
