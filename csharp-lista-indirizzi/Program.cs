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

using csharp_lista_indirizzi;

List<Address> Addresses = new List<Address>();
StreamReader fileToRead = new StreamReader(File.OpenRead("C:\\Users\\DELL LATITUDE 7280\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\data\\addresses.csv"));
int lineNumber = 1;

try 
{ 
    while (!fileToRead.EndOfStream)
    {    
        string line = fileToRead.ReadLine();

        if(lineNumber > 1) 
        { 
       
        string[] addressObjectAttributes = line.Split(",");
            try
            {
                Address newAddress = new Address(addressObjectAttributes[0], addressObjectAttributes[1], addressObjectAttributes[2], addressObjectAttributes[3], addressObjectAttributes[4], addressObjectAttributes[5]);

                Addresses.Add(newAddress);
                lineNumber++;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        lineNumber++; 
    }
        
    foreach (Address address in Addresses)
    {
        Console.WriteLine(address);
    }

}catch(Exception e)
{
    Console.WriteLine($"{e.Message}"); 
}

