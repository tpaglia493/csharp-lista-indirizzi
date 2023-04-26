using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Address
    {
        //ATTRIBUTES
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private string zipCode; 
        
        //CONSTRUCTOR

        public Address(string name, string surname, string street, string city, string province, string zipCode) 
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zipCode = zipCode;

        }

        //GETTERS

        //SETTERS

        //METHODS
    }
}
