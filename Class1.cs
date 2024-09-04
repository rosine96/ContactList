using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public class Contact
    {
     public string? nom { get; private set; }
    public string? prenom { get; private set;}
     public string? telephone { get; private set;}
        /*constructeur qui cree un contact en s'assurant que le nom et le prenom ne depasse pas 10 caracteres 
         * le numero de telephone aie 10 chiffres et commence par +1
         et le numero de telephone est essentiellement composer de chiffres
        */
        public Contact(string nom,string prenom,string telephone)
        {
            if (nom.Length > 10 || prenom.Length > 10)
            {
                throw new ArgumentException("le nom ou le prenom de doivent pas ecceder 10 caracteres");
            }
            if (telephone.Length != 12 && !telephone.StartsWith("+1"))
            { throw new ArgumentException("le numero de telephone au canada doit contenir 10 Chiffres et commencer par +1"); }
            foreach (var t in telephone)
            {
                if(t<0 || t>9)
                { throw new ArgumentException("le numero de telephone doit contenir uniquement des chiffres"); }
            }
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            

        }
        /*methode qui ajoute un contact */
        public void Ajouter(List <Contact> maListe)
        {
          maListe.Add(this);
            Console.WriteLine("Contact enregistre");
        }
        /*methode qui statique qui recherche un nom dans la liste et renvoie l'indexe du contact correspondant a ce nom */
        public static int IndexOff(string name,List<Contact>maliste)
        {
            int i = 0; bool trouve = false;
            while (i < maliste.Count && trouve==false) 
            {
                if (maliste[i].nom == name)
                { trouve = true; break; }
                i++;
            }
            if(trouve==true) { return i; }
            return -1;
        }
        /*methode qui permet de supprimer un contact */
        public void Supprimer(List <Contact> maListe,string name)
        {
          int i=IndexOff(name, maListe);
            if (i != -1) 
            {
                maListe.RemoveAt(i);
                Console.WriteLine("contact supprime");
            }
            else { Console.WriteLine("contact inexistant,veuillez surement revoir l'orthographe"); }
            
        }
        /*methode qui affiche la liste de  contact */
        public void AfficherLesContact(List<Contact>maliste)
        {
         foreach (var t in maliste) 
            {
                Console.WriteLine($"{t.prenom}{t.nom}:{t.telephone}");
            }
        }
        /*methode qui recherche un  contact */
        public void Rechercher(List<Contact> maListe, string name)
        {
            int i = IndexOff(name, maListe);
            if (i != -1)
            {
                Console.WriteLine($"{maListe[i].prenom}{maListe[i].nom}:{maListe[i].telephone}");
            }
            else { Console.WriteLine("contact inexistant,veuillez surement revoir l'orthographe"); }

        }

        /*methode qui modifie  contact */
        public void Modifier(List<Contact> maListe, string name)
        {
            int i = IndexOff(name, maListe);
            if (i != -1)
            {
                Console.WriteLine("entrer le nouveau prenom");
                maListe[i].prenom=Console.ReadLine();
                Console.WriteLine("entrer le nouveau nom");
                maListe[i].nom = Console.ReadLine();
                Console.WriteLine("entrer le nouveau numero de telephone");
                maListe[i].telephone = Console.ReadLine();
            }
            else { Console.WriteLine("contact inexistant,veuillez surement revoir l'orthographe"); }

        }


    }
}
