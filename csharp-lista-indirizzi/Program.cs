/*

Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: 
vi chiedo di pensarci e di gestire come meglio crediate queste casistiche
 */

using csharp_lista_indirizzi;
using System;

List<Address> Addresses = new List<Address>();
StreamReader fileToRead = new StreamReader(File.OpenRead("C:\\Users\\DELL LATITUDE 7280\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\data\\addresses.csv"));
int lineNumber = 1;


    while (!fileToRead.EndOfStream)
    {    
        string line = fileToRead.ReadLine();

        if(lineNumber > 1) 
        {
        int zipCode = 0;
        string[] addressObjectAttributes = line.Split(",");

        try 
        { 
            zipCode = int.Parse(addressObjectAttributes[5]);
        }
        catch 
        { 
            Console.WriteLine("The ZIP code was in an incorrect format for the address:");
            Address newAddress = new Address(addressObjectAttributes[0], addressObjectAttributes[1], addressObjectAttributes[2], addressObjectAttributes[3], addressObjectAttributes[4]);
            Console.WriteLine(newAddress); 
            try 
            { 
            Console.Write("Please insert the ZIP Code in the right format or put a standard numeric value:");
            zipCode = int.Parse(Console.ReadLine());
            Address correctedAddress = new Address(addressObjectAttributes[0], addressObjectAttributes[1], addressObjectAttributes[2], addressObjectAttributes[3], addressObjectAttributes[4], zipCode);
            Addresses.Add(correctedAddress);
            }
            catch {
                Console.WriteLine("Come on don't make me reaeat myself");
                Console.Write("Please insert the ZIP Code in the right format or put a standard numeric value:");
                zipCode = int.Parse(Console.ReadLine());
                Address correctedAddress = new Address(addressObjectAttributes[0], addressObjectAttributes[1], addressObjectAttributes[2], addressObjectAttributes[3], addressObjectAttributes[4], zipCode);
                Addresses.Add(correctedAddress);
            }
        }
        try
            {
            Address newAddress = new Address(addressObjectAttributes[0], addressObjectAttributes[1], addressObjectAttributes[2], addressObjectAttributes[3], addressObjectAttributes[4], zipCode);

                
                lineNumber++;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        lineNumber++; 
    }
        
    foreach (Address address in Addresses)
    {
        Console.WriteLine(address);
    }


