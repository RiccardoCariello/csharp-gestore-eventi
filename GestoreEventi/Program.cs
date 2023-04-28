
using GestoreEventi;

Console.WriteLine("Benvenuto nel programma Gestore Eventi");
string titolo = string.Empty;
int capienzaMax;
string inputUtente;
ProgrammaEventi programmaEventi;
Conferenza conferenza;
int nEventi;
Evento evento;
DateTime data;

string relatore;
double prezzo;
try
{
    Console.WriteLine("Come vuoi che si chiami il tuo programma di eventi?");
    inputUtente = Console.ReadLine();
    programmaEventi = new ProgrammaEventi(inputUtente);
    Console.WriteLine("Quanti eventi vuoi inserire nel programma?");
    nEventi = int.Parse(Console.ReadLine());
    
    for (int i = 0; i < nEventi; i++)
    {
        //CHIEDO ALL'UTENTE I PARAMETRI
        try
        {
            Console.Write("\n\nInserisci il nome dell'evento! : ");
            titolo = Console.ReadLine();
            Console.Write("Inserisci la data! In formato (dd/mm/yyyy) :");
            data = DateTime.Parse(Console.ReadLine());

            Console.Write("Inserisci la capienza Massima : ");
            capienzaMax = int.Parse(Console.ReadLine());
       
            //ISTANZIO UN NUOVO OGGETTO CON I PARAMETRI RICEVUTI
            evento = new Evento(titolo, data, capienzaMax);
            programmaEventi.AddEvento(evento);
        }
        catch (InvalidDataException ex) 
        {
            Console.WriteLine(ex.Message);
            i--;
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
            i--;
        }

    }


    //CHIEDIAMO SE VOGLIAMO INSERIRE ANCHE DELLE CONFERENZE

    Console.WriteLine("\n\nQuante conferenze vuoi inserire nel programma?");
    nEventi = int.Parse(Console.ReadLine());

    for (int i = 0; i < nEventi; i++)
    {
        //CHIEDO ALL'UTENTE I PARAMETRI
        Console.Write("\n\nInserisci il nome della conferenza! : ");
        titolo = Console.ReadLine();
        Console.Write("Inserisci la data! In formato (dd/mm/yyyy) :");
        data = DateTime.Parse(Console.ReadLine());

        Console.Write("Inserisci la capienza Massima : ");
        capienzaMax = int.Parse(Console.ReadLine());
        Console.Write("Inserisci il nome del relatore : ");
        relatore = Console.ReadLine();
        Console.Write("Inserisci il prezzo : ");
        prezzo = double.Parse(Console.ReadLine());
        try
        {
            //ISTANZIO UN NUOVO OGGETTO CON I PARAMETRI RICEVUTI
            conferenza = new Conferenza(titolo, data, capienzaMax, relatore ,prezzo);
            programmaEventi.AddEvento(conferenza);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            i--;
        }

    }






    Console.Write("\n\nNumero di eventi : " + programmaEventi.NumeroEventi());

    Console.WriteLine("\n\nLista degli eventi : ");
    Console.WriteLine(programmaEventi.PrintEvents());

    for(int i = 0;i<1;i++)
    {
        try
        {
            Console.Write("\n\nInserisci una data e ti dirò quanti eventi ci sono quel giorno ( formato dd/mm/yyyy) :");
            data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(ProgrammaEventi.EventInList(programmaEventi.EventiInADate(data)));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            i--;
        }
    }

    /*
    Console.WriteLine("Meglio cancellare tutto ora.");
    programmaEventi.DeleteElements();
    Console.WriteLine(programmaEventi.PrintEvents() );
    */







    //STAMPO LE INFO DELL'EVENTO
    //Console.WriteLine(evento.ToString());

    /*   MILESTONE3
    ChiediSeVuoiPrenotare();

    RecapInfo();


    ChiediSeVuoiDisdire();

    RecapInfo();
    */



















    void RecapInfo()
    {
        Console.WriteLine($"La capienza Max del teatro è : {evento.CapienzaMax}\n" +
            $"I posti disponibili sono : {evento.PostiDisponibili}\n" +
            $"I posti prenotati sono : {evento.PostiPrenotati}");
    }

    /*
    void InputEvent(int numeroEventi)
    {
        for (int i = 0; i < numeroEventi; i++)
        {
            try
            {
                //CHIEDO ALL'UTENTE I PARAMETRI
                Console.WriteLine("Inserisci il nome dell'evento!");
                string titolo = Console.ReadLine();
                Console.WriteLine("Inserisci la data! In formato (dd/mm/yyyy");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Inserisci la capienza Massima");
                int capienzaMax = int.Parse(Console.ReadLine());
                //ISTANZIO UN NUOVO OGGETTO CON I PARAMETRI RICEVUTI
                Evento evento = new Evento(titolo, data, capienzaMax);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                i--;
            }
        }
    }
    */

    void ChiediSeVuoiDisdire()
    {
        do
        {
            Console.WriteLine("\nVuoi Disdire dei posti? S/N");
            inputUtente = (Console.ReadLine());
            inputUtente = inputUtente.ToLower();
        } while (inputUtente != "s" && inputUtente != "n");

        if (inputUtente == "s")
        {
            Console.WriteLine("Quanti posti vuoi disdire?");
            inputUtente = Console.ReadLine();
            evento.DisdiciPosti(int.Parse(inputUtente));
        }
        else { Console.WriteLine("Va bene!"); }
    }
    void ChiediSeVuoiPrenotare()
    {
        //Chiedo all'utente se vuole prenotare
        do
        {
            Console.WriteLine("\nVuoi Prenotare dei posti? S/N");
            inputUtente = (Console.ReadLine());
            inputUtente = inputUtente.ToLower();
        } while (inputUtente != "s" && inputUtente != "n");

        if (inputUtente == "s")
        {
            Console.WriteLine("Quanti posti vuoi prenotare?");
            inputUtente = Console.ReadLine();
            evento.PrenotaPosti(int.Parse(inputUtente));
        }
        else { Console.WriteLine("Va bene!"); }
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}





