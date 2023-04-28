using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        //     ATTRIBUTI
        private string titolo;
        private DateTime data;
        private int capienzaMax;
        private int postiPrenotati;
        private int postiDisponibili;

        //     PROPERTIES
        public string Titolo
        {
            get { return titolo; }
            set
            {
                if ((value == "") || (value is not string))
                { throw new Exception("\n\nil titolo non può essere vuoto"); }
                else { titolo = value; }

            }
        }

        public DateTime Data
        {   get { return data; } 
            set { if (value < DateTime.Now) { 
                    throw new InvalidDataException("\n\nLa data dell'evento non può essere precedente alla data attuale");

                }
                else { data = value; }
            } 
        } 


        public int CapienzaMax
        {
            get { return capienzaMax; }            
        }

        public  int PostiPrenotati
        {
            get { return postiPrenotati;} 
        }

        public int PostiDisponibili
        {
            get { return postiDisponibili;}
        }
        
        
        //     COSTRUTTORE

        public Evento(string titolo , DateTime data , int postiMax)
        {
            if(postiMax < 0) { throw new Exception("\n\ni posti non possono essere meno di 0"); }
            else { this.capienzaMax = postiMax; }

            this.Data = data;
            this.Titolo = titolo;
            postiPrenotati = 0;
            postiDisponibili = capienzaMax;
        }

        //     METODI

        public void PrenotaPosti(int postiDaPrenotare)
        {
            if (postiDaPrenotare < 1) { throw new Exception("\n\nnon puoi prenotare meno di 1 posto"); }
            else if(postiDaPrenotare > postiDisponibili) { throw new Exception("\n\nPosti esauriti");}
            else 
            { 
                postiDisponibili = postiDisponibili - postiDaPrenotare;
                postiPrenotati += postiDaPrenotare;
            }
        }


        public void DisdiciPosti(int postiDaDisdire)
        {
            if (postiDaDisdire < 1) { throw new Exception("\n\nnon puoi disdire meno di 1 posto"); }
            else if (postiDaDisdire > postiPrenotati) { throw new Exception("\n\nImpossibile disdire più posti di quanti ce ne sono prenotati"); }
            else
            {
                postiDisponibili = postiDisponibili + postiDaDisdire;
                postiPrenotati -= postiDaDisdire;
            }
        }


        public override string ToString()
        {
            string stringa;
            //Data.ToString("dd/MM/yyyy");
            stringa = $"\n\nData : {Data.ToShortDateString()}\tTitolo : {Titolo}\t";

            return stringa;
        }
    }
}
