using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;
            int somme = 0;
            bool hasMax = false;
            bool hasMin = false;

            
            Console.Write("Entrez le nombre min:");
            hasMin = int.TryParse(Console.ReadLine(), out min);
            Console.Write("Entrez le nombre max:");
            hasMax = int.TryParse(Console.ReadLine(), out max);
         
            if(hasMax && hasMin)
            {
                somme = calculerSommeEntier(min, max);
                Console.Write(somme);
                Console.Read();
            }
           

        }

        public static int calculerSommeEntier(int min, int max)
        {
            int result = 0;
            for (int i = min; i <= max; i++)
            {
                result = result + i;
            }
            return result;
        }


    }
}
