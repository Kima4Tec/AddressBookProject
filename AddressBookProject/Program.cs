using System;

namespace AddressBookProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Først opretter og udskriver jeg Jans adressebog
            AddressBook jansAddressBook = new AddressBook("Jan");
            Adress adressJan1 = new Adress("Hans Peter Nielsen", "Birkehøj 5", "2134123456");
            Adress adressJan2 = new Adress("Jens Peter ´Larsen", "Poppelhøj 6", "2345619481");
            jansAddressBook.AddAddress(adressJan1);
            jansAddressBook.AddAddress(adressJan2);
            Console.WriteLine(jansAddressBook.ToString());

            //Derefter opretter og udskriver jeg Jans adressebog
            AddressBook bosAddressBook = new AddressBook("Bo");
            Adress adressBo1 = new Adress("Niels Peter Hansen", "Bøgehøj 7", "213412345636");
            Adress adressBo2 = new Adress("Lars Peter Jensen", "Fyrrehøj 8", "2345679801");
            bosAddressBook.AddAddress(adressBo1);
            bosAddressBook.AddAddress(adressBo2);
            Console.WriteLine(bosAddressBook.ToString());

            //Tilsidst lægger adresserne fra de to adressebøger sammen
            AddressBook janbosAddressBook = new AddressBook("Jan og Bo");
            janbosAddressBook.AddAddress(adressJan1);
            janbosAddressBook.AddAddress(adressJan2);
            janbosAddressBook.AddAddress(adressBo1);
            janbosAddressBook.AddAddress(adressBo2);
            Console.WriteLine(janbosAddressBook.ToString());

            //Der fjernes en adresse fra den fælles adressebog
            janbosAddressBook.RemoveAddress(2);

            //Den fælles adressebog udskrives
            Console.WriteLine(janbosAddressBook.ToString());



        }
    }
}
