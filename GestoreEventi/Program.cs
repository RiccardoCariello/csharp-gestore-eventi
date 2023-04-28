
using GestoreEventi;

Console.WriteLine("Benvenuto nel programma Gestore Eventi");

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
    
    //CHIEDO SE VUOLE PRENOTARE DEI POSTI
    string inputUtente;
    
    //STAMPO LE INFO DELL'EVENTO
    Console.WriteLine(evento.ToString());


    //Chiedo all'utente se vuole prenotare
    do
    {
        Console.WriteLine("\nVuoi Prenotare dei posti? S/N");
        inputUtente =(Console.ReadLine());
        inputUtente = inputUtente.ToLower();
    } while(inputUtente!="s" && inputUtente!="n");

    if (inputUtente == "s")
    {
        Console.WriteLine("Quanti posti vuoi prenotare?");
            inputUtente = Console.ReadLine();
        evento.PrenotaPosti(int.Parse(inputUtente));
    }
    else { Console.WriteLine("Va bene!"); }

    RecapInfo();

    
    //chiedo se l'utente vuole disdire
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

    RecapInfo();



    void RecapInfo()
    {
        Console.WriteLine($"La capienza Max del teatro è : {evento.CapienzaMax}\n" +
            $"I posti disponibili sono : {evento.PostiDisponibili}\n" +
            $"I posti prenotati sono : {evento.PostiPrenotati}");
    }

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}





