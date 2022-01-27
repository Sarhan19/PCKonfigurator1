using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Produkt
    {
        private Int32 ID;
        private String Hersteller;
        private String Typ;
        private decimal Preis;

        public Int32 id
        {
            get
            {
                return this.ID;
            }
            set
            {
                this.ID = value;
            }
        }

        public String hersteller
        {
            get
            {
                return this.Hersteller;
            }
            set
            {
                this.Hersteller = value;
            }
        }

        public String typ
        {
            get
            {
                return this.Typ;
            }
            set
            {
                this.Typ = value;
            }
        }

        public decimal preis
        {
            get
            {
                return this.Preis;
            }
            set
            {
                this.Preis = value;
            }
        }

    }
}
