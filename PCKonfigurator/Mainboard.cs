using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Mainboard : Produkt
    {
        internal String Formfaktor;
        internal String Chipsatz;

        public Mainboard()
        {            
        }

        public Mainboard(Int32 _id, String _hersteller, String _typ, Int16 _preis, String _formfaktor, String _chipsatz)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Formfaktor = _formfaktor;
            this.Chipsatz = _chipsatz;
        }
    }
}
