using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Conferenza : Evento
    {
        private string relatore;
        private double prezzo;

        public string Relatore
        {
            get { return relatore; }
            set
            {
                if ((value == "") || (value is not string))
                { throw new Exception("\n\nil nome del relatore non può essere vuoto"); }
                else { relatore = value; }

            }
        }

        public double Prezzo
        {
            get { return prezzo; }
        }

        public Conferenza(string titolo , DateTime data , int postiMax, string relatore, double prezzo) : base (titolo,data ,postiMax)
        {
            this.relatore = relatore;
            this.prezzo = prezzo;


        }

        

        public override string ToString()
        {
            string stringa;
            stringa = base.ToString() + "- Relatore : " + Relatore + " - Prezzo : " + Prezzo.ToString("0.00");
            return stringa;
        }



    }
}
