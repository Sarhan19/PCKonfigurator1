using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCKonfigurator
{
    class Konfiguration
    {
        private CPU cpu;
        private Mainboard mainboard;
        private Prozessorlüfter prozessorlüfter;
        private Arbeitsspeicher arbeitsspeicher;
        private Grafikkarte grafikkarte;
        private Festplatte festplatte;
        private Gehäuse gehäuse;
        private Gehäuselüfter gehäuselüfter;
        private Netzteil netzteil;
        private Betriebssystem betriebssystem;
        private decimal preis;

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

        public decimal Preis
        {
            get
            {
                return this.preis;
            }
            set
            {
                this.preis = value;
            }
        }

        public Konfiguration()
        {
        }

    }
}
