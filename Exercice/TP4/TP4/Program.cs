using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {

            Time t = new Time();
            string horaire;


            Console.WriteLine(t.Afficher());
            Console.WriteLine(t.Afficher("10:20"));
            Console.Write("Rentrer l'horaire sous la forme 'HH:mm :");
            horaire = Console.ReadLine();
            //Sans gestiond es exception
            //Console.WriteLine(t.Afficher(horaire));

            //Avec gestion des exception
            try
            {
                Console.WriteLine(t.Afficher(horaire));
            }
            catch (Exception)
            {
                Console.WriteLine("Boloss");
            }
        
            Console.Read();
        }
    }
}
