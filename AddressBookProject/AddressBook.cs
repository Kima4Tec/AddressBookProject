using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AddressBookProject
{
    internal class AddressBook
    {
        //Fields
        string _Owner;
        List<Adress> _adresses = new List <Adress>();

        //Constructor
        public AddressBook(string owner)
        {
            Owner = owner;
        }

        //Properties
        public string Owner { get => _Owner; set => _Owner = value; }

        //Add adresse metode med parameter adress
        public void AddAddress(Adress adress) 
        {
            _adresses.Add(adress);
        }

        public string PrintOut(string owner, ConsoleColor color = ConsoleColor.Blue)
        {
            Console.ForegroundColor = color;
            Console.Write(owner);
            Console.ResetColor();
            return owner;
        }

        public override string? ToString()
        {
            //Udskriver først ejers navn og dernæst udskriver den adresserne ved en foreach, der udskriver adressernes ToString
            string ownersAddresses = string.Empty;
            PrintOut($"{Owner}'s adressebog:\n", ConsoleColor.Blue);
            foreach (var address in _adresses)
            {
                ownersAddresses += address.ToString() + "\n";
            }
            return ownersAddresses;
 
 
        }

        //Fjerner adresser gennem index
        public void RemoveAddress(int index)
        {
            if (index >= 0 && index < _adresses.Count)
            {
                _adresses.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Denne findes ikke");
            }
        }
    }
}
