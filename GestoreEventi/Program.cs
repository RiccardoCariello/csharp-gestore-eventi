
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
    
    do
    {
        Console.WriteLine("\nVuoi Prenotare dei posti? S/N");
        inputUtente =(Console.ReadLine());
        inputUtente = inputUtente.ToLower();
    } while(inputUtente!="s" && inputUtente!="n");

    if (inputUtente == "s")
    {

    }
    else { Console.WriteLine("Va bene!"); }






}
catch
{

}