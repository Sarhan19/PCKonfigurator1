﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Produkt : IComparable<Produkt>
    {
        public Int32 ID;
        public String Hersteller;
        public String Typ;
        public decimal Preis;

        public int CompareTo(Produkt other)
        {
            return Preis.CompareTo(other.Preis);
        }
    }
}
