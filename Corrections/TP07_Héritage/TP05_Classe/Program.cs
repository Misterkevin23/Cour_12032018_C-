using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Création d'un premier Point 2D");
            Point2D p1 = new Point2D();
            //p1.SetX(10);
            //p1.SetY(20);
            p1.X = 10;
            p1.Y = 20;

            Console.WriteLine("Affichage de p1: {0}", p1.Afficher());

            Console.WriteLine("Création d'un deuxième Point 2D");
            Point2D p2 = new Point2D();
            p2.X = 3;
            p2.Y = 10;
            //p2.SetX( 3);
            //p2.SetY(10);

            Console.WriteLine("Affichage de p2: {0}", p2.Afficher());
            Console.WriteLine("Translation 15,20");
            p2.Translater(15, 20);
            Console.WriteLine("Affichage de p2: {0}", p2.Afficher());

            Console.WriteLine("Création d'un troisième Point 2D");
            Point2D p3 = new Point2D();
            Console.WriteLine("Affichage de p3: {0}", p3.Afficher());

            Point2D p4 = new Point2D(1, 1);
            Console.WriteLine("Affichage de p4: {0}", p4.Afficher());

            //Point2D p5 = new Point2D { X = 10};
            //Console.WriteLine("Affichage de p5: {0}", p5.Afficher());

            //Console.WriteLine(p5.ToString());

            Console.WriteLine("Création d'un point 3D");
            Point3D p5 = new Point3D(1, 1, 1);
            Console.WriteLine("Affichage de p5: {0}", p5.Afficher());

            Console.ReadLine();
        }
    }
}
