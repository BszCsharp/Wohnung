using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormHaus
{
    internal class Wohneinheit
    {
        private decimal preis;
        private double groesse;
        private string lage;
        private string mieter;

        public decimal Preis
        {
            get => preis; set => preis = value;
        }
        public double Groesse
        {
            get { return groesse; }
            set { groesse = value; }
        }
        public string Lage
        {
            get => lage; set => lage = value;
        }
        public string Mieter
        {
            get => mieter; set => mieter = value;
        }
    }
}