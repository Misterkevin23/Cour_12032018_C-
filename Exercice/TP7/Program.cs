using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(5, 6, 9);
            Console.Write(p1.afficher());
            p1.translater(1, 1, 1);
            Console.Write(p1.afficher());
            Console.Read();
        }
    }
}
