﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            Client c1 = new Client("Skywalker",
                "Luke", new DateTime(2044, 03, 03), 1);
            Compte cpt1 = new Compte(1, 1000);
            c1.ajouterCompte(cpt1, out message);
            Console.WriteLine(message);
            c1.ajouterCompte(new Compte(2, 2300), out message);
            Console.WriteLine(message);
            c1.ajouterCompte(new CompteRemunere(3, 4200,0.3), out message);
            Console.WriteLine(message);
            c1.ajouterCompte(new CompteRemunere(4, 7000, 0.5), out message);
            Console.WriteLine(message);
            c1.ajouterCompte(new CompteASeuil(5, 300, 200), out message);
            Console.WriteLine(message);
            c1.ajouterCompte(new Compte(6, 1700), out message);
            Console.WriteLine(message);

            Console.WriteLine("Opération d'Ajout sur le Compte 1");
            cpt1.ajouter(2000);
            Console.WriteLine(cpt1.ToString());
            cpt1.retirer(1500);
            Console.WriteLine(cpt1.ToString());

            Console.WriteLine(c1.ToString());

            Console.WriteLine(c1.getCompte(4) );

            Console.WriteLine("Affichage de la liste des comptes");
            foreach (Compte cpt in c1.compte)
            {
                Console.WriteLine(cpt.ToString());
            }

            Console.WriteLine("Récupération et utilisation du Compte Rémunéré N°5");
            CompteRemunere cpt2 = c1.getCompte(5) as CompteRemunere; //Lorsque l'on utilise as si il ne trouve pas le type voulu, il renvoi null donc il faut verifier que le champs ne soit pas null avant de lancer la méthode

            if (cpt2 != null)
            {
                cpt2.verserInterets();
                Console.WriteLine(cpt2.ToString());
            }

            Console.WriteLine("Récupération et utilisation du Compte A Seuil N° 4");
            CompteASeuil cpt3 = c1.getCompte(4) as CompteASeuil;
            if (cpt3 != null)
            {
                Console.WriteLine(cpt3.ToString());
                cpt3.retirer(600);
                Console.WriteLine(cpt3.ToString());
            }


            Console.ReadLine();
        }
    }
}
