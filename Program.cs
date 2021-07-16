﻿using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program");

            while (true)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Edit members Contacts lists\n4.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        UC3EditContact.AddMember();
                        break;
                    case 2:
                        UC3EditContact.ViewContacts();
                        break;
                    case 3:
                        UC3EditContact.EditDetails();
                        break;
                    case 4:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;

                }
            }
        }
    }
}