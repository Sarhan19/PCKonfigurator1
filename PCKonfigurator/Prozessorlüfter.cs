using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Prozessorlüfter : Produkt
    {
        internal String Kühlungsart;
        internal String Sockel;

        public Prozessorlüfter()
        {            
        }

        public Prozessorlüfter(Int32 _id, String _hersteller, String _typ, decimal _preis, String _kühlungsart, String _sockel)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Kühlungsart = _kühlungsart;
            this.Sockel = _sockel;
        }
    }
}
