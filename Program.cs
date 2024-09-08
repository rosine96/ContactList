using System.Security.Cryptography.X509Certificates;

namespace ContactList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Contact> listOfContact = new List<Contact>();
            int choix=0;
            Console.WriteLine(@"bienvenue dans ContactList!
                      quelle operation souhaitez vous effectuer?
                                1-ajouter un contact
                                2-rechercher un contact
                                3-modifier un contact
                                 4- supprimer un contact
                                 5-afficher la listes des contacts");
            choix=int.Parse(Console.ReadLine());
            switch( choix )
            {
                case 1:
                    Console.WriteLine("entrer le nom");
                    string name=Console.ReadLine();
                    Console.WriteLine("entrer le prenom");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("entrerle numero de telephone");
                    string phone = Console.ReadLine();
                    try
                    {
                        Contact myContact = new Contact(name, firstName, phone);
                        myContact.Ajouter(listOfContact);
                    }
                    catch(Exception ex) {Console.WriteLine(ex.Message); }
                    
                    break;

            }
        }
    }
}