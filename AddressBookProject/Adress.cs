using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    internal class Adress
    {
        string _name;
        string _streetAddress;
        string _telephone;

        public Adress()
        {
        }

        public Adress(string name, string streetAddress, string telephone)
        {
            Name = name;
            StreetAddress = streetAddress;
            Telephone = telephone;
        }

        public string Name { get => _name; set => _name = value; }
        public string StreetAddress { get => _streetAddress; set => _streetAddress = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }

        public override string ToString()
        {
            return $"Navn: {Name}, Adresse: {StreetAddress},Telefon: {Telephone} ";
        }
    }
}
