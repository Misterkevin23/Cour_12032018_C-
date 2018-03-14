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
            c1.AjouterCompte(new Compte(2, 1000), out message);
            Console.WriteLine(message);
            c1.AjouterCompte(new Compte(3, 1000), out message);
            Console.WriteLine(message);
            c1.AjouterCompte(new Compte(4, 1000), out message);
            Console.WriteLine(message);
            c1.AjouterCompte(new Compte(5, 1000), out message);
            Console.WriteLine(message);
            c1.AjouterCompte(new Compte(6, 1000), out message);
            Console.WriteLine(message);

            Console.WriteLine("Opération d'Ajout sur le Compte 1");
            cpt1.Ajouter(2000);
            Console.WriteLine(cpt1.ToString());
            cpt1.Retirer(1500);
            Console.WriteLine(cpt1.ToString());

            Console.WriteLine(c1.ToString());

            Console.ReadLine();
        }
    }
}
