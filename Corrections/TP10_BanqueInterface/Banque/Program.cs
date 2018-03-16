using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            Client c1 = new Client("Skywalker",
                "Luke", new DateTime(2044, 03, 03), 1);
            Compte cpt1 = new Compte(1, 10);
            c1.AjouterCompte(cpt1, out message);
            Console.WriteLine(message);
            c1.AjouterCompte(new CompteRemunere(2, 1000), out message);
            Console.WriteLine(message);
            c1.AjouterCompte(new CompteASeuilRemunere(3, 1000), out message);
            Console.WriteLine(message);
            c1.AjouterCompte(new CompteASeuil(4, 1000, 500), out message);
            Console.WriteLine(message);
            c1.AjouterCompte(new CompteRemunere(5, 1000,4), out message);
            Console.WriteLine(message);
            c1.AjouterCompte(new Compte(6, 1000), out message);
            Console.WriteLine(message);

            Console.WriteLine("Affichage de la liste des comptes");
            foreach (Compte cpt in c1.Comptes)
            {
                Console.WriteLine(cpt.ToString());
            }

            Console.WriteLine("Récupération et utilisation du Compte Rémunéré N°5");
            CompteRemunere  cpt2 = c1.GetCompte(5) as CompteRemunere;
            
            if (cpt2 !=null)
            {
                cpt2.VerserInteret();
                Console.WriteLine(cpt2.ToString());
            }

            Console.WriteLine("Récupération et utilisation du Compte A Seuil N° 4");
            CompteASeuil cpt3 = c1.GetCompte(4) as CompteASeuil;
            if (cpt3 != null)
            {
                Console.WriteLine(cpt3.ToString());
                cpt3.Retirer(600);
                Console.WriteLine(cpt3.ToString());
            }
            

            Console.ReadLine();
        }
    }
}
