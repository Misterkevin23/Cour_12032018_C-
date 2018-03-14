using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Compte compte1 = new Compte(1, 2300);
       ;


            Console.Write("Nouveau client:");
   
            Console.Write("Nom:");
            string nom = Console.ReadLine();
     

            Console.Write("Prénom:");
            string prenom = Console.ReadLine();

            Console.Write("Date de naissance (format DD/MM/AAAA):");
            string date = Console.ReadLine();

            Client client1 = new Client(nom, prenom, date, 1234);

            string message;
            client1.ajouterCompte(compte1, out message);
            Console.WriteLine(message);
            client1.ajouterCompte(new Compte(2, 4200), out message);
            Console.WriteLine(message);
            client1.ajouterCompte(new Compte(3, 2300), out message);
            Console.WriteLine(message);
            client1.ajouterCompte(new Compte(4, 700), out message);
            Console.WriteLine(message);
            client1.ajouterCompte(new Compte(5, 300), out message);
            Console.WriteLine(message);
            client1.ajouterCompte(new Compte(6, 5200), out message);
            Console.WriteLine(message);
            client1.ajouterCompte(new Compte(7, 9800), out message);

            Console.Write(client1.getCompte(1));
          

            Console.Read();


        }
    }
}
