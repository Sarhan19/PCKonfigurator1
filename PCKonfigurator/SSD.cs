﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class SSD : Festplatte
    {
        internal String Chiptyp;

        public SSD()
        {
        }

        public SSD(Int32 _id, String _hersteller, String _typ, Int16 _preis, Int32 _kapazität, String _chiptyp)
        {
            this.ID = _id;
            this.Hersteller = _hersteller;
            this.Typ = _typ;
            this.Preis = _preis;
            this.Kapazität = _kapazität;
            this.Chiptyp = _chiptyp;
        }
    }
}
