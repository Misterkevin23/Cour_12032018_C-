using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    class point2D
    {
        //int x;
        //int y;

        public point2D() : this(0, 0)
        {

        }

        //public point2D(int x, int y) {
        //    setX(x);
        //    setY(y);
        //    count++;
        //}

        public point2D(int attX, int attY)
        {
            this.X = attX;
            this.Y = attY;
            count++;
        }


        //en mettant prop et en appuyant deux fois sur tab --> les
        public int X { get; set; }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        
        static int count = 0;

        //public point2D()
        //{
        //    X(0);
        //    setY(0);
        //    count++;
        //}

        

        //public void setX(int valX)
        // {
        //     x = valX;
        // }

        // public void setY(int valY)
        // {
        //     y = valY;
        // }

        //public int getX()
        //{
        //    return x;
        //}

        //public int getY()
        //{
        //    return y;
        //}

        public string afficher()
        {
            return ("[" + X + ", " + Y + "]");
        }

        //public string afficher()
        //{
        //    return ("[" + getX() + ", " + getY() + "]");
        //}

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
