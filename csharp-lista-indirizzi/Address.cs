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
        private int zipCode; 
        
        //CONSTRUCTOR

        public Address(string name, string surname, string street, string city, string province, int zipCode) 
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            SetZipCode(zipCode);

        }

        //GETTERS

        //SETTERS
        public void SetZipCode(int zipCode)
        {
            if (zipCode is int)
            {
                this.zipCode = zipCode;
                
            }
            else 
            {
                this.zipCode = 0;
                throw new ArgumentException("should insert a number", "zipCode"); 
            }
        }

        //METHODS

        public override string ToString()
        {
            string info = "------------- Address -------------\n";
            info += $"Name: {this.name}\n";
            info += $"Surname: {this.surname}\n";
            info += $"Street: {this.street}\n";
            info += $"City: {this.city}\n";
            info += $"Province: {this.province}\n";
            info += $"ZIP Code: {this.zipCode}\n";
            info += "-----------------------------------";
            return info;

        }
    }
}
