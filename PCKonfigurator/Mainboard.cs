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
        internal String Name;

        public Mainboard()
        {
        }

        public Mainboard(Int32 _id, String _hersteller, String _typ, decimal _preis, String _formfaktor, String _chipsatz, String _name)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Formfaktor = _formfaktor;
            this.Chipsatz = _chipsatz;
            this.Name = _name;
        }
        public override string ToString()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t\t" + Preis + "€\t" + Formfaktor + "\t" + Chipsatz + "\t" + Name;
        }

        public string WriteFile()
        {
            return ID + "\t" + Hersteller + "\t" + Typ + "\t" + Preis + "€\t" + Formfaktor + "\t" + Chipsatz + "\t" + Name;
        }

    }
}
