using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        //ATTRIBUTI
        private string titolo;
        List<Evento> eventi;

        //PROPERTY

        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }


        //COSTRUTTORE

        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            eventi = new List<Evento>();
        }


        //METODI


        //aggiunge un evento
        public void AddEvento(Evento evento)
        {
            eventi.Add(evento);
        }
        //restituisce tutti gli eventi in una certa data
        public List<Evento> EventiInADate(DateTime data)
        {
            if (data is DateTime) 
            {
                string stringa = string.Empty;
                List<Evento> eventiInData = new List<Evento>();
                foreach (Evento evento in eventi)
                {
                    if (evento.Data == data)
                    {
                        //stringa += $"{evento.Titolo}\n";
                        eventiInData.Add(evento);
                    }

                }
                //return stringa;
                return eventiInData;
                 
            }
            else
            {
                throw new Exception("Mi serve una data");
            }
        }

        //restituisce tutti gli eventi nella lista
        public static string EventInList(List<Evento> list)
        {
            string stringa="";
            foreach (Evento evento in list)
            {
                stringa += evento.ToString();
            }
            return stringa;
        }

        //restituisce il numero di eventi nella lista
        public int NumeroEventi()
        {
            return eventi.Count;
        }


        //svuota tutto
        public void DeleteElements() { eventi.Clear(); }


        //metodo che restituisce il titolo del programma con i titoli e la data di ogni evento
        public string PrintEvents()
        {
            string stringa = "";

            stringa = $"Nome della programmazione degli eventi : {Titolo}\n";
            foreach(Evento evento in eventi)
            {
                stringa += evento.Data.ToShortDateString() + " - " + evento.Titolo + "\n";
            }

            return stringa;
        }
    }
}
