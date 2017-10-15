using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormHaus
{
    public partial class Form1 : Form
    {
        Wohnhaus wohnaus = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String nm = textBoxNeuerMieter.Text; 
            if(wohnaus.Count >= 6)
            {
                MessageBox.Show("Haus voll");
            }
            else if(wohnaus.Einziehen(nm))
            {
                textBoxAnzahl.Text = wohnaus.Count.ToString();
            }
            else
            {
                MessageBox.Show("Mieter schon vorhanden");
            }
            
           
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(wohnaus.Ausziehen(textBoxAuszug.Text))
            {
                textBoxAnzahl.Text = wohnaus.Count.ToString();
            }
            
        }

        private void buttonCreateWohnhus_Click(object sender, EventArgs e)
        {
            wohnaus = new Wohnhaus(Convert.ToInt32(textBoxAnzahlWE.Text));
            groupBoxWohneinheit.Enabled = true;
        }

        private void buttonAddWohneinheit_Click(object sender, EventArgs e)
        {
            Wohneinheit wohneinheit = new Wohneinheit();
            wohneinheit.Preis = Convert.ToDecimal(textBoxPreis.Text);
            wohneinheit.Lage = textBoxLage.Text;
            wohneinheit.Groesse =  Convert.ToDouble( textBoxGroesse.Text);
            wohnaus.AddWohneinheit(wohneinheit);


            groupBoxMieter.Enabled = true;
        }
    }
}
