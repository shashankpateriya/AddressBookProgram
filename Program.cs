using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program");
            AddressBookDetails abd = new AddressBookDetails();

            while (true)
            {

                Console.WriteLine("*********************************************************");
                Console.WriteLine("1.Add member to Contact list \n2.View Members in Contact List\n3.Edit members Contacts list\n4.Delete members Contacts list\n5.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        abd.AddMember();
                        //UC1CreateAddressBook.AddMember();
                        //UC2AddContacts.AddMember();
                        //UC3EditContact.AddMember();
                        //UC4DeleteContact.AddMember();
                        //UC5AddMultipleContacts.AddMember();
                        break;
                    case 2:
                        abd.ViewContacts();
                        //UC1CreateAddressBook.ViewContacts();
                        //UC2AddContacts.ViewContacts();
                        //UC3EditContact.ViewContacts();
                        //UC4DeleteContact.ViewContacts();
                        //UC5AddMultipleContacts.ViewContacts();
                        break;
                    case 3:
                        abd.EditDetails();
                        //UC3EditContact.EditDetails();
                        //UC4DeleteContact.EditDetails();
                        //UC5AddMultipleContacts.EditDetails();
                        break;
                    case 4:
                        abd.DeleteDetails();
                        //UC4DeleteContact.DeleteDetails();
                        /UC5AddMultipleContacts.DeleteDetails();
                        break;
                    case 5:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;

                }

            }
        }
    }
}