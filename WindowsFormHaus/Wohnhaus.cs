using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsFormHaus
{
    public class Wohnhaus
    {
        //private String[] wohnungen = new String[6];
        // Version 2:: container durch ArrayList ersetzen
        private ArrayList wohnungen = new ArrayList();
        private int anzahlWohnungen;
        private Int32 count = 0;
        public Wohnhaus(int anzahl)
        {
            this.anzahlWohnungen = anzahl;
            for(int i = 0; i < this.anzahlWohnungen; i++)
            {
                wohnungen.Add("none");
                //this.wohnungen[i] = "none";
            }
            
            
        }
        public Int32 Count
        {
            get { return count;  }
            private set { count = value;  }
        }

        public Boolean Einziehen(String neuerMieter)
        {
            Boolean result = true;
            if (Count == 6) result = false;
            for(int i = 0; i < anzahlWohnungen && result == true;i++)
            {
                if(Convert.ToString(wohnungen[i]) ==  neuerMieter)
                {
                    result = false;
                    break;
                }
            }
            if(result == true )
            {
                Count++;
                for(int i = 0; i < anzahlWohnungen; i++)
                {
                    if( Convert.ToString( wohnungen[i]) == "none")
                    {
                        wohnungen[i] = neuerMieter;
                        break;
                    }
                }
            }
            return result;
        }
        public Boolean Ausziehen(String mieter)
        {
            Boolean result = false;
            for(int i = 0; i < anzahlWohnungen; i++)
            {
                if( Convert.ToString(this.wohnungen[i]) == mieter)
                {
                    this.wohnungen[i] = "none";
                    Count--;
                    result = true;
                }
            }
            return result;
        }


    }
}