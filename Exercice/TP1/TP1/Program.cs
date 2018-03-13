using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            String utilisateur = "";
            int actuelHour = DateTime.Now.Hour;
            DayOfWeek jour = DateTime.Now.DayOfWeek;

            Console.Write("Votre Nom: ");
            utilisateur = Console.ReadLine();

            switch (jour)
            {
                case DayOfWeek.Monday:
                {
                    if(actuelHour < 9)
                    {
                        Console.Write("⦁Bon week-end  " + utilisateur);
                            
                    }
                    else if(actuelHour > 9 && actuelHour < 18)
                    {
                        Console.Write("Bonjour " + utilisateur);
                    }
                    else
                    {
                            Console.Write("Bonjour " + utilisateur);
                    }
                    break;
                 }

                case DayOfWeek.Saturday:
                    {
                        Console.Write("⦁Bon week-end  " + utilisateur);
                        break;
                    }

                case DayOfWeek.Sunday:
                    {
                        Console.Write("Bon week-end  " + utilisateur);
                        break;
                    }

                default:
                    {
                        if (actuelHour > 9 && actuelHour < 18)
                        {
                            if(jour == DayOfWeek.Tuesday)
                            {
                                Console.Write("Bonjour " + utilisateur + "c’est bientôt le week-end");
                            }
                            else
                            {
                                Console.Write("Bonjour " + utilisateur);
                            }
                            
                        }
                        else
                        {
                            Console.Write("Bonsoir " + utilisateur);
                        }
                        break;
                    }

            }
            
            Console.Read();
        }
    }
}
