using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Program of Address Book");

            while (true)
            {
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        UC1CreateAddressBook.AddMember();
                        break;
                    case 2:
                        UC1CreateAddressBook.ViewContacts();
                        break;
                    case 3:
                        // to exit from main method
                        return;

                }
            }
        }
    }
}