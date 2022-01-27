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
            this.id = _id;
            this.hersteller = _hersteller;
            this.typ = _typ;
            this.preis = _preis;
            this.Formfaktor = _formfaktor;
            this.Chipsatz = _chipsatz;
            this.Name = _name;
        }

        public String formfaktor
        {
            get
            {
                return this.Formfaktor;
            }
            set
            {
                this.Formfaktor = value;
            }
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
            return id + "\t" + hersteller + "\t" + typ + "\t" + preis + "€\t" + Formfaktor + "\t" + Chipsatz + "\t" + Name;
        }

    }
}
