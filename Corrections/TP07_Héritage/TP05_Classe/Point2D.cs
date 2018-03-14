using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05_Classe
{
    class Point2D
    {
        public Point2D() : this(0, 0)
        {

        }

        public Point2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        private int x; //Champs en .Net équivalent à Atrribut en Java

        public int X
        {
            get { return x; }
              set { x = value; }
        }

        public int Y { get; set; }


        //int x, y;

        //public void SetX(int dx)
        //{
        //    x = dx;
        //}

        //public void SetY(int dy)
        //{
        //    y = dy;
        //}

        //public int GetX() { return this.x; }

        //public int GetY() { return this.y; }

        public virtual string Afficher()
        {
            return string.Format("Valeur du point 2D : [{0},{1}]", x, Y);
        }

        public void Translater(int dx, int dy)
        {

            this.x += dx;
            this.Y += dy;
        }
    }
}
