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
        //private ArrayList wohnungen = new ArrayList();
        //private List<String> wohnungen = new List<string>();
        private List<Wohneinheit> wohnungen = new List<Wohneinheit>();
        private int anzahlWohnungen;
        private Int32 count = 0;
        public Wohnhaus(int anzahl)
        {
            this.anzahlWohnungen = anzahl;
            //for(int i = 0; i < this.anzahlWohnungen; i++)
            //{
            //    //wohnungen.Add("none");
            //    //this.wohnungen[i] = "none";
            //    Wohneinheit wh = new Wohneinheit();
            //    wh.Preis = 800;
            //    wh.Groesse = 120;
            //    wh.Lage = String.Empty;
            //    wh.Mieter = "none";

            //    wohnungen.Add(wh);
                
            //}
            
            
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
            //for(int i = 0; i < anzahlWohnungen && result == true;i++)
            //{
            //    if(Convert.ToString(wohnungen[i]) ==  neuerMieter)
            //    {
            //        result = false;
            //        break;
            //    }
            //}
            if(result == true)
            {
                foreach(Wohneinheit w in wohnungen)
                {
                    if(w.Mieter == neuerMieter )
                    {
                        result = false;
                        break;
                    }
                }
            }
            
            if(result == true )
            {
                Count++;
                for(int i = 0; i < anzahlWohnungen; i++)
                {
                    if(  wohnungen[i].Mieter == "none")
                    {
                        wohnungen[i].Mieter = neuerMieter;
                        break;
                    }
                }
            }
            return result;
        }
        public Boolean Ausziehen(String mieter)
        {
            Boolean result = false;
            for (int i = 0; i < anzahlWohnungen; i++)
            {
                if (Convert.ToString(this.wohnungen[i]) == mieter)
                {
                    this.wohnungen[i].Mieter = "none";
                    Count--;
                    result = true;

                }
            }

            return result;
        }
        public void AddWohneinheit(Wohneinheit wohneinheit)
        {
            wohnungen.Add(wohneinheit);
        }


    }
}