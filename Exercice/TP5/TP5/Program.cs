using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
     
            point2D p1 = new point2D();
            point2D dPoint2D = new point2D(7,23);

            //Console.Write(p1.getX());
            //Console.Write(p1.getY());
            Console.Write(p1.X);
            Console.Write(p1.Y);
            p1.X = 7;
            p1.Y = 42;

            
            Console.Write(p1.afficher());
            Console.Read();

            point2D p2 = new point2D { X = 10, Y = 20 }; //Initialiseur de classe possible que si on a un constructeur par default; on peut parametrer que les champs qui nous interessent






        }
    }
}
