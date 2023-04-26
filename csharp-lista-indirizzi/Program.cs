/*

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
                int zipCode = int.Parse(addressObjectAttributes[5]);
                Address newAddress = new Address(addressObjectAttributes[0], addressObjectAttributes[1], addressObjectAttributes[2], addressObjectAttributes[3], addressObjectAttributes[4], zipCode);

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

