/*
nome repo: csharp-lista-indirizzi
Oggi esercitazione sui file, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe,
in particolare nel live-coding di oggi.

In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe 
anche rispetto un file di testo txt (a dire il vero quello che vi ho creato questa mattina non era un txt ma propriamente un csv), 
e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.

Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: 
vi chiedo di pensarci e di gestire come meglio crediate queste casistiche
 */

//creo una lista 'Addresses' di oggetti 'address'
using csharp_lista_indirizzi;

List<Address> Addresses = new List<Address>();
//devo aprire il file .csv
StreamReader fileToRead = new StreamReader(File.OpenRead("C:\\Users\\DELL LATITUDE 7280\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\data\\addresses.csv"));
while (!fileToRead.EndOfStream)
{
  
    Console.WriteLine(fileToRead.ReadLine());
}
//leggo ogni riga del file
//salvo ogni riga in una variabile string
//per ogni riga salvo in diverse variabili i valori separati dalla virgola
//questi valori sono gli attributi dell'oggetto 'address' che bisognerà inizializzare
//per ogni riga del file csv inizializzo un oggetto 'address'
//inserisco gli oggetti address nella lista
//stampo gli indirizzi della lista

//implementare exceptions
