﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Konfiguration
    {
        CPU cpu;
        Mainboard mainboard;
        Prozessorlüfter prozessorlüfter;
        Arbeitsspeicher arbeitsspeicher;
        Grafikkarte grafikkarte;
        Festplatte festplatte;
        Gehäuse gehäuse;
        Gehäuselüfter gehäuselüfter;
        Netzteil netzteil;
        Betriebssystem betriebssystem;
        decimal Preis;

        public CPU Cpu
        {
            get
            {
                return cpu;
            }
            set
            {
                this.cpu = value;
            }
        }

        public Mainboard MainBoard
        {
            get
            {
                return mainboard;
            }
            set
            {
                this.mainboard = value;
            }
        }

        public Prozessorlüfter ProzessorLüfter
        {
            get
            {
                return prozessorlüfter;
            }
            set
            {
                this.prozessorlüfter = value;
            }
        }

        public Arbeitsspeicher ArbeitsSpeicher
        {

            get
            {
                return arbeitsspeicher;
            }
            set
            {
                this.arbeitsspeicher = value;
            }
        }

        public Grafikkarte GrafikKarte
        {
            get
            {
                return grafikkarte;
            }
            set
            {
                this.grafikkarte = value;
            }
        }

        public Festplatte FestPlatte
        {
            get
            {
                return festplatte;
            }
            set
            {
                this.festplatte = value;
            }
        }

        public Gehäuse GeHäuse
        {
            get
            {
                return gehäuse;
            }
            set
            {
                this.gehäuse = value;
            }
        }

        public Gehäuselüfter GehäuseLüfter
        {
            get
            {
                return gehäuselüfter;
            }
            set
            {
                this.gehäuselüfter = value;
            }
        }

        public Netzteil NetzTeil
        {
            get
            {
                return netzteil;
            }
            set
            {
                this.netzteil = value;
            }
        }

        public Betriebssystem BetriebsSystem
        {
            get
            {
                return betriebssystem;
            }
            set
            {
                this.betriebssystem = value;
            }
        }

        public Konfiguration()
        {
        }

        internal Konfiguration(CPU _cpu, Mainboard _mainboard, Prozessorlüfter _prozessorlüfter, Arbeitsspeicher _arbeitsspeicher, Grafikkarte _grafikkarte, Festplatte _festplatte, Gehäuse _gehäuse, Gehäuselüfter _gehäuselüfter, Netzteil _netzteil, Betriebssystem _betriebssystem)
        {
            this.cpu = _cpu;
            this.mainboard = _mainboard;
            this.prozessorlüfter = _prozessorlüfter;
            this.arbeitsspeicher = _arbeitsspeicher;
            this.grafikkarte = _grafikkarte;
            this.festplatte = _festplatte;
            this.gehäuse = _gehäuse;
            this.gehäuselüfter = _gehäuselüfter;
            this.netzteil = _netzteil;
            this.betriebssystem = _betriebssystem;
        }

    }
}
