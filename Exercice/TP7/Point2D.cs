using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class Point2D
    {
        public Point2D() : this(0, 0)
        {

        }

        public Point2D(int attX, int attY)
        {
            this.X = attX;
            this.Y = attY;
            count++;
        }

        public int X { get; protected set; }

        private int y;

        public int Y // Champs en .Net équivalent à attribut en Java
        {
            get { return y; }
            protected set { y = value; }
        }

        static int count = 0;

        public virtual string afficher()
        {
            return ("[" + X + ", " + Y + "]");
        }

        public void translater(int dX, int dY)
        {
            X = X + dX;
            y = y + dY;
        }

        public static int Point2DCount()
        {
            return count;
        }
    }
}
