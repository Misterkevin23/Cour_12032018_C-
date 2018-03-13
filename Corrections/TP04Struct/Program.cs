using MesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Class1 c1 = new Class1();
            Time t = new Time();
            string horaire;
            
            Console.WriteLine(t.Afficher());
             Console.WriteLine(t.Afficher("10:20"));
            Console.Write("Rentrer l'horaire sous la forme 'hh:mm'");
            horaire = Console.ReadLine();
            //Sans gestion des Exceptions
            // Console.WriteLine(t.Afficher(horaire));

            //Avec Gestion des Exceptions
            try
            {
                Console.WriteLine(t.Afficher(horaire));
            }
            catch (Exception ex)
            {

                Console.WriteLine("T'es une Buse !!!");
                Console.WriteLine(ex.Message);
            }

            System.Console.WriteLine("Coucou de C#");

            Console.ReadLine();
        }

 
    }
}
