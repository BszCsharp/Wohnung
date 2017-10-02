using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormHaus
{
    public class Wohnhaus
    {
        private String[] wohnung = new String[6];
        private Int32 count = 0;
        public Wohnhaus()
        {
            for(int i = 0; i < 6; i++)
            {
                wohnung[i] = "none";
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
            for(int i = 0; i < 6 && result == true;i++)
            {
                if(wohnung[i] == neuerMieter)
                {
                    result = false;
                    break;
                }
            }
            if(result == true )
            {
                Count++;
                for(int i = 0; i < 6;i++)
                {
                    if(wohnung[i] == "none")
                    {
                        wohnung[i] = neuerMieter;
                    }
                }
            }
            return result;
        }
        public Boolean Ausziehen(String mieter)
        {
            Boolean result = false;
            for(int i = 0; i < Count; i++)
            {
                if(this.wohnung[i] == mieter)
                {
                    this.wohnung[i] = "none";
                    Count--;
                    result = true;
                }
            }
            return result;
        }


    }
}